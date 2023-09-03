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
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewbook.CurrentRow.Selected = true;
            textBoxrowid.Text = dataGridViewbook.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxbookno.Text = dataGridViewbook.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxbookname.Text = dataGridViewbook.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxbookauthor.Text = dataGridViewbook.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxbookpublis.Text = dataGridViewbook.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxbookprice.Text = dataGridViewbook.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxbookqty.Text = dataGridViewbook.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new home().Show();
        }

        private void books_Load(object sender, EventArgs e)
        {
            gridview();
        }

        private void searchview()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root; database=lms_db;password=";
                //Display query
                string Query = "select * from book where Name Like '%" + searchkey.Text + "%';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridViewbook.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxbookno.Text != "" && textBoxbookname.Text != "" && textBoxbookauthor.Text != "" && textBoxbookpublis.Text != "" && textBoxbookprice.Text != "" && textBoxbookqty.Text != "")
            {
                try
                {

                    
                    string Myconnection = "server=localhost;username=root;" +
                                                "password=;database=lms_db";
                    string Query1 = "Select * from book where Book_No='" + this.textBoxbookno.Text + "';";
                    MySqlConnection MyConn1 = new MySqlConnection(Myconnection);
                    MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                    MySqlDataReader MyReader1;
                    MyConn1.Open();
                    MyReader1 = MyCommand1.ExecuteReader();
                    if (MyReader1.Read())
                    {
                        MessageBox.Show("Enter Book No. Already Exist");
                    }
                    else
                    {
                        string Query = "insert into book(Book_No,Name,Author,Publisher,Price,Quantity) values" +
                            "('" + this.textBoxbookno.Text + "','" + this.textBoxbookname.Text + "','" + this.textBoxbookauthor.Text + "','" + this.textBoxbookpublis.Text + "','" + this.textBoxbookprice.Text + "','" + this.textBoxbookqty.Text + "');";
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
                MessageBox.Show("Missing Information");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxbookqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void gridview()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root; database=lms_db;password=";
                //Display query
                string Query = "select * from book;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridViewbook.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxrowid.Clear();
            textBoxbookno.Clear();
            textBoxbookname.Clear();
            textBoxbookauthor.Clear();
            textBoxbookpublis.Clear();
            textBoxbookprice.Clear();
            textBoxbookqty.Clear();
            searchkey.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxbookno.Text != "" && textBoxbookname.Text != "" && textBoxbookauthor.Text != "" && textBoxbookpublis.Text != "" && textBoxbookprice.Text != "" && textBoxbookqty.Text != "")
            {
                try
                {
                    string Myconnection = "server=localhost;username=root;" +
                                             "password=;database=lms_db";
                    string Query = "update book set Book_No='" + this.textBoxbookno.Text + "',Name='" + this.textBoxbookname.Text + "',Author='" + this.textBoxbookauthor.Text + "',Publisher='" + this.textBoxbookpublis.Text + "',Price='" + this.textBoxbookprice.Text + "',Quantity='" + this.textBoxbookqty.Text + "' where id='" + this.textBoxrowid.Text + "';";
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxbookno.Text != "" && textBoxbookname.Text != "" && textBoxbookauthor.Text != "" && textBoxbookpublis.Text != "" && textBoxbookprice.Text != "" && textBoxbookqty.Text != "")
            {
                try
                {
                    string Myconnection = "server=localhost;username=root;" +
                                             "password=;database=lms_db";
                    string Query = "delete from book where id='" + this.textBoxrowid.Text + "';";
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
            }
            else
            {
                MessageBox.Show("Please Select Row");
            }
        }

        private void textBoxbookno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxbookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxbookauthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxbookpublis_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxbookprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            gridview();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            searchview();
        }
    }
}
