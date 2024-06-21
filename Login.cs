using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace registration_and_login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var register = new Registration();
            register.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                string MySQLConnectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=testing;";
                using (MySqlConnection cn = new MySqlConnection(MySQLConnectionString))
                {
                    cn.Open();

                    string query = "SELECT * FROM LoginTable WHERE username=@username AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                dr.Close();
                                this.Hide();
                                Home home = new Home();
                                home.ShowDialog();
                            }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("No Account available with this username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1loginbtn_Click(object sender, EventArgs e)
        {
            BtnLogin_Click(sender, e);
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
