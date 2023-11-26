using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSSupplier
    {
        private static BUSSupplier instance;

        public static BUSSupplier Instance
        {
            get
            {
                if (instance == null) instance = new BUSSupplier();
                return instance;
            }
            set { instance = value; }
        }
        public List<SUPPLIER> GetAllSupplier()
        {
            return DALSupplier.Instance.GetAllSupplier();
        }
        public SUPPLIER GetSupplierById(int id)
        {
            return DALSupplier.Instance.GetSupplierById(id);
        }
        public SUPPLIER GetSupplierByMa(string SupplierID)
        {
            return DALSupplier.Instance.GetSupplierByMa(SupplierID);
        }
        public bool AddNhaCungCap(string SupplierName, string Address, string Phone)
        {
            return DALSupplier.Instance.AddNhaCungCap(SupplierName, Address, Phone);
        }
        public bool UpdNhaCungCap(int SupplierID, string SupplierName, string Address, string Phone)
        {
            return DALSupplier.Instance.UpdNhaCungCap(SupplierID, SupplierName, Address, Phone);
        }
        public bool DelNhaCungCap(int SupplierID)
        {
            return DALSupplier.Instance.DelNhaCungCap(SupplierID);
        }
    }
}
