using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALArea
    {
        private static DALArea instance;

        public static DALArea Instance
        {
            get
            {
                if (instance == null) instance = new DALArea();
                return instance;
            }
            set => instance = value;
        }
        public List<AREA> GetAllArea()
        {
            return CFEntities.Instance.AREAs.AsNoTracking().ToList();
        }
        public List<AREA> GetAllAreaActive()
        {
            return CFEntities.Instance.AREAs.AsNoTracking().Where(m => m.Status == "Active").ToList();
        }
        public List<AREA> GetAllAreaInActive()
        {
            return CFEntities.Instance.AREAs.AsNoTracking().Where(m => m.Status == "InActive").ToList();
        }
        public AREA GetAreaById(int id)
        {
            return CFEntities.Instance.AREAs.Find(id);
        }
        public AREA GetAreaByName(string nameArea)
        {
            var transformedNameArea = DALConstraint.Instance.TransformString(nameArea);
            var allAreas = CFEntities.Instance.AREAs.AsNoTracking().ToList();
            var res = allAreas.Where(m => DALConstraint.Instance.TransformString(m.AreaName.ToLower()) == transformedNameArea);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<AREA> SearchArea(string searchText, string selectedStatus)
        {
            var transformedNameArea = DALConstraint.Instance.TransformString(searchText);
            List<AREA> listAreas = CFEntities.Instance.AREAs.ToList();
            List<AREA> filteredList = new List<AREA>();
            filteredList = listAreas
                .Where(p =>
                    (string.IsNullOrEmpty(transformedNameArea) || p.AreaName.ToLower().Contains(transformedNameArea)) &&
                    (selectedStatus == "All" || string.Equals(p.Status, selectedStatus, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();
            return filteredList;
        }
        public bool AddArea(string AreaName, int capacity, string status)
        {
            try
            {
                var transformedNameArea = DALConstraint.Instance.TransformString(AreaName);
                var obj = new AREA();
                obj.AreaName = transformedNameArea;
                obj.Status = status;
                obj.Capacity = capacity;
                CFEntities.Instance.AREAs.Add(obj);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool UpdArea(int idArea, string AreaName, string Status, int capacity)
        {
            try
            {
                AREA area = GetAreaById(idArea);
                if (area == null) return false;
                var transformedNameArea = DALConstraint.Instance.TransformString(AreaName);
                if (AreaName != null) area.AreaName = transformedNameArea;
                if (capacity > 0) area.Capacity = capacity;
                if (Status != area.Status)
                {
                    area.Status = Status;
                    bool checkTableStatus = area.C_TABLE.Any(table => table.Status == "InUse");
                    if (!checkTableStatus)
                    {
                        foreach (var table in area.C_TABLE)
                        {
                            table.Status = Status;
                        }
                    }
                }
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
