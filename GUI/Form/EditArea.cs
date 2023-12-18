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
    public partial class EditArea : Form
    {
        private AREA area;
        public EditArea(int id)
        {
            InitializeComponent();
            area = BUSArea.Instance.GetAreaById(id);
            LoadData(area);
        }
        private void LoadData(AREA area)
        {
            lbAreaID.Text = area.AreaID;
            txtAreaname.Text = area.AreaName;
            
        }
    }
}
