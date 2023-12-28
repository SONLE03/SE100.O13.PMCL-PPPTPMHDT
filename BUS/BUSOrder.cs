using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSOrder
    {
        private static BUSOrder instance;

        public static BUSOrder Instance
        {
            get
            {
                if (instance == null) instance = new BUSOrder();
                return instance;
            }
            set { instance = value; }
        }

        public double revenue { get; set; }  

        public List<BILL> GetAllBill()
        {
            return DALOrder.Instance.GetAllBill();
        }
        public List<BILL> GetAllInvoicesForYourShift()
        {
            List<BILL> listBills = DALOrder.Instance.GetAllInvoicesForYourShift(BUSUser.Instance.idUserLogin, BUSUser.Instance.dateLogin);
            revenue = (double)listBills.Sum(bill => bill.Total);
            return listBills;
        }
        public BILL GetBillById(int id)
        {
            return DALOrder.Instance.GetBillById(id);
        }
        public BILL GetBillByMa(string BillID)
        {
            return DALOrder.Instance.GetBillByMa(BillID);
        }
        public int AddBill(DateTime BillDate, int Status, int UserID, int? TableID, string Note, double total, float tax)
        {
            return DALOrder.Instance.AddBill(BillDate, Status, UserID, TableID, Note, total, tax);
        }
        public bool DelBill(int idBill)
        {
            return DALOrder.Instance.DelBill(idBill);
        }
        public bool UpdBill(int id, double? Total, string Status, int? TableID)
        {
            return DALOrder.Instance.UpdBill(id, Total, Status, TableID);
        }
    }
}
