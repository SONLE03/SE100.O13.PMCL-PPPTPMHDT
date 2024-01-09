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
    public partial class UCWelcome : UserControl
    {
        public UCWelcome()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UCWelcome_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        
    }
}
