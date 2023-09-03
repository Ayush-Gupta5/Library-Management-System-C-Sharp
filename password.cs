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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxoldpass.Clear();
            textBoxnewpass.Clear();
        }

        private void textBoxoldpass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3306;username=root;password=;database=lms_db";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                string Query = "Select * from admin where Password='" + textBoxoldpass.Text + "'";
                Myconn.Open();
                MySqlCommand MyCommand = new MySqlCommand(Query, Myconn);
                MySqlDataAdapter da = new MySqlDataAdapter(MyCommand);
                da.SelectCommand = MyCommand;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string Query1 = "update admin set Password='" + this.textBoxnewpass.Text + "'";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query1, Myconn);
                    MySqlDataReader MyReader;
                    MyReader = MyCommand2.ExecuteReader();
                    MessageBox.Show("Password Updated");

                }
                else
                {
                    MessageBox.Show("You have Entered wrong password");
                }
                textBoxoldpass.Clear();
                textBoxnewpass.Clear();
                textBoxoldpass.Focus();
                Myconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            new home().Show();
        }
    }
}
