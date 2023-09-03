using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMS
{
    public partial class issuebook : Form
    {
        public issuebook()
        {
            InitializeComponent();
        }

        private void listkid()
        {
            try
            {
                string Myconnection = "server=localhost;username=root;" +
                                            "password=;database=lms_db";
                string Query1 = "Select * from student";

                MySqlConnection MyConn1 = new MySqlConnection(Myconnection);
                MyConn1.Open();
                MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                MySqlDataReader MyReader1;

                MyReader1 = MyCommand1.ExecuteReader();

                while (MyReader1.Read())
                {
                    comboBoxkid.Items.Add(MyReader1.GetString("Kid"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listbook()
        {
            try
            {
                string Myconnection = "server=localhost;username=root;" +
                                            "password=;database=lms_db";
                string Query1 = "Select * from book where Quantity>"+0+"";

                MySqlConnection MyConn1 = new MySqlConnection(Myconnection);
                MyConn1.Open();
                MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                MySqlDataReader MyReader1;

                MyReader1 = MyCommand1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Load(MyReader1);
                comboBoxbook.ValueMember = "Name";
                comboBoxbook.DataSource = dt;
                MyConn1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void issuebook_Load(object sender, EventArgs e)
        {
            
            listkid();
            listbook();
            gridview();
            dateTimeissue.Value = DateTime.Now;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxissueno_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxkid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new home().Show();
        }

        private void searchview()
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root; database=lms_db;password=";
                //Display query
                string Query = "select * from issuebook where Name Like '%" + searchkey.Text + "%';";
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxissueno.Text != "" && comboBoxkid.Text != "" && textBoxname.Text != "" && textBoxdepart.Text != "" && textBoxmobile.Text != "" && comboBoxbook.Text != "" && dateTimeissue.Text != "")
            {
                try
                {
                    string Myconnection = "server=localhost;username=root;" +
                                             "password=;database=lms_db";
                    string Query = "delete from issuebook where id='" + this.textBoxrowid.Text + "';";
                    MySqlConnection MyConn = new MySqlConnection(Myconnection);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    MessageBox.Show("Data Delete Successfully");
                    while (MyReader.Read())
                    {
                    }
                    
                    MyConn.Close();
                    gridview();
                    UpdatebookAftercancel();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBoxrowid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxissueno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxkid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxdepart.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxmobile.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBoxbook.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimeissue.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxissueno.Clear();
            comboBoxbook.ResetText();
            comboBoxkid.ResetText();
            textBoxname.Clear();
            textBoxdepart.Clear();
            dateTimeissue.ResetText();
            textBoxmobile.Clear();
            searchkey.Clear();

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void comboBoxkid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Myconnection = "server=localhost;username=root;" +
                                                "password=;database=lms_db";
                string Query1 = "Select * from student where Kid='" + this.comboBoxkid.Text + "';";
                MySqlConnection MyConn1 = new MySqlConnection(Myconnection);
                MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                MySqlDataReader MyReader1;
                MyConn1.Open();
                MyReader1 = MyCommand1.ExecuteReader();
                while(MyReader1.Read())
                {
                    string name = (string)MyReader1["Name"].ToString();
                    textBoxname.Text = name;

                    string department = (string)MyReader1["Department"].ToString();
                    textBoxdepart.Text = department;

                    string mobile = (string)MyReader1["Mobile"].ToString();
                    textBoxmobile.Text = mobile;
                }
                this.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void comboBoxbook_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Updatebook()
        {
            try
            {
                int Qty,newQty;
                string Myconnection = "server=localhost;username=root;" +
                                                "password=;database=lms_db";
                string Query1 = "Select * from book where Name='" + comboBoxbook.Text+ "'";
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
                    newQty = Qty - 1;
                    String Query2 = "update book set Quantity=" + newQty + " where Name='" + comboBoxbook.Text + "';";
                    MySqlCommand MyCommand2= new MySqlCommand(Query2, MyConn1);
                    MyCommand2.ExecuteReader();
                }
                MyConn1.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }
        private void UpdatebookAftercancel()
        {
            try
            {
                int Qty, newQty;
                string Myconnection = "server=localhost;username=root;" +
                                                "password=;database=lms_db";
                string Query1 = "Select * from book where Name='" + comboBoxbook.Text + "'";
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
                    String Query2 = "update book set Quantity=" + newQty + " where Name='" + comboBoxbook.Text + "';";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxissueno.Text != "" && comboBoxkid.Text != "" && textBoxname.Text != "" && textBoxdepart.Text != "" && textBoxmobile.Text != "" && comboBoxbook.Text != "" && dateTimeissue.Text != "")
            {

                try
                {
                    string Myconnection = "server=localhost;username=root;" +
                                                "password=;database=lms_db";
                    string Query1 = "Select * from issuebook where Issue_No='" + this.textBoxissueno.Text + "';";
                    MySqlConnection MyConn1 = new MySqlConnection(Myconnection);
                    MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                    MySqlDataReader MyReader1;
                    MyConn1.Open();
                    MyReader1 = MyCommand1.ExecuteReader();
                    if (MyReader1.Read())
                    {
                        MessageBox.Show("Enter Issue No Already Exist");
                    }
                    else
                    {

                       
                        string Query = "insert into issuebook (Issue_No,Kid,Name,Department,Mobile,Book_name,Date) values" +
                            "('" + this.textBoxissueno.Text + "','" + this.comboBoxkid.Text + "','" + this.textBoxname.Text + "','" + this.textBoxdepart.Text + "','" + this.textBoxmobile.Text + "','" + this.comboBoxbook.Text + "','" + this.dateTimeissue.Text + "');";
                        
                        MySqlConnection MyConn = new MySqlConnection(Myconnection);
                        MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                      
                        MySqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        MessageBox.Show("Data Add Successfully");


                        
                        MyConn.Close();
                        gridview();
                        Updatebook();
                        listbook();
                        
                        

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
            if (textBoxissueno.Text != "" && comboBoxkid.Text != "" && textBoxname.Text != "" && textBoxdepart.Text != "" && comboBoxbook.Text != "" && dateTimeissue.Text != "")
            {
                try
                {
                    string Myconnection = "server=localhost;username=root;" +
                                             "password=;database=lms_db";
                    string Query = "update issuebook set Issue_No='" + this.textBoxissueno.Text + "',Kid='" + this.comboBoxkid.Text + "',Name='" + this.textBoxname.Text + "',department='" + this.textBoxdepart.Text + "', Mobile='" + this.textBoxmobile.Text + "',Book_Name='" + this.comboBoxbook.Text + "',Date='" + this.dateTimeissue.Text + "' where id='" + this.textBoxrowid.Text + "';";
                    MySqlConnection MyConn = new MySqlConnection(Myconnection);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();
                    MessageBox.Show("Data Update Successfully");
                    while (MyReader.Read())
                    {
                    }
                    
                    MyConn.Close();
                    gridview();
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

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            searchview();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gridview();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
