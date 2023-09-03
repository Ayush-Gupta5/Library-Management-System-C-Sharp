namespace LMS
{
    partial class issuebook
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
            this.textBoxrowid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimeissue = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxdepart = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxissueno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBoxbook = new System.Windows.Forms.ComboBox();
            this.comboBoxkid = new System.Windows.Forms.ComboBox();
            this.textBoxmobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.searchkey = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.textBoxrowid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 94);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxrowid
            // 
            this.textBoxrowid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrowid.Location = new System.Drawing.Point(1082, 58);
            this.textBoxrowid.Name = "textBoxrowid";
            this.textBoxrowid.Size = new System.Drawing.Size(297, 36);
            this.textBoxrowid.TabIndex = 46;
            this.textBoxrowid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(475, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Issue Entry";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.reading;
            this.pictureBox1.Location = new System.Drawing.Point(369, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimeissue
            // 
            this.dateTimeissue.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeissue.Location = new System.Drawing.Point(284, 353);
            this.dateTimeissue.Name = "dateTimeissue";
            this.dateTimeissue.Size = new System.Drawing.Size(296, 36);
            this.dateTimeissue.TabIndex = 42;
            this.dateTimeissue.Value = new System.DateTime(2023, 4, 16, 0, 0, 0, 0);
            this.dateTimeissue.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 40);
            this.label9.TabIndex = 41;
            this.label9.Text = "Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 533);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 308);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1041, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 51);
            this.button4.TabIndex = 37;
            this.button4.Text = "Back to Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(575, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 49);
            this.button3.TabIndex = 36;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(343, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 49);
            this.button2.TabIndex = 35;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(96, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 51);
            this.button1.TabIndex = 34;
            this.button1.Text = "Issue Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxdepart
            // 
            this.textBoxdepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdepart.Location = new System.Drawing.Point(944, 200);
            this.textBoxdepart.Name = "textBoxdepart";
            this.textBoxdepart.ReadOnly = true;
            this.textBoxdepart.Size = new System.Drawing.Size(296, 36);
            this.textBoxdepart.TabIndex = 32;
            this.textBoxdepart.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(283, 191);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.ReadOnly = true;
            this.textBoxname.Size = new System.Drawing.Size(296, 36);
            this.textBoxname.TabIndex = 31;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxissueno
            // 
            this.textBoxissueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxissueno.Location = new System.Drawing.Point(283, 116);
            this.textBoxissueno.Name = "textBoxissueno";
            this.textBoxissueno.Size = new System.Drawing.Size(297, 36);
            this.textBoxissueno.TabIndex = 30;
            this.textBoxissueno.TextChanged += new System.EventHandler(this.textBoxissueno_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(710, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 40);
            this.label8.TabIndex = 29;
            this.label8.Text = "Book";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(710, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 40);
            this.label6.TabIndex = 27;
            this.label6.Text = "Department";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 40);
            this.label5.TabIndex = 26;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(709, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 40);
            this.label4.TabIndex = 25;
            this.label4.Text = "K Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 40);
            this.label3.TabIndex = 24;
            this.label3.Text = "Issue No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(810, 403);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 49);
            this.button5.TabIndex = 43;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBoxbook
            // 
            this.comboBoxbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxbook.FormattingEnabled = true;
            this.comboBoxbook.Location = new System.Drawing.Point(941, 277);
            this.comboBoxbook.Name = "comboBoxbook";
            this.comboBoxbook.Size = new System.Drawing.Size(296, 37);
            this.comboBoxbook.TabIndex = 44;
            this.comboBoxbook.SelectedIndexChanged += new System.EventHandler(this.comboBoxbook_SelectedIndexChanged);
            // 
            // comboBoxkid
            // 
            this.comboBoxkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxkid.FormattingEnabled = true;
            this.comboBoxkid.Location = new System.Drawing.Point(944, 123);
            this.comboBoxkid.Name = "comboBoxkid";
            this.comboBoxkid.Size = new System.Drawing.Size(296, 37);
            this.comboBoxkid.TabIndex = 45;
            this.comboBoxkid.SelectedIndexChanged += new System.EventHandler(this.comboBoxkid_SelectedIndexChanged);
            // 
            // textBoxmobile
            // 
            this.textBoxmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmobile.Location = new System.Drawing.Point(283, 273);
            this.textBoxmobile.Name = "textBoxmobile";
            this.textBoxmobile.ReadOnly = true;
            this.textBoxmobile.Size = new System.Drawing.Size(297, 36);
            this.textBoxmobile.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 40);
            this.label2.TabIndex = 46;
            this.label2.Text = "Mobile No.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Image = global::LMS.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(705, 484);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(840, 471);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 56);
            this.button6.TabIndex = 50;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.BackColor = System.Drawing.Color.Green;
            this.buttonsearch.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsearch.Location = new System.Drawing.Point(684, 471);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(141, 56);
            this.buttonsearch.TabIndex = 49;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // searchkey
            // 
            this.searchkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchkey.Location = new System.Drawing.Point(377, 483);
            this.searchkey.Name = "searchkey";
            this.searchkey.Size = new System.Drawing.Size(255, 36);
            this.searchkey.TabIndex = 48;
            // 
            // issuebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.searchkey);
            this.Controls.Add(this.textBoxmobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxkid);
            this.Controls.Add(this.comboBoxbook);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimeissue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxdepart);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxissueno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "issuebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "issuebook";
            this.Load += new System.EventHandler(this.issuebook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimeissue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxdepart;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxissueno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBoxbook;
        private System.Windows.Forms.ComboBox comboBoxkid;
        private System.Windows.Forms.TextBox textBoxrowid;
        private System.Windows.Forms.TextBox textBoxmobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.TextBox searchkey;
    }
}