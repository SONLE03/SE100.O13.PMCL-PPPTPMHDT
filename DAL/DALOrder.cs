using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALOrder
    {
        private static DALOrder instance;
        public static DALOrder Instance
        {
            get
            {
                if (instance == null) instance = new DALOrder();
                return instance;
            }
            set => instance = value;
        }
        public List<BILL> GetAllBill()
        {
            return CFEntities.Instance.BILLs.AsNoTracking().OrderByDescending(bill => bill.BillDate).ToList();
        }
        public BILL GetBillById(int id)
        {
            return CFEntities.Instance.BILLs.Find(id);
        }
        public BILL GetBillByMa(string BillID)
        {
            var res = CFEntities.Instance.BILLs.AsNoTracking().Where(m => m.BillID == BillID);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<BILL> GetAllInvoicesForYourShift(int userID, DateTime dateLogin)
        {
            var invoices = CFEntities.Instance.BILLs.AsNoTracking()
                .Where(bill => bill.UserID == userID && bill.BillDate >= dateLogin)
                .ToList();
            return invoices;
        }
        public List<BILL> SearchOrder(string searchText)
        {
            var transformedSearchText = DALConstraint.Instance.TransformString(searchText);
            List<BILL> listOrders = CFEntities.Instance.BILLs.ToList();
            List<BILL> filteredList = new List<BILL>();
            filteredList = listOrders
                .Where(p =>
                    (string.IsNullOrEmpty(transformedSearchText) || p.C_USER.UserFullName.ToLower().Contains(transformedSearchText)) ||
                    (string.IsNullOrEmpty(transformedSearchText) || p.BillID.ToLower().Contains(transformedSearchText))
                )
                .OrderByDescending(bill => bill.BillDate)
                .ToList();
            return filteredList;
        }

        public int AddBill(DateTime BillDate, int UserID, int? TableID, string Note, double total, float tax, double subTotal)
        {
            try
            {
                var obj = new BILL();
                obj.BillDate = BillDate;
                obj.UserID = UserID;
                obj.Total = total;
                obj.TableID = TableID;
                obj.Status = "Paid";
                obj.Note = Note;
                obj.Tax = tax;
                obj.SubTotal = subTotal;
                CFEntities.Instance.BILLs.Add(obj);
                CFEntities.Instance.SaveChanges();
                return obj.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }
        public bool DelBill(int idBill)
        {
            using (var transaction = CFEntities.Instance.Database.BeginTransaction())
            {
                try
                {
                    BILL bill = GetBillById(idBill);
                    if (bill == null) return false;
                    CFEntities.Instance.BILLs.Remove(bill);
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
        public bool UpdBill(int id, double? SubTotal, string Status, int? TableID)
        {
            try
            {
                BILL Bill = CFEntities.Instance.BILLs.Find(id);
                if (Bill == null) return false;
                if (SubTotal != null)
                {
                    Bill.SubTotal = SubTotal.Value;
                    Bill.Total = Bill.SubTotal * (100 + Bill.Tax)/100;
                }
                if (TableID != null) Bill.TableID = TableID;
                if (Status != Bill.Status) Bill.Status = Status;
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
