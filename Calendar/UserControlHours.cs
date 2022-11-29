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
    public partial class UserControlHours : UserControl
    {
        public UserControlHours()
        {
            InitializeComponent();
        }

        private void UserControlHours_Load(object sender, EventArgs e)
        {

        }
        public static string static_hours;
        public void hours(int numhours)
        {
            lbhours.Text = numhours + "";
        }

        private void UserControlHours_Click(object sender, EventArgs e)
        {
            static_hours = lbhours.Text;
            EventForm eventform = new EventForm();
            eventform.Show();
        }
    }
}
