namespace LMS
{
    partial class student
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
            this.textBoxrowid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxmobile = new System.Windows.Forms.TextBox();
            this.textBoxcourse = new System.Windows.Forms.TextBox();
            this.textBoxdepart = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxkid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxyear = new System.Windows.Forms.ComboBox();
            this.searchkey = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxrowid);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(442, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Information";
            // 
            // textBoxrowid
            // 
            this.textBoxrowid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrowid.Location = new System.Drawing.Point(57, 36);
            this.textBoxrowid.Name = "textBoxrowid";
            this.textBoxrowid.Size = new System.Drawing.Size(278, 36);
            this.textBoxrowid.TabIndex = 34;
            this.textBoxrowid.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.graduated;
            this.pictureBox1.Location = new System.Drawing.Point(364, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxmobile
            // 
            this.textBoxmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmobile.Location = new System.Drawing.Point(972, 243);
            this.textBoxmobile.Name = "textBoxmobile";
            this.textBoxmobile.Size = new System.Drawing.Size(278, 36);
            this.textBoxmobile.TabIndex = 26;
            this.textBoxmobile.TextChanged += new System.EventHandler(this.textBoxmobile_TextChanged);
            // 
            // textBoxcourse
            // 
            this.textBoxcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcourse.Location = new System.Drawing.Point(972, 169);
            this.textBoxcourse.Name = "textBoxcourse";
            this.textBoxcourse.Size = new System.Drawing.Size(278, 36);
            this.textBoxcourse.TabIndex = 24;
            this.textBoxcourse.TextChanged += new System.EventHandler(this.textBoxcourse_TextChanged);
            // 
            // textBoxdepart
            // 
            this.textBoxdepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdepart.Location = new System.Drawing.Point(359, 169);
            this.textBoxdepart.Name = "textBoxdepart";
            this.textBoxdepart.Size = new System.Drawing.Size(278, 36);
            this.textBoxdepart.TabIndex = 23;
            this.textBoxdepart.TextChanged += new System.EventHandler(this.textBoxdepart_TextChanged);
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(972, 102);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(278, 36);
            this.textBoxname.TabIndex = 22;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBoxname_TextChanged);
            // 
            // textBoxkid
            // 
            this.textBoxkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxkid.Location = new System.Drawing.Point(357, 102);
            this.textBoxkid.Name = "textBoxkid";
            this.textBoxkid.Size = new System.Drawing.Size(280, 36);
            this.textBoxkid.TabIndex = 21;
            this.textBoxkid.TextChanged += new System.EventHandler(this.textBoxkid_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(789, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 40);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mobile";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = "Year";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(789, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 40);
            this.label12.TabIndex = 18;
            this.label12.Text = "Course";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(121, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 40);
            this.label11.TabIndex = 17;
            this.label11.Text = "Department";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(789, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 40);
            this.label10.TabIndex = 16;
            this.label10.Text = "Name";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 40);
            this.label9.TabIndex = 15;
            this.label9.Text = "K Id";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Red;
            this.homebtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homebtn.Location = new System.Drawing.Point(1061, 309);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(188, 51);
            this.homebtn.TabIndex = 30;
            this.homebtn.Text = "Back to Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.deletebtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebtn.Location = new System.Drawing.Point(581, 309);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(188, 51);
            this.deletebtn.TabIndex = 29;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editbtn.Location = new System.Drawing.Point(357, 309);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(188, 51);
            this.editbtn.TabIndex = 28;
            this.editbtn.Text = "Update";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addbtn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(121, 309);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(194, 51);
            this.addbtn.TabIndex = 27;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 403);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(819, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 51);
            this.button1.TabIndex = 32;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxyear
            // 
            this.comboBoxyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxyear.FormattingEnabled = true;
            this.comboBoxyear.Items.AddRange(new object[] {
            "Select Year",
            "1st ",
            "2nd",
            "3rd",
            "4th",
            "5th"});
            this.comboBoxyear.Location = new System.Drawing.Point(357, 243);
            this.comboBoxyear.Name = "comboBoxyear";
            this.comboBoxyear.Size = new System.Drawing.Size(280, 37);
            this.comboBoxyear.TabIndex = 35;
            this.comboBoxyear.SelectedIndexChanged += new System.EventHandler(this.comboBoxyear_SelectedIndexChanged);
            // 
            // searchkey
            // 
            this.searchkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchkey.Location = new System.Drawing.Point(489, 388);
            this.searchkey.Name = "searchkey";
            this.searchkey.Size = new System.Drawing.Size(255, 36);
            this.searchkey.TabIndex = 36;
            // 
            // buttonsearch
            // 
            this.buttonsearch.BackColor = System.Drawing.Color.Green;
            this.buttonsearch.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsearch.Location = new System.Drawing.Point(796, 376);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(141, 56);
            this.buttonsearch.TabIndex = 37;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Image = global::LMS.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(809, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(952, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 56);
            this.button2.TabIndex = 39;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.searchkey);
            this.Controls.Add(this.comboBoxyear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.textBoxmobile);
            this.Controls.Add(this.textBoxcourse);
            this.Controls.Add(this.textBoxdepart);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxkid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "=";
            this.Load += new System.EventHandler(this.student_Load);
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
        private System.Windows.Forms.TextBox textBoxmobile;
        private System.Windows.Forms.TextBox textBoxcourse;
        private System.Windows.Forms.TextBox textBoxdepart;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxkid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxrowid;
        private System.Windows.Forms.ComboBox comboBoxyear;
        private System.Windows.Forms.TextBox searchkey;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}