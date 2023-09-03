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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void gridview()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root; database=lms_db;password=";
                //Display query
                string Query = "select * from issuebook;";
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

        private void returngridview()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root; database=lms_db;password=";
                //Display query
                string Query = "select * from returnbook;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new home().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Load(object sender, EventArgs e)
        {
            gridview();
            returngridview();
            dateTimereturn.Value = DateTime.Now;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxreturnno.Clear();
            textBoxname.Clear();
            textBoxdepart.Clear();
            textBoxmobile.Clear();
            textBoxpenalty.Clear();
            textBoxbook.Clear();
            textBoxkid.Clear();
            dateTimeissue.ResetText();
            dateTimereturn.ResetText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView1.CurrentRow.Selected = true;
                textBoxrowid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxissueno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxkid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxdepart.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxmobile.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxbook.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                dateTimeissue.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                penalty();
            }
        }

        private void penalty()
        {
            DateTime date1 = dateTimeissue.Value.Date;
            DateTime date2 = dateTimereturn.Value.Date;
           
            int datediff= ((TimeSpan)(date2 - date1)).Days;
            double fineday = datediff - 7;
            if(datediff > 7)
            {
                double fine = fineday * 5;
                textBoxpenalty.Text = fine.ToString();
            }
            else
            {
                double defaultvalue = 0;
                textBoxpenalty.Text = defaultvalue.ToString();


            }
           
               
      
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxreturnno.Text != "" && textBoxkid.Text != "" && textBoxname.Text != "" && textBoxdepart.Text != "" && textBoxmobile.Text != "" && textBoxbook.Text != "" && dateTimereturn.Text != "" && textBoxpenalty.Text != "" && dateTimeissue.Text != "")
            {

                try
                {
                    
                    string Myconnection = "server=localhost;username=root;" +
                                                "password=;database=lms_db";
                    string Query1 = "Select * from returnbook where Issue_no='" + this.textBoxissueno.Text + "' || Return_no='" + this.textBoxreturnno.Text + "' ;";
                    MySqlConnection MyConn1 = new MySqlConnection(Myconnection);
                    MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                    MySqlDataReader MyReader1;
                    MyConn1.Open();
                    MyReader1 = MyCommand1.ExecuteReader();
                    if (MyReader1.Read())
                    {
                        MessageBox.Show("Enter Retrun No or Issue No Already Exist");
                    }
                    else
                    {

                        
                        string Query = "insert into returnbook (Issue_no,Return_No,Kid,Name,Department,Mobile,Book_name,Issue_date,Return_date,Penalty) values" +
                            "('" + this.textBoxissueno.Text + "','" + this.textBoxreturnno.Text + "','" + this.textBoxkid.Text + "','" + this.textBoxname.Text + "','" + this.textBoxdepart.Text + "','" + this.textBoxmobile.Text + "','" + this.textBoxbook.Text + "','" + this.dateTimeissue.Text + "','" + this.dateTimereturn.Text + "','" + this.textBoxpenalty.Text + "');";

                        MySqlConnection MyConn = new MySqlConnection(Myconnection);
                        MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                        MySqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        MessageBox.Show("Data Add Successfully");

                        MyConn.Close();
                        gridview();
                        Updatebook();
                        returngridview();

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

        private void button2_Click(object sender, EventArgs e)
        {
            penalty();
        }

        private void searchview()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root; database=lms_db;password=";
                //Display query
                string Query = "select * from issuebook where Name Like '%" + searchkey.Text + "%' || Kid Like '%" + searchkey.Text + "%';";
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
        private void Updatebook()
        {
            try
            {
                int Qty, newQty;
                string Myconnection = "server=localhost;username=root;" +
                                                "password=;database=lms_db";
                string Query1 = "Select * from book where Name='" + textBoxbook.Text + "'";
                MySqlConnection MyConn1 = new MySqlConnection(Myconnection);
                MyConn1.Open();

                MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand1;
                DataTable dt = new DataTable();
                MyAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Qty = Convert.ToInt32(dr["Quantity"].ToString());
                    newQty = Qty + 1;
                    String Query2 = "update book set Quantity=" + newQty + " where Name='" + textBoxbook.Text + "';";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query2, MyConn1);
                    MyCommand2.ExecuteReader();
                }
                MyConn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            searchview();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxrowid.Clear();
            textBoxreturnno.Clear();
            textBoxissueno.Clear();
            textBoxkid.Clear();
            textBoxname.Clear();
            textBoxdepart.Clear();
            textBoxmobile.Clear();
            textBoxbook.Clear();
            dateTimeissue.ResetText();
            dateTimereturn.ResetText();
            searchkey.Clear();
        }
    }
}
