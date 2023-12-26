using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace BUS
{
    public class BUSCategory
    {
        private static BUSCategory instance;

        public static BUSCategory Instance
        {
            get
            {
                if (instance == null) instance = new BUSCategory();
                return instance;
            }
            set { instance = value; }
        }

        public List<CATEGORY> GetAllCategory()
        {
            return DALCategory.Instance.GetAllCategory();
        }
        public List<CATEGORY> GetAllCategoryActive()
        {
            return DALCategory.Instance.GetAllCategoryActive();
        }
        public List<CATEGORY> GetAllCategoryInActive()
        {
            return DALCategory.Instance.GetAllCategoryInActive();
        }
        public CATEGORY GetCategoryById(int id)
        {
            return DALCategory.Instance.GetCategoryById(id);
        }
        public CATEGORY GetCategoryByName(string cateName)
        {
            return DALCategory.Instance.GetCategoryByName(cateName);
        }       
        public bool AddCategory(string CategoryName, string status)
        {
            try
            {
                if (GetCategoryByName(CategoryName) != null)
                {
                    MessageBox.Show("The category already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (DALCategory.Instance.AddCategory(CategoryName, status)) return true;
                MessageBox.Show("Add failure category", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch
            {
                MessageBox.Show("Add failure category", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdCategory(int idCat, string CategoryName, string Status)
        {
            try
            {
                var cate = GetCategoryByName(CategoryName);
                if (cate != null && cate.id != idCat)
                {
                    MessageBox.Show("The category already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (DALCategory.Instance.UpdCategory(idCat, CategoryName, Status)) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Modify failure category", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool categoryIsBlocked(int id)
        {
            return DALCategory.Instance.categoryIsBlocked(id);
        }
        public List<CATEGORY> Search(string searchText, string selectedStatus)
        {
            return DALCategory.Instance.SearchCategory(searchText, selectedStatus);
        }
    }
}
