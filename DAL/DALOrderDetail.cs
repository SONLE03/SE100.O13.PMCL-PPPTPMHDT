using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DAL
{
    public class DALOrderDetail
    {
        private static DALOrderDetail instance;
        public static DALOrderDetail Instance
        {
            get
            {
                if (instance == null) instance = new DALOrderDetail();
                return instance;
            }
            set => instance = value;
        }
        public List<BILL_DETAIL> GetAllBillDetail()
        {
            return CFEntities.Instance.BILL_DETAIL.AsNoTracking().ToList();
        }
        public BILL_DETAIL GetBillDetail(int idBill, int idDrink)
        {
            return CFEntities.Instance.BILL_DETAIL.Find(new object[] { idBill, idDrink });
        }

        public bool updateQuantity(int idBill, int idDrink)
        {
            try
            {
                var BillDetail = (from p in CFEntities.Instance.BILL_DETAIL.AsNoTracking().ToList() where p.BillID == idBill && p.DrinksID == idDrink select p).FirstOrDefault();
                if (BillDetail == null) return false;
                BillDetail.Quantity++;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool AddBillDetail(int idBill, int DrinksID, int sizeID, int Quantity, float Rate)
        {
            try
            {
                var bill = DALOrder.Instance.GetBillById(idBill);
                if (bill == null) return false;
                var dt = new BILL_DETAIL
                {
                    BillID = idBill,
                    BILL = bill,
                    DrinksID = DrinksID,
                    SizeID = sizeID,
                    Quantity = Quantity,
                    Rate = Rate,
                    Amount = Quantity * Rate
                };
                CFEntities.Instance.BILL_DETAIL.Add(dt);
                //DALOrder.Instance.UpdBill(idBill, bill.Total + dt.Amount, null, null);
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
