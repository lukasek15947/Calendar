using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlDays2 : UserControl
    {
        public UserControlDays2()
        {
            InitializeComponent();
        }

        private void UserControlDays2_Load(object sender, EventArgs e)
        {
            
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }
    }
}
