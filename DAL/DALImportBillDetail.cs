using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALImportBillDetail
    {
        private static DALImportBillDetail instance;
        public static DALImportBillDetail Instance
        {
            get
            {
                if (instance == null) instance = new DALImportBillDetail();
                return instance;
            }
            set => instance = value;
        }
        public List<IMPORT_BILL_DETAIL> GetAllCTPhieuNhap()
        {
            return CFEntities.Instance.IMPORT_BILL_DETAIL.AsNoTracking().ToList();
        }
        public IMPORT_BILL_DETAIL GetCTPhieuNhap(int No, int idIB)
        {
            return CFEntities.Instance.IMPORT_BILL_DETAIL.Find(new object[] { No, idIB });
        }

        public bool AddImportBillDetail(int idx, int idIB, string Name, string Unit, int Quantity, double Rate)
        {
            try
            {
                var bill = DALImportBill.Instance.GetImportBillById(idIB);
                if (bill == null) return false;
                var ct = new IMPORT_BILL_DETAIL
                {
                    No = idx,
                    ImportID = idIB,
                    IMPORT_BILL = DALImportBill.Instance.GetImportBillById(idIB),
                    ImportMName = Name,
                    Unit = Unit,
                    Quantity = Quantity,
                    Rate = Rate,
                    Amount = Quantity * Rate
                };
                CFEntities.Instance.IMPORT_BILL_DETAIL.Add(ct);
                DALImportBill.Instance.UpdImportBill(idIB, bill.Total + ct.Amount);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public void DeleteImportBillDetail(int idIB, DbContextTransaction transaction)
        {
            try
            {
                List<IMPORT_BILL_DETAIL> importBillDetails = CFEntities.Instance.IMPORT_BILL_DETAIL.Where(p => p.ImportID == idIB).ToList();
                if (importBillDetails.Any())
                {
                    foreach (var importBillDetail in importBillDetails)
                    {
                        CFEntities.Instance.IMPORT_BILL_DETAIL.Remove(importBillDetail);
                    }
                    CFEntities.Instance.SaveChanges();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
                return;
            }
        }
    }
}
