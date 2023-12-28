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
    public partial class UCChangeRegulations : UserControl
    {
        public UCChangeRegulations()
        {
            InitializeComponent();
            Bind();
        }
        private void Bind()
        {
            C_RULE rule = BUSRule.Instance.GetAllRule();
            numericMaxAge.Value = (int)rule.MaximumAge;
            numericMinAge.Value = (int)rule.MinimumAge; 
            numericTax.Value = (int)rule.Tax;
            numericMaxDateForEvent.Value = (int)rule.MaximumDateForEvent;
            numericMaxPercentDiscount.Value = (int)rule.MaximumPercentDiscount;
        }
        private void numericMinAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void numericMaxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void numericTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnChangeRegulations_Click(object sender, EventArgs e)
        {
            BUSRule.Instance.UpdRule((int)numericMinAge.Value, (int)numericMaxAge.Value, (int)numericTax.Value, (int)numericMaxDateForEvent.Value, (int)numericMaxPercentDiscount.Value);
            Bind();
        }

        private void numericMaxPercentDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void numericMaxDateForEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
