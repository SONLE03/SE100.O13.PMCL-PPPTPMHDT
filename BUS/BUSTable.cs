using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace BUS
{
    public class BUSTable
    {
        private static BUSTable instance;

        public static BUSTable Instance
        {
            get
            {
                if (instance == null) instance = new BUSTable();
                return instance;
            }
            set { instance = value; }
        }

        public List<C_TABLE> GetAllTable()
        {
            return DALTable.Instance.GetAllTable();
        }
        public List<C_TABLE> GetAllTableByAreaID(int areaId)
        {
            return DALTable.Instance.GetAllTableByAreaID(areaId);
        }
        public List<C_TABLE> GetAllTableInActive()
        {
            return DALTable.Instance.GetAllTableInActive();
        }
        public List<C_TABLE> GetAllTableInUse()
        {
            return DALTable.Instance.GetAllTableInUse();
        }
        public C_TABLE GetTableById(int id)
        {
            return DALTable.Instance.GetTableById(id);
        }
        public C_TABLE GetTableByCode(string idTable)
        {
            return DALTable.Instance.GetTableByCode(idTable);
        }
        public bool AddTable(string tableName, int areaid, string status)
        { 
            return DALTable.Instance.AddTable(tableName, areaid, status);
        }
        public bool UpdTable(int tableID, string status)
        {
            return DALTable.Instance.UpdTable(tableID, status);
        }
        public bool checkAreaStatus(int areaid, string status)
        {
            AREA area = DALArea.Instance.GetAreaById(areaid);
            if (area.Status.ToLower().Equals("inactive") && status.Equals("Active")) return false;
            return true;
        }
        public int checkAreaCapacity(int areaid, int capacity)
        {
            AREA area = DALArea.Instance.GetAreaById(areaid);
            int numberOfEmptyTable = area.Capacity - area.C_TABLE.Count;
            if (numberOfEmptyTable == 0)
            {
                return 0;
            }
            if (numberOfEmptyTable >= capacity)
            {
                return capacity;
            }
            return numberOfEmptyTable;
        }
        public List<C_TABLE> Search(string searchText, string selectedArea, string selectedStatus)
        {
           return DALTable.Instance.SearchTable(searchText, selectedArea, selectedStatus);
        }
    }
}
