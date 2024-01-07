using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSupplier
    {
        private static DALSupplier instance;
        public static DALSupplier Instance
        {
            get
            {
                if (instance == null) instance = new DALSupplier();
                return instance;
            }
            set => instance = value;
        }
        public List<SUPPLIER> GetAllSupplier()
        {
            return CFEntities.Instance.SUPPLIERs.AsNoTracking().OrderByDescending(supplier => supplier.id).ToList();
        }
        public List<SUPPLIER> GetAllSupplierActive()
        {
            return CFEntities.Instance.SUPPLIERs.AsNoTracking().Where(m => m.Status == "Active").ToList();
        }
        public SUPPLIER GetSupplierById(int id)
        {
            return CFEntities.Instance.SUPPLIERs.Find(id);
        }
        public SUPPLIER GetSupplierByMa(string SupplierID)
        {
            var res = CFEntities.Instance.SUPPLIERs.AsNoTracking().Where(m => m.SupplierID == SupplierID);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<SUPPLIER> SearchSupplier(string searchText, string selectedStatus)
        {
            var transformedNameSupplier = DALConstraint.Instance.TransformString(searchText);
            List<SUPPLIER> listSupplier = CFEntities.Instance.SUPPLIERs.ToList();
            List<SUPPLIER> filteredList = new List<SUPPLIER>();
            filteredList = listSupplier
                .Where(p =>
                    (string.IsNullOrEmpty(transformedNameSupplier) || p.SupplierName.ToLower().Contains(transformedNameSupplier.ToLower())) &&
                    (selectedStatus == "All" || string.Equals(p.Status, selectedStatus, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();
            return filteredList;
        }

        public bool AddSupplier(string SupplierName, string Address, string Phone, string Status)
        {
            try
            {
                var obj = new SUPPLIER();
                obj.SupplierName = DALConstraint.Instance.TransformString(SupplierName);
                obj.Address = DALConstraint.Instance.TransformString(Address);
                obj.Phone = Phone;
                obj.Status = Status;
                CFEntities.Instance.SUPPLIERs.Add(obj);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool UpdSupplier(int SupplierID, string SupplierName, string Address, string Phone, string Status)
        {
            try
            {
                SUPPLIER obj = GetSupplierById(SupplierID);
                if (obj == null) return false;
                if (SupplierName != null) obj.SupplierName = DALConstraint.Instance.TransformString(SupplierName); 
                if (Address != null) obj.Address = DALConstraint.Instance.TransformString(Address);
                if (Phone != null) obj.Phone = Phone;
                if (Status != obj.Status) obj.Status = Status;
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
