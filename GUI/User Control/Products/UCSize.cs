using BUS;
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
    public partial class UCSize : UserControl
    {
        public UCSize()
        {
            InitializeComponent();
            Binding(BUSSize.Instance.GetAllSize());
        }

        private void Binding(List<C_SIZE> sizeList)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            gridviewSize.Rows.Clear();
            foreach(var size in sizeList)
            {
                gridviewSize.Rows.Add(size.id, size.SizeID, size.SizeName, edit_img);
            }
        }

        private void btnAddSize_Click(object sender, EventArgs e)
        {
            AddSize addSize = new AddSize();
            addSize.ShowDialog();
            Binding(BUSSize.Instance.GetAllSize());
        }

        private void gridviewSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            int sizeID = Convert.ToInt32(gridviewSize.Rows[idx].Cells["ID"].Value);
            EditSize editSize = new EditSize(sizeID);
            editSize.ShowDialog();
            Binding(BUSSize.Instance.GetAllSize());
        }

        private void txtFindSize_TextChanged(object sender, EventArgs e)
        {
            List<C_SIZE> list = new List<C_SIZE>();
            foreach (var p in BUSSize.Instance.GetAllSize())
            {
                if (p.SizeName.ToLower().Contains(txtFindSize.Text.ToLower()))
                {
                    list.Add(p);
                }
            }
            Binding(list);
        }
    }
}
