using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
            new password().Show();
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new student().Show();
        }

        private void booksbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new books().Show();
        }

        private void issuebookbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new issuebook().Show();
        }

        private void returnbookbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Return().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            login l1 = new login();
            l1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Dashboard().Show();
        }
    }
}
