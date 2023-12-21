﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SupplierDetails : Form
    {
        private int supplierId;
        public SupplierDetails(int id)
        {
            InitializeComponent();
            supplierId = id;
            Binding(supplierId);
            
        }
        private void Binding(int id)
        {
            SUPPLIER supplier = BUSSupplier.Instance.GetSupplierById(id);
            lbAddress.Text = supplier.Address;
            lbSupplierID.Text = supplier.SupplierID;
            lbSupName.Text = supplier.SupplierName;
            lbPhone.Text = supplier.Phone;
            lbStatus.Text = supplier.Status;
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewImport.Rows.Clear();
            foreach (var import in supplier.IMPORT_BILL)
            {
                gridviewImport.Rows.Add(import.id, import.ImportID, import.ImportName, import.ImportDate, import.IMPORT_BILL_DETAIL.Count, import.Total, edit_img);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridviewImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
