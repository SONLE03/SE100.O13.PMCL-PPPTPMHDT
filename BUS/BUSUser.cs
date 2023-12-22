using DAL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            return gap >= BUSRule.Instance.GetAllRule().MinimumAge;
        }
        private bool EmailValidator(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$");
        }
        private bool CheckValidator(DateTime DateofBirth, string Phone, string UserName,string Password
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
                MessageBox.Show("User must be over 18 years old", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!CheckValidator(DateofBirth, Phone, UserName, Password, retypePass, Email, GroupUserID, status)) return false;
            
            if (!DALUser.Instance.AddUser(UserFullName, DateofBirth, Address, Phone, UserName, Password, Email, GroupUserID, image, status))
            {
                MessageBox.Show("Add failure user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Add new user successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public bool UpdUser(int id, string UserFullName, DateTime DateofBirth, string Address, string Email, string Phone,
                                 int GroupUserID, string status, string image, string password)
        {
            if(!CheckValidator(DateofBirth, Phone, null, password, password, Email, GroupUserID, status)) return false;
            if(!DALUser.Instance.UpdUser(id, UserFullName, DateofBirth, Address, Email, Phone, GroupUserID, status, image))
            {
                MessageBox.Show("Update failure user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Update user information successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public bool DelUser(int id)
        {
            return DALUser.Instance.DelUser(id);
        }
        public bool UpdPassword(int id, string password)
        {
            return DALUser.Instance.UpdPassword(id, password);
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
