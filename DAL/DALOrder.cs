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
            return CFEntities.Instance.BILLs.AsNoTracking().ToList();
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
        public List<BILL> FindPhieuNhap(DateTime BillDate, int? Status, int? UserID, int? TableID)
        {
            var res = CFEntities.Instance.BILLs.ToList();
            if (Status != null) res = res.Where(t => t.Status == Status).Select(t => t).ToList();
            if (UserID != null) res = res.Where(t => t.UserID == UserID).Select(t => t).ToList();
            if (TableID != null) res = res.Where(t => t.TableID == TableID).Select(t => t).ToList();
            if (BillDate != null) res = res.Where(t => t.BillDate == BillDate).Select(t => t).ToList();
            return res;
        }
        public bool AddBill(DateTime BillDate, int Status, int UserID, int? TableID, string Note)
        {
            try
            {
                var obj = new BILL();
                obj.BillDate = BillDate;
                obj.UserID = UserID;
                obj.Total = 0;
                obj.TableID = TableID;
                obj.Status = Status;
                obj.Note = Note;
                CFEntities.Instance.BILLs.Add(obj);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
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
        public bool UpdBill(int id, double? Total, int? Status, int? TableID)
        {
            try
            {
                BILL Bill = CFEntities.Instance.BILLs.Find(id);
                if (Bill == null) return false;
                if (Total != null) Bill.Total = Total.Value;
                if (TableID != null) Bill.TableID = TableID;
                if (Status != Bill.Status) Bill.Status = (int)Status;
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
