using DAL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace BUS
{
    public class BUSUser
    {
        private static BUSUser instance;

        public static BUSUser Instance
        {
            get
            {
                if (instance == null) instance = new BUSUser();
                return instance;
            }
            set { instance = value; }
        }
        public int idUserLogin { get; set; }
        public DateTime dateLogin { get; set; }
        public void SetUserLoginInfo(int userID)
        {
            idUserLogin = userID;
            dateLogin = DateTime.Now;
            BUSOrder.Instance.GetAllInvoicesForYourShift();
        }
        public List<C_USER> GetAllUser()
        {
            return DALUser.Instance.GetAllUser();
        }
        public List<C_USER> GetAllUserActive()
        {
            return DALUser.Instance.GetAllUserActive();
        }

        public C_USER GetUserById(int id)
        {
            return DALUser.Instance.GetUserById(id);
        }

        public C_USER GetUserByCode(string UserID)
        {
            return DALUser.Instance.GetUserByCode(UserID);
        }
        public bool checkUserInUserGroupLogin(int idGroupUser)
        {
            C_USER user = BUSUser.instance.GetUserById(idUserLogin);
            if (user.GroupUserID == idGroupUser)
            {
                return true;
            }
            return false;
        }
        public C_USER GetUserByUsername(string username)
        {
            return DALUser.Instance.GetUserByUsername(username);
        }
        public C_USER GetUserByUsernameAndEmail(string username, string email)
        {
            return DALUser.Instance.GetUserByUsernameAndEmail(username, email);
        }

        public bool GetUserByIDGroupUser(int idGU)
        {
            return DALUser.Instance.GetUserByIDGroupUser(idGU);
        }
        public bool checkGroupUserStatus(int groupUserID, string status)
        {
            GROUPUSER groupUser = BUSGroupUser.Instance.GetGroupUserById(groupUserID);
            if (groupUser.Status.Equals("InActive") && status.Equals("Active")) return false;
            return true;
        }
        private bool UserNameValidator(string username)
        {
            if (username.Length < 6)
                return false;
            // Kiểm tra ký tự chấp nhận
            if (!Regex.IsMatch(username, "^[a-z0-9A-Z_àáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ ]*$"))
                return false;
            return true;
        }
        private bool PasswordValidator(string password, string retypePass)
        {
            return password.Length >= 8 && password.Equals(retypePass) && Regex.IsMatch(password, "[a-zA-Z]") && Regex.IsMatch(password, "\\d");
        }
        private bool DateOfBirthValidator(DateTime DateofBirth)
        {
            DateTime createDate = DateTime.Now;
            int gap = createDate.Year - DateofBirth.Year;
            if (createDate.Month < DateofBirth.Month || (createDate.Month == DateofBirth.Month && createDate.Day < DateofBirth.Day))
                gap -= 1;
            return gap >= BUSRule.Instance.GetAllRule().MinimumAge && gap <= BUSRule.Instance.GetAllRule().MaximumAge;
        }
        private bool EmailValidator(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$");
        }
        private bool CheckAddUserValidator(DateTime DateofBirth, string Phone, string UserName,string Password
                                    ,string retypePass, string Email, int GroupUserID, string status)
        {
            if (!checkGroupUserStatus(GroupUserID, status))
            {
                MessageBox.Show("Add Failure User, User Group Is Blocked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (GetUserByUsername(UserName) != null)
            {
                MessageBox.Show("The UserName already exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (UserNameValidator(UserName))
            {
                MessageBox.Show("Invalid UserName", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!BUSConstraint.Instance.PhoneNumberValidator(Phone))
            {
                MessageBox.Show("Invalid phone number", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!PasswordValidator(Password, retypePass))
            {
                MessageBox.Show("Password validation failed. Please make sure the passwords match and meet the requirements.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!DateOfBirthValidator(DateofBirth))
            {
                MessageBox.Show($"User must be over 18 years old and under {BUSRule.Instance.GetAllRule().MaximumAge} years old ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!EmailValidator(Email))
            {
                MessageBox.Show("Invalid email address format. The template is \"example@gmail.com\"", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool AddUser(string UserFullName, DateTime DateofBirth, string Address, string Phone, string UserName, 
                            string Password, string retypePass, string Email, int GroupUserID, string image, string status)
        {
            if (!CheckAddUserValidator(DateofBirth, Phone, UserName, Password, retypePass, Email, GroupUserID, status)) return false;
            
            if (!DALUser.Instance.AddUser(UserFullName, DateofBirth, Address, Phone, UserName, GeneratePassword(Password), Email, GroupUserID, image, status))
            {
                MessageBox.Show("Add failure user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Add new user successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private bool CheckUpdateUserValidator(DateTime DateofBirth, string Phone, string Email, int GroupUserID, string status)
        {
            if (!checkGroupUserStatus(GroupUserID, status))
            {
                MessageBox.Show("Add Failure User, User Group Is Blocked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!BUSConstraint.Instance.PhoneNumberValidator(Phone))
            {
                MessageBox.Show("Invalid phone number", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!DateOfBirthValidator(DateofBirth))
            {
                MessageBox.Show($"User must be over 18 years old and under {BUSRule.Instance.GetAllRule().MaximumAge} years old ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!EmailValidator(Email))
            {
                MessageBox.Show("Invalid email address format. The template is \"example@gmail.com\"", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool UpdUser(int id, string UserFullName, DateTime DateofBirth, string Address, string Email, string Phone,
                                 int GroupUserID, string status, string image)
        {
            if(!CheckUpdateUserValidator(DateofBirth, Phone, Email, GroupUserID, status)) return false;
            if(!DALUser.Instance.UpdUser(id, UserFullName, DateofBirth, Address, Email, Phone, GroupUserID, status, image))
            {
                MessageBox.Show("Update failure user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Update user information successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public string GeneratePassword(string password)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
        }
        public bool UpdPassword(int id, string password)
        {
            if (!PasswordValidator(password, password))
            {
                MessageBox.Show("Password validation failed. Please make sure the passwords match and meet the requirements.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DALUser.Instance.UpdPassword(id, GeneratePassword(password)))
            {
                MessageBox.Show("Change password successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Change password failed, please check again your password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public List<C_USER> SearchUser(string searchText, string selectedStatus)
        {
            return DALUser.Instance.SearchUser(searchText, selectedStatus);
        }
        public bool UpdateImageErrorNotFound(int idUser, string Image)
        {
            return DALUser.Instance.UpUserImageNotFound(idUser, Image);
        }
    }
}
