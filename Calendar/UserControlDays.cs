using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        String connString = "server=localhost;user id=root;database=db_calendar;sslmode=none";
        public MySqlConnection conn;
        public UserControlDays()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
                
        }
        public void days(int numday)
        {
            lbdays.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            FormActualDay form = new FormActualDay();
            form.Show();
        }

        private void displayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM table_calendar where datum = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("datum", Form1.static_year + "-" + Form1.static_month + "-" + lbdays.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbevent.Text = reader["event"].ToString();
            }
        }

        /*private void posliUdalost()
        {
            String sql = "SELECT * FROM table_calendar where datum = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("datum", Form1.static_year + "-" + Form1.static_month + "-" + lbdays.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int pocet = int.Parse(reader["pocet"].ToString());
                DateTime datum = DateTime.Parse(reader["datum"].ToString());
                if ((datum - DateTime.Now).TotalDays < pocet)
                {
                    if (!IsValidEmail(host))
                    {
                        MessageBox.Show("Zadal jsi špatný email");
                    }
                    else
                    {
                        MailMessage message = new MailMessage();
                        message.From = new MailAddress("lukasek15947@gmail.com");
                        message.To.Add(new MailAddress(host));
                        message.Subject = udalost;
                        message.Body = "Ahoj, připomínám, že se koná ta událost";
                        SmtpClient client = new SmtpClient();
                        client.EnableSsl = true;
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.Credentials = new NetworkCredential("lukasek15947@gmail.com", "jndw gjzb xjxs nmok");
                        client.Send(message);
                        MessageBox.Show("Email byl správně odeslán");
                    }
                }
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
            //posliUdalost();
        }

        private void lbevent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chcete smazat tuto událost?", "Potvrzení", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();
                    string query = "DELETE FROM table_calendar WHERE event = ?";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("event", lbevent.Text);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Událost byla úspěšně smazána z kalendáře.");
                            lbevent.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Událost nebyla nalezena v kalendáři.");
                        }
                    }
                    connection.Close();
                }
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();
                    string query = "SELECT * FROM table_calendar where event = ?";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("event", lbevent.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime datum = DateTime.Parse(reader["datum"].ToString());
                                string cas = reader["cas"].ToString();
                                string udalost = reader["event"].ToString();
                                DateTime konecudalosti = DateTime.Parse(reader["konec_udalosti"].ToString());
                                string host = reader["host"].ToString();
                                string s = "Datum události: " + datum.ToString("dd/MM/yyyy")
                                         + "\nČas události: " + cas
                                         + "\nPopis události: " + udalost
                                         + "\nKonec události: " + konecudalosti
                                         + "\nHost: " + host;
                                MessageBox.Show(s);
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
