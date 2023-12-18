﻿using DTO;
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
            return CFEntities.Instance.C_TABLE.AsNoTracking().ToList();
        }
        public List<C_TABLE> GetAllTableActive()
        {
            return CFEntities.Instance.C_TABLE.AsNoTracking().Where(m => m.Status == DALStatus.active.ToString()).ToList();
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
        public List<C_TABLE> FindTable(string name)
        {
            var res = CFEntities.Instance.C_TABLE.ToList();
            if (name != null) res = res.Where(t => t.TableName == name).Select(t => t).ToList();
            return res;
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
        public bool UpdTable(int tableID, string tableName, int area, string status)
        {
            try
            {
                C_TABLE table = GetTableById(tableID);
                if (table == null) return false;
                if (tableName != null) table.TableName = tableName;
                if (area != table.AreaID) table.AreaID = area;
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

