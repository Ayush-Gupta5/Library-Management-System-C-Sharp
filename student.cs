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
    public partial class student : Form
    {
       
        public student()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new home().Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {
            gridview();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxkid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxdepart_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxsems_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (textBoxkid.Text != "" && textBoxname.Text != "" && textBoxdepart.Text != "" && textBoxcourse.Text != "" && comboBoxyear.Text != "" && textBoxmobile.Text != "")
            {
               
                try
                {
                    string Myconnection = "server=localhost;username=root;" +
                                                "password=;database=lms_db";
                    string Query1 = "Select * from student where kid='" + this.textBoxkid.Text + "';";
                    MySqlConnection MyConn1 = new MySqlConnection(Myconnection);
                    MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                    MySqlDataReader MyReader1;
                    MyConn1.Open();
                    MyReader1 = MyCommand1.ExecuteReader();
                    if (MyReader1.Read())
                    {
                        MessageBox.Show("Enter Kid Already Exist");
                    }
                    else
                    {
                        string Query = "insert into student (Kid,Name,Department,Course,Year,Mobile) values" +
                            "('" + this.textBoxkid.Text + "','" + this.textBoxname.Text + "','" + this.textBoxdepart.Text + "','" + this.textBoxcourse.Text + "','" + this.comboBoxyear.Text + "','" + this.textBoxmobile.Text + "');";
                        MySqlConnection MyConn = new MySqlConnection(Myconnection);
                        MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                        MySqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        MessageBox.Show("Data Add Successfully");
                        while (MyReader.Read())
                        {
                        }
                        gridview();
                        MyConn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Missing information");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBoxrowid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxkid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxdepart.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxcourse.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxyear.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxmobile.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void gridview()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root; database=lms_db;password=";
                //Display query
                string Query = "select * from student;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchview()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root; database=lms_db;password=";
                //Display query
                string Query = "select * from student where Name Like '%"+searchkey.Text+ "%' || Kid Like '%" + searchkey.Text + "%' ;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxrowid.Clear();
            textBoxkid.Clear();
            textBoxname.Clear();
            textBoxdepart.Clear();
            textBoxcourse.Clear();
            comboBoxyear.ResetText();
            textBoxmobile.Clear();
            searchkey.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (textBoxkid.Text != "" && textBoxname.Text != "" && textBoxdepart.Text != "" && textBoxcourse.Text != "" && comboBoxyear.Text != "" && textBoxmobile.Text != "")
            {
                try
                {
                    string Myconnection = "server=localhost;username=root;" +
                                             "password=;database=lms_db";
                    string Query = "delete from student where id='" + this.textBoxrowid.Text + "';";
                    MySqlConnection MyConn = new MySqlConnection(Myconnection);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    MessageBox.Show("Data Delete Successfully");
                    while (MyReader.Read())
                    {
                    }
                    gridview();
                    MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                MessageBox.Show("Please Select Row");
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (textBoxkid.Text != "" && textBoxname.Text != "" && textBoxdepart.Text != "" && textBoxcourse.Text != "" && comboBoxyear.Text != "" && textBoxmobile.Text != "")
            {
                try
                {
                    string Myconnection = "server=localhost;username=root;" +
                                             "password=;database=lms_db";
                    string Query = "update student set kid='" + this.textBoxkid.Text + "',name='" + this.textBoxname.Text + "',department='" + this.textBoxdepart.Text + "',course='" + this.textBoxcourse.Text + "',semester='" + this.comboBoxyear.Text + "',mobile='" + this.textBoxmobile.Text + "' where id='" + this.textBoxrowid.Text + "';";
                    MySqlConnection MyConn = new MySqlConnection(Myconnection);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    MessageBox.Show("Data Update Successfully");
                    while (MyReader.Read())
                    {
                    }
                    gridview();
                    MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select Row");
            }
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBoxyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            searchview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridview();
        }
    }
}
