namespace LMS
{
    partial class books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxbookqty = new System.Windows.Forms.TextBox();
            this.textBoxbookprice = new System.Windows.Forms.TextBox();
            this.textBoxbookpublis = new System.Windows.Forms.TextBox();
            this.textBoxbookauthor = new System.Windows.Forms.TextBox();
            this.textBoxbookname = new System.Windows.Forms.TextBox();
            this.textBoxbookno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewbook = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxrowid = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.searchkey = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.textBoxrowid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 90);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(543, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.book__3_;
            this.pictureBox1.Location = new System.Drawing.Point(454, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxbookqty
            // 
            this.textBoxbookqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbookqty.Location = new System.Drawing.Point(988, 247);
            this.textBoxbookqty.Name = "textBoxbookqty";
            this.textBoxbookqty.Size = new System.Drawing.Size(306, 36);
            this.textBoxbookqty.TabIndex = 26;
            this.textBoxbookqty.TextChanged += new System.EventHandler(this.textBoxbookqty_TextChanged);
            // 
            // textBoxbookprice
            // 
            this.textBoxbookprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbookprice.Location = new System.Drawing.Point(271, 246);
            this.textBoxbookprice.Name = "textBoxbookprice";
            this.textBoxbookprice.Size = new System.Drawing.Size(307, 36);
            this.textBoxbookprice.TabIndex = 25;
            this.textBoxbookprice.TextChanged += new System.EventHandler(this.textBoxbookprice_TextChanged);
            // 
            // textBoxbookpublis
            // 
            this.textBoxbookpublis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbookpublis.Location = new System.Drawing.Point(988, 175);
            this.textBoxbookpublis.Name = "textBoxbookpublis";
            this.textBoxbookpublis.Size = new System.Drawing.Size(307, 36);
            this.textBoxbookpublis.TabIndex = 24;
            this.textBoxbookpublis.TextChanged += new System.EventHandler(this.textBoxbookpublis_TextChanged);
            // 
            // textBoxbookauthor
            // 
            this.textBoxbookauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbookauthor.Location = new System.Drawing.Point(271, 171);
            this.textBoxbookauthor.Name = "textBoxbookauthor";
            this.textBoxbookauthor.Size = new System.Drawing.Size(307, 36);
            this.textBoxbookauthor.TabIndex = 23;
            this.textBoxbookauthor.TextChanged += new System.EventHandler(this.textBoxbookauthor_TextChanged);
            // 
            // textBoxbookname
            // 
            this.textBoxbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbookname.Location = new System.Drawing.Point(989, 108);
            this.textBoxbookname.Name = "textBoxbookname";
            this.textBoxbookname.Size = new System.Drawing.Size(306, 36);
            this.textBoxbookname.TabIndex = 22;
            this.textBoxbookname.TextChanged += new System.EventHandler(this.textBoxbookname_TextChanged);
            // 
            // textBoxbookno
            // 
            this.textBoxbookno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbookno.Location = new System.Drawing.Point(271, 107);
            this.textBoxbookno.Name = "textBoxbookno";
            this.textBoxbookno.Size = new System.Drawing.Size(307, 36);
            this.textBoxbookno.TabIndex = 21;
            this.textBoxbookno.TextChanged += new System.EventHandler(this.textBoxbookno_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(779, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 40);
            this.label8.TabIndex = 20;
            this.label8.Text = "Quantity";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(779, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 40);
            this.label6.TabIndex = 18;
            this.label6.Text = "Publisher";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 40);
            this.label5.TabIndex = 17;
            this.label5.Text = "Author";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(779, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 40);
            this.label4.TabIndex = 16;
            this.label4.Text = "Book Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Book No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1078, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 51);
            this.button4.TabIndex = 31;
            this.button4.Text = "Back to Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(588, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 51);
            this.button3.TabIndex = 30;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(338, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 51);
            this.button2.TabIndex = 29;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(96, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 51);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewbook
            // 
            this.dataGridViewbook.AllowUserToAddRows = false;
            this.dataGridViewbook.AllowUserToDeleteRows = false;
            this.dataGridViewbook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewbook.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbook.Location = new System.Drawing.Point(12, 441);
            this.dataGridViewbook.Name = "dataGridViewbook";
            this.dataGridViewbook.ReadOnly = true;
            this.dataGridViewbook.RowHeadersWidth = 51;
            this.dataGridViewbook.RowTemplate.Height = 24;
            this.dataGridViewbook.Size = new System.Drawing.Size(1358, 400);
            this.dataGridViewbook.TabIndex = 32;
            this.dataGridViewbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewbook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(829, 320);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 51);
            this.button5.TabIndex = 33;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxrowid
            // 
            this.textBoxrowid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrowid.Location = new System.Drawing.Point(96, 33);
            this.textBoxrowid.Name = "textBoxrowid";
            this.textBoxrowid.Size = new System.Drawing.Size(307, 36);
            this.textBoxrowid.TabIndex = 34;
            this.textBoxrowid.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(879, 379);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 56);
            this.button6.TabIndex = 42;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.BackColor = System.Drawing.Color.Green;
            this.buttonsearch.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsearch.Location = new System.Drawing.Point(723, 379);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(141, 56);
            this.buttonsearch.TabIndex = 41;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // searchkey
            // 
            this.searchkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchkey.Location = new System.Drawing.Point(416, 391);
            this.searchkey.Name = "searchkey";
            this.searchkey.Size = new System.Drawing.Size(255, 36);
            this.searchkey.TabIndex = 40;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Image = global::LMS.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(744, 392);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1383, 853);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.searchkey);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridViewbook);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxbookqty);
            this.Controls.Add(this.textBoxbookprice);
            this.Controls.Add(this.textBoxbookpublis);
            this.Controls.Add(this.textBoxbookauthor);
            this.Controls.Add(this.textBoxbookname);
            this.Controls.Add(this.textBoxbookno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "books";
            this.Load += new System.EventHandler(this.books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxbookqty;
        private System.Windows.Forms.TextBox textBoxbookprice;
        private System.Windows.Forms.TextBox textBoxbookpublis;
        private System.Windows.Forms.TextBox textBoxbookauthor;
        private System.Windows.Forms.TextBox textBoxbookname;
        private System.Windows.Forms.TextBox textBoxbookno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewbook;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxrowid;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.TextBox searchkey;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}