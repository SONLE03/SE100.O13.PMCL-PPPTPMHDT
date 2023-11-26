using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSImportBill
    {
        private static BUSImportBill instance;

        public static BUSImportBill Instance
        {
            get
            {
                if (instance == null) instance = new BUSImportBill();
                return instance;
            }
            set { instance = value; }
        }

        public List<IMPORT_BILL> GetAllImportBill()
        {
            return DALImportBill.Instance.GetAllImportBill();
        }
        public IMPORT_BILL GetImportBillById(int id)
        {
            return DALImportBill.Instance.GetImportBillById(id);
        }
        public IMPORT_BILL GetImportBillByCode(string importID)
        {
            return DALImportBill.Instance.GetImportBillByCode(importID);
        }
        public bool AddImportBill(string ImportName, DateTime ImportDate, SUPPLIER Supplier, C_USER User)
        {
            return DALImportBill.Instance.AddImportBill(ImportName, ImportDate, Supplier, User);
        }
        public bool DelImportBill(int idIB)
        {
            return DALImportBill.Instance.DelImportBill(idIB);
        }
        public bool UpdImportBill(int id, double? total)
        {
            return DALImportBill.Instance.UpdImportBill(id, total);
        }
    }
}
