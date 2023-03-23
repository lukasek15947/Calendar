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
        private int month;
        private int year;

        public static int static_month, static_year;

        public Form1()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;
            month = currentDate.Month;
            year = currentDate.Year;
            DisplayMonth(month, year);
        }

        private void DisplayMonth(int month, int year)
        {
            dayContainer.Controls.Clear();
            static_month = month;
            static_year = year;
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

        private void buttonPredchozi_Click(object sender, EventArgs e)
        {
            // Zobrazí předchozí měsíc
            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
            static_month = month;
            static_year = year;
            DisplayMonth(month, year);
        }

        private void buttonDalsi_Click(object sender, EventArgs e)
        {
            // Zobrazí následující měsíc
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
            static_month = month;
            static_year = year;
            DisplayMonth(month, year);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Zobrazí měsíc zadaný v textovém poli
            try
            {
                int year2 = int.Parse(textBox1.Text);

                year = year2;
                DisplayMonth(month, year);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid year format. Please enter a valid year.");
            }
        }
    }
}