﻿using DAL;
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
        public bool AddSupplier(string SupplierName, string Address, string Phone)
        {
            return DALSupplier.Instance.AddSupplier(SupplierName, Address, Phone);
        }
        public bool UpdSupplier(int SupplierID, string SupplierName, string Address, string Phone, string status)
        {
            return DALSupplier.Instance.UpdSupplier(SupplierID, SupplierName, Address, Phone, status);
        }
        public bool DelNhaCungCap(int SupplierID)
        {
            return DALSupplier.Instance.DelNhaCungCap(SupplierID);
        }
    }
}
