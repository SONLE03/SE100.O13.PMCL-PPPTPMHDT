using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class TableDetails : Form
    {
        private C_TABLE table;

        public TableDetails(int id)
        {
            InitializeComponent();
            table = BUSTable.Instance.GetTableById(id);
            lbTableID.Text = table.TableID;
            lbTableName.Text = table.TableName;
            lbArea.Text = table.AREA.AreaName;
            lbStatus.Text = table.Status;
        }

        private void bthCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
