using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSize
    {
        private static DALSize instance;

        public static DALSize Instance
        {
            get
            {
                if (instance == null) instance = new DALSize();
                return instance;
            }
            set => instance = value;
        }
        public List<C_SIZE> GetAllSize()
        {
            return CFEntities.Instance.C_SIZE.AsNoTracking().OrderByDescending(size => size.id).ToList();
        }
        public C_SIZE GetSizeById(int id)
        {
            return CFEntities.Instance.C_SIZE.Find(id);
        }
        public C_SIZE GetSizeByCode(string idSize)
        {
            var res = CFEntities.Instance.C_SIZE.AsNoTracking().Where(m => m.SizeID == idSize);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public C_SIZE GetSizeBySizeName(string sizeName)
        {
            var res = CFEntities.Instance.C_SIZE.AsNoTracking().Where(n => n.SizeName.ToLower() == sizeName.ToLower());
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
        public List<C_SIZE> FindSize(string sizeName)
        {
            var res = CFEntities.Instance.C_SIZE.ToList();
            if (sizeName != null) res = res.Where(t => t.SizeName == sizeName).Select(t => t).ToList();
            return res;
        }
        public bool AddSize(string sizeName)
        {
            try
            {
                var obj = new C_SIZE();
                obj.SizeName = sizeName;
                obj.DRINKS_SIZE = new List<DRINKS_SIZE>();
                CFEntities.Instance.C_SIZE.Add(obj);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool UpdSize(int idSize, string sizeName)
        {
            try
            {
                C_SIZE size = GetSizeById(idSize);
                if (size == null) return false;
                if (sizeName != null) size.SizeName = sizeName;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DelSize(int idSize)
        {
            using (var transaction = CFEntities.Instance.Database.BeginTransaction())
            {
                try
                {
                    C_SIZE size = GetSizeById(idSize);
                    if (size == null) return false;
                    CFEntities.Instance.C_SIZE.Remove(size);
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
