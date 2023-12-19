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
        public CATEGORY GetCategoryByCode(string cateID)
        {
            var res = CFEntities.Instance.CATEGORies.AsNoTracking().Where(m => m.CategoryID == cateID);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<CATEGORY> FindCategory(string CategoryID, string CategoryName)
        {
            var res = CFEntities.Instance.CATEGORies.ToList();
            if (CategoryID != null) res = res.Where(t => t.CategoryID == CategoryID).Select(t => t).ToList();
            if (CategoryName != null) res = res.Where(t => t.CategoryName == CategoryName).Select(t => t).ToList();
            return res;
        }
        public bool AddCategory(string CategoryName, string status)
        {
            try
            {
                var obj = new CATEGORY();
                obj.CategoryName = CategoryName;
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
                CATEGORY cat = GetCategoryById(idCat);
                if (cat == null) return false;
                if (CategoryName != null) cat.CategoryName = CategoryName;
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
        public bool DelCategory(int idCat)
        {
            using (var transaction = CFEntities.Instance.Database.BeginTransaction())
            {
                try
                {
                    CATEGORY cat = GetCategoryById(idCat);
                    if (cat == null) return false;
                    CFEntities.Instance.CATEGORies.Remove(cat);
                    CFEntities.Instance.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}
