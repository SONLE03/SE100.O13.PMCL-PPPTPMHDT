using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSImportBillDetail
    {
        private static BUSImportBillDetail instance;

        public static BUSImportBillDetail Instance
        {
            get
            {
                if (instance == null) instance = new BUSImportBillDetail();
                return instance;
            }
            set { instance = value; }
        }

        public List<IMPORT_BILL_DETAIL> GetAllCTPhieuNhap()
        {
            return DALImportBillDetail.Instance.GetAllCTPhieuNhap();
        }
        public IMPORT_BILL_DETAIL GetCTPhieuNhap(int No, int idIB)
        {
            return DALImportBillDetail.Instance.GetCTPhieuNhap(No, idIB);
        }

        public bool AddImportBillDetail(int idIB, string Name, string Unit, int Quantity, float Rate)
        {
            return DALImportBillDetail.Instance.AddImportBillDetail(idIB, Name, Unit, Quantity, Rate);
        }
    }
}
