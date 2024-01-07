using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTable
    {
        private static DALTable instance;

        public static DALTable Instance
        {
            get
            {
                if (instance == null) instance = new DALTable();
                return instance;
            }
            set => instance = value;
        }
        public List<C_TABLE> GetAllTable()
        {
            return CFEntities.Instance.C_TABLE.AsNoTracking().OrderByDescending(table => table.id).ToList();
        }
        public List<C_TABLE> GetAllTableByAreaID(int areaId)
        {
            return CFEntities.Instance.C_TABLE.AsNoTracking().Where(m => m.AREA.Status != "InActive" && m.AreaID == areaId).ToList();
        }
        public List<C_TABLE> GetAllTableInActive()
        {
            return CFEntities.Instance.C_TABLE.AsNoTracking().Where(m => m.Status == "InActive").ToList();
        }
        public List<C_TABLE> GetAllTableInUse()
        {
            return CFEntities.Instance.C_TABLE.AsNoTracking().Where(m => m.Status == "InUse").ToList();
        }
        public C_TABLE GetTableById(int id)
        {
            return CFEntities.Instance.C_TABLE.Find(id);
        }
        public C_TABLE GetTableByCode(string idTable)
        {
            var res = CFEntities.Instance.C_TABLE.AsNoTracking().Where(m => m.TableID == idTable);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<C_TABLE> SearchTable(string searchText, string selectedArea, string selectedStatus)
        {
            var transformedNameArea = DALConstraint.Instance.TransformString(searchText);
            List<C_TABLE> listTables = CFEntities.Instance.C_TABLE.ToList();
            List<C_TABLE> filteredList = new List<C_TABLE>();
            filteredList = listTables
                .Where(p =>
                    (string.IsNullOrEmpty(transformedNameArea) || p.TableName.ToLower().Contains(transformedNameArea)) &&
                    (selectedArea == "All" || string.Equals(p.AREA.AreaName, selectedArea, StringComparison.OrdinalIgnoreCase)) &&
                    (selectedStatus == "All" || string.Equals(p.Status, selectedStatus, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();
            return filteredList;
        }
        public bool AddTable(string tableName, int area, string status)
        {
            try
            {
                var obj = new C_TABLE();
                obj.TableName = tableName;
                obj.AreaID = area;
                obj.Status = status;
                CFEntities.Instance.C_TABLE.Add(obj);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool UpdTable(int tableID, string status)
        {
            try
            {
                C_TABLE table = GetTableById(tableID);
                if (table == null) return false;
                if (status != table.Status) table.Status = status;
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

