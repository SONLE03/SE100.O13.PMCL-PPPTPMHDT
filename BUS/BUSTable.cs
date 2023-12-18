using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<C_TABLE> GetAllTableActive()
        {
            return DALTable.Instance.GetAllTableActive();
        }
        public C_TABLE GetTableById(int id)
        {
            return DALTable.Instance.GetTableById(id);
        }
        public C_TABLE GetTableByCode(string idTable)
        {
            return DALTable.Instance.GetTableByCode(idTable);
        }
        public bool AddTable(string tableName, AREA area)
        {
            return DALTable.Instance.AddTable(tableName, area);
        }
        public bool UpdTable(int tableID, string tableName, AREA area, string status)
        {
            return DALTable.Instance.UpdTable(tableID, tableName, area, status);
        }
    }
}
