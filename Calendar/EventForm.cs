using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace Calendar
{
    public partial class EventForm : Form
    {
        String connString = "server=localhost;user id=root;database=db_calendar;sslmode=none";
        public EventForm()
        {
            InitializeComponent();
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            txdate.Text = Form1.static_year+"/"+Form1.static_month + "/" + UserControlDays.static_day;
            txtime.Text = UserControlHours.static_hours + ":";
            txenddate.Text = Form1.static_year + "/" + Form1.static_month + "/" + UserControlDays.static_day + " " +"23:";
            txhost.Text = "@gmail.com";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO table_calendar(datum,cas,event,konec_udalosti)values(?,?,?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("datum", txdate.Text);
            cmd.Parameters.AddWithValue("cas", txtime.Text);
            cmd.Parameters.AddWithValue("event", txevent.Text);
            cmd.Parameters.AddWithValue("konec_udalosti", txenddate.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();
            MailMessage message = new MailMessage();
            message.From = new MailAddress("lukasek15947@gmail.com");
            message.To.Add(new MailAddress(txhost.Text));
            message.Subject = txevent.Text;
            message.Body = "Ahoj, toto je pozvánka, která se bude konat od " +txdate.Text+" " +txtime.Text + " do " +txenddate.Text;
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new NetworkCredential("lukasek15947@gmail.com", "jndw gjzb xjxs nmok");
            client.Send(message);
            MessageBox.Show("Email byl správně odeslán");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtime.Text = UserControlHours.static_hours + ":" + comboBox1.SelectedItem;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txenddate.Text = Form1.static_year + "/" + Form1.static_month + "/" + UserControlDays.static_day + " " + "23:" +comboBox2.SelectedItem;
        }
    }
}
