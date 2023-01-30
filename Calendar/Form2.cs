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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        int month, year;

        public static int static_month, static_year;

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < dayoftheweek; ++i)
            {
                UserControlBlank2 userControlBlank = new UserControlBlank2();
                dayOblast.Controls.Add(userControlBlank);
            }
            for (int i = 1; i <= days; ++i)
            {
                UserControlDays2 ucdays = new UserControlDays2();
                ucdays.days(i);
                dayOblast.Controls.Add(ucdays);
            }
        }
    }
}
