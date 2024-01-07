using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return CFEntities.Instance.IMPORT_BILL.AsNoTracking().OrderByDescending(importBill => importBill.ImportDate).ToList();
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
        public List<IMPORT_BILL> SearchImportBill(string searchText)
        {
            var transformedNameImportBill = DALConstraint.Instance.TransformString(searchText);
            List<IMPORT_BILL> listSImportBill = CFEntities.Instance.IMPORT_BILL.ToList();
            List<IMPORT_BILL> filteredList = new List<IMPORT_BILL>();
            filteredList = listSImportBill
                .Where(p =>
                    (string.IsNullOrEmpty(transformedNameImportBill) || p.ImportName.ToLower().Contains(transformedNameImportBill.ToLower()) || p.SUPPLIER.SupplierName.ToLower().Contains(transformedNameImportBill.ToLower()))
                )
                .ToList();
            return filteredList;
        }
        public int AddImportBill(string ImportName, DateTime ImportDate, int SupplierId, int UserId)
        {
            try
            {
                var obj = new IMPORT_BILL();
                obj.ImportName = DALConstraint.Instance.TransformString(ImportName);
                obj.SupplierID = SupplierId;
                obj.UserID = UserId;
                obj.Total = 0;
                obj.ImportDate = ImportDate;
                CFEntities.Instance.IMPORT_BILL.Add(obj);
                CFEntities.Instance.SaveChanges();
                return obj.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
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
                    DALImportBillDetail.Instance.DeleteImportBillDetail(idIB, transaction);
                    CFEntities.Instance.IMPORT_BILL.Remove(ib);
                    CFEntities.Instance.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
