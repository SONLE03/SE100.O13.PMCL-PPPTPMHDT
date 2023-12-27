using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCategory
    {
        private static DALCategory instance;

        public static DALCategory Instance
        {
            get
            {
                if (instance == null) instance = new DALCategory();
                return instance;
            }
            set => instance = value;
        }
        public List<CATEGORY> GetAllCategory()
        {
            return CFEntities.Instance.CATEGORies.AsNoTracking().ToList();
        }
        public List<CATEGORY> GetAllCategoryActive()
        {
            return CFEntities.Instance.CATEGORies.AsNoTracking().Where(m => m.Status == "Active").ToList();
        }
        public List<CATEGORY> GetAllCategoryInActive()
        {
            return CFEntities.Instance.CATEGORies.AsNoTracking().Where(m => m.Status == "InActive").ToList();
        }
        public CATEGORY GetCategoryById(int id)
        {
            return CFEntities.Instance.CATEGORies.Find(id);
        }
        public bool categoryIsBlocked(int id)
        {
            CATEGORY category = GetCategoryById(id);
            if (category.Status.Equals("Active")) return false;
            return true;
        }
        public CATEGORY GetCategoryByName(string nameCategory)
        {
            var transformedNameCategory = DALConstraint.Instance.TransformString(nameCategory);
            var allCategory = CFEntities.Instance.CATEGORies.AsNoTracking().ToList();
            var res = allCategory.Where(m => DALConstraint.Instance.TransformString(m.CategoryName.ToLower()) == transformedNameCategory);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<CATEGORY> SearchCategory(string searchText, string selectedStatus)
        {
            var transformedNameCategory = DALConstraint.Instance.TransformString(searchText);
            List<CATEGORY> listCategory = CFEntities.Instance.CATEGORies.ToList();
            List<CATEGORY> filteredList = new List<CATEGORY>();
            filteredList = listCategory
                .Where(p =>
                    (string.IsNullOrEmpty(transformedNameCategory) || p.CategoryName.ToLower().Contains(transformedNameCategory)) &&
                    (selectedStatus == "All" || string.Equals(p.Status, selectedStatus, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();
            return filteredList;
        }
        public bool AddCategory(string CategoryName, string status)
        {
            try
            {
                var transformedCategory = DALConstraint.Instance.TransformString(CategoryName);
                var obj = new CATEGORY();
                obj.CategoryName = transformedCategory;
                obj.Status = status;
                CFEntities.Instance.CATEGORies.Add(obj);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool UpdCategory(int idCat, string CategoryName, string Status)
        {
            try
            {
                var transformedCategory = DALConstraint.Instance.TransformString(CategoryName);
                CATEGORY cat = GetCategoryById(idCat);
                if (cat == null) return false;
                if (CategoryName != null) cat.CategoryName = transformedCategory;
                if (Status != cat.Status)
                {
                    cat.Status = Status;
                    foreach(var drink in cat.DRINKS)
                    {
                        drink.Status = Status;
                    }
                }
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
