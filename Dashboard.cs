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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        MySqlConnection MyConn1 = new MySqlConnection("server=localhost;username=root;" +
                                                "password=;database=lms_db");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try 
            {
                MyConn1.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("Select count(*) from student", MyConn1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                studentlab.Text = dt.Rows[0][0].ToString();
                MySqlDataAdapter da1 = new MySqlDataAdapter("Select count(*) from book", MyConn1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                booklab.Text = dt1.Rows[0][0].ToString();
                MySqlDataAdapter da2 = new MySqlDataAdapter("Select count(*) from issuebook", MyConn1);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                issuelab.Text = dt2.Rows[0][0].ToString();
                MySqlDataAdapter da3 = new MySqlDataAdapter("Select count(*) from returnbook", MyConn1);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                returnlab.Text = dt3.Rows[0][0].ToString();
                MyConn1.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            new home().Show();
        }
    }
}
