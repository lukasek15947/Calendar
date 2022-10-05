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
    public partial class Form1 : Form
    {
        int month, year;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            --month;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < dayoftheweek; ++i)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }
            for (int i = 1; i <= days; ++i)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for(int i=1;i<dayoftheweek;++i)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }
            for(int i = 1; i <= days; ++i)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            ++month;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < dayoftheweek; ++i)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }
            for (int i = 1; i <= days; ++i)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }
    }
}
