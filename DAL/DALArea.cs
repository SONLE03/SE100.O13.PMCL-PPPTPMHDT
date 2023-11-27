﻿using DTO;
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
        public AREA GetAreaById(int id)
        {
            return CFEntities.Instance.AREAs.Find(id);
        }
        public AREA GetAreaByCode(string AreaId)
        {
            var res = CFEntities.Instance.AREAs.AsNoTracking().Where(m => m.AreaID == AreaId);
            if (res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<AREA> FindArea(string name, double extraFee)
        {
            var res = CFEntities.Instance.AREAs.ToList();
            if (name != null) res = res.Where(t => t.AreaName == name).Select(t => t).ToList();
            if (extraFee != 0) res = res.Where(e => e.ExtraFee == extraFee).Select(e => e).ToList();
            return res;
        }
        public bool AddArea(string AreaName, double ExtraFee)
        {
            try
            {
                var obj = new AREA();
                obj.AreaName = AreaName;
                obj.ExtraFee = ExtraFee;
                obj.Status = "active";
                CFEntities.Instance.AREAs.Add(obj);
                CFEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool UpdArea(int idArea, string AreaName, double ExtraFee, string Status)
        {
            try
            {
                AREA area = GetAreaById(idArea);
                if (area == null) return false;
                if (AreaName != null) area.AreaName = AreaName;
                if (ExtraFee != 0) area.ExtraFee = ExtraFee;
                if (Status != null)
                {
                    area.Status = Status;
                    bool checkTableStatus = area.C_TABLE.Any(table => table.Status == "Customer");
                    if(!checkTableStatus)
                    {
                        foreach(var table in area.C_TABLE)
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
        public bool DelArea(int idArea)
        {
            using (var transaction = CFEntities.Instance.Database.BeginTransaction())
            {
                try
                {
                    AREA area = GetAreaById(idArea);
                    if (area == null) return false;
                    CFEntities.Instance.AREAs.Remove(area);
                    CFEntities.Instance.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}