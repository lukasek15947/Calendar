using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class FormActualDay : Form
    {
        public FormActualDay()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormActualDay_Load(object sender, EventArgs e)
        {
            displayHours();
        }

        private void displayHours()
        {
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(Form1.static_month);
            LBDATE.Text = monthname +" " + Form1.static_year;
            LBDAY.Text = UserControlDays.static_day + " den";
            for (int i = 0; i <= 24; ++i)
            {
                UserControlHours uchours = new UserControlHours();
                uchours.hours(i);
                hourscontainer.Controls.Add(uchours);
            }
        }
    }
}
