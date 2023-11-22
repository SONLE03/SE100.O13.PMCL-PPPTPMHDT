using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALImportBill
    {
        private static DALImportBill instance;
        public static DALImportBill Instance
        {
            get
            {
                if (instance == null) instance = new DALImportBill();
                return instance;
            }
            set => instance = value;
        }
        public List<IMPORT_BILL> GetAllImportBill()
        {
            return CFEntities.Instance.IMPORT_BILL.AsNoTracking().ToList();
        }
        public IMPORT_BILL GetImportBillById(int id)
        {
            return CFEntities.Instance.IMPORT_BILL.Find(id);
        }
        public IMPORT_BILL GetImportBillByCode(string importID)
        {
            var res = CFEntities.Instance.IMPORT_BILL.AsNoTracking().Where(m => m.ImportID == importID);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<IMPORT_BILL> FindImportBill(string ImportID, string ImportName)
        {
            var res = CFEntities.Instance.IMPORT_BILL.ToList();
            if (ImportID != null) res = res.Where(t => t.ImportID == ImportID).Select(t => t).ToList();
            if (ImportName != null) res = res.Where(t => t.ImportName == ImportName).Select(t => t).ToList();
            return res;
        }
        public bool AddImportBill(string ImportName, DateTime ImportDate, SUPPLIER Supplier, C_USER User)
        {
            try
            {
                var obj = new IMPORT_BILL();
                obj.ImportName = ImportName;
                obj.SupplierID = Supplier.id;
                obj.UserID = User.id;
                obj.Total = 0;
                obj.ImportDate = ImportDate;
                CFEntities.Instance.IMPORT_BILL.Add(obj);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool DelImportBill(int idIB)
        {
            using (var transaction = CFEntities.Instance.Database.BeginTransaction())
            {
                try
                {
                    IMPORT_BILL ib = GetImportBillById(idIB);
                    if (ib == null) return false;
                    CFEntities.Instance.IMPORT_BILL.Remove(ib);
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
        public bool UpdImportBill(int id, double? total)
        {
            try
            {
                IMPORT_BILL phieu = CFEntities.Instance.IMPORT_BILL.Find(id);
                if (phieu == null) return false;
                if (total != null) phieu.Total = total.Value;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
