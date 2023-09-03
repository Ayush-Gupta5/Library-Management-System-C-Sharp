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
namespace LMS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (textBoxusername.Text != "" && textBoxpassword.Text != "")
            {
                string MyConnection = "datasource=localhost;port=3306;username=root;password=;database=lms_db";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                string Query = "Select * from admin where username='" + textBoxusername.Text + "' && Password='" + textBoxpassword.Text + "';";
                Myconn.Open();
                MySqlCommand MyCommand = new MySqlCommand(Query, Myconn);
                MySqlDataReader MyReader;
                MyReader = MyCommand.ExecuteReader();
                if (MyReader.Read()) 
                {
                    this.Close();
                    new home().Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    textBoxusername.Clear();
                    textBoxpassword.Clear();
                    textBoxusername.Focus();
                }
            }else
            {
                MessageBox.Show("Please Fill Both Field");
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            textBoxusername.Clear();
            textBoxpassword.Clear();
            textBoxusername.Focus();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
