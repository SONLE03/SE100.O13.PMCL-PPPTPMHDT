using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public List<SUPPLIER> GetAllSupplierActive()
        {
            return DALSupplier.Instance.GetAllSupplierActive();
        }
        public SUPPLIER GetSupplierById(int id)
        {
            return DALSupplier.Instance.GetSupplierById(id);
        }
        public SUPPLIER GetSupplierByMa(string SupplierID)
        {
            return DALSupplier.Instance.GetSupplierByMa(SupplierID);
        }
        public bool AddSupplier(string SupplierName, string Address, string Phone, string Status)
        {
            if (!BUSConstraint.Instance.PhoneNumberValidator(Phone))
            {
                MessageBox.Show("Invalid phone number", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(!DALSupplier.Instance.AddSupplier(SupplierName, Address, Phone, Status))
            {
                MessageBox.Show("Add Failure Supplier", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Add Supplier Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public bool UpdSupplier(int SupplierID, string SupplierName, string Address, string Phone, string Status)
        {
            if (!BUSConstraint.Instance.PhoneNumberValidator(Phone))
            {
                MessageBox.Show("Invalid phone number", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!DALSupplier.Instance.UpdSupplier(SupplierID, SupplierName, Address, Phone, Status))
            {
                MessageBox.Show("Modify Failure Supplier", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Modify Supplier Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public bool DelNhaCungCap(int SupplierID)
        {
            return DALSupplier.Instance.DelNhaCungCap(SupplierID);
        }
        public List<SUPPLIER> SearchSupplier(string searchText, string selectedStatus)
        {
            return DALSupplier.Instance.SearchSupplier(searchText, selectedStatus);
        }
    }
}
