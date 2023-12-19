using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public CATEGORY GetCategoryByCode(string cateID)
        {
            return DALCategory.Instance.GetCategoryByCode(cateID);
        }       
        public bool AddCategory(string CategoryName, string status)
        {
            return DALCategory.Instance.AddCategory(CategoryName, status);
        }
        public bool UpdCategory(int idCat, string CategoryName, string Status)
        {
            return DALCategory.Instance.UpdCategory(idCat, CategoryName, Status);
        }
        public bool DelCategory(int idCat)
        {
            return DALCategory.Instance.DelCategory(idCat);
        }
    }
}
