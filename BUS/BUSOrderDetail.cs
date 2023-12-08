using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSOrderDetail
    {
        private static BUSOrderDetail instance;

        public static BUSOrderDetail Instance
        {
            get
            {
                if (instance == null) instance = new BUSOrderDetail();
                return instance;
            }
            set { instance = value; }
        }
        public List<BILL_DETAIL> GetAllBillDetail()
        {
            return DALOrderDetail.Instance.GetAllBillDetail();
        }
        public BILL_DETAIL GetBillDetail(int idBill, int idDrink)
        {
            return DALOrderDetail.Instance.GetBillDetail(idBill, idDrink);
        }

        public bool AddBillDetail(int idBill, int DrinksID, string Unit, int Quantity, float Rate)
        {
            return DALOrderDetail.Instance.AddBillDetail(idBill, DrinksID, Unit, Quantity, Rate);
        }
    }
}
