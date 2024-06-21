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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != string.Empty && txtpassword.Text != string.Empty && txtconfirmpassword.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    string MySQLConnectionString = "datasource = 127.0.0.1; port=3306; username=root; password=; database = testing;";
                    MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
                    MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM LoginTable WHERE username = @username", databaseConnection);
                    commandDatabase.Parameters.AddWithValue("@username", txtusername.Text);

                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        if (myReader.Read())
                        {
                            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            myReader.Close();
                            commandDatabase = new MySqlCommand("INSERT INTO LoginTable (username, password) VALUES (@username, @password)", databaseConnection);
                            commandDatabase.Parameters.AddWithValue("@username", txtusername.Text);
                            commandDatabase.Parameters.AddWithValue("@password", txtpassword.Text);
                            commandDatabase.ExecuteNonQuery();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        databaseConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            BtnRegister_Click(sender, e);
        }

        private void haveAccbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.ShowDialog();
        }

        private void textPassoword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}