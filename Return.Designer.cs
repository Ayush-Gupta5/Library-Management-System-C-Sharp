namespace LMS
{
    partial class Return
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimereturn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeissue = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxmobile = new System.Windows.Forms.TextBox();
            this.textBoxdepart = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxreturnno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxpenalty = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxissueno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxkid = new System.Windows.Forms.TextBox();
            this.textBoxbook = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.searchkey = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1409, 92);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxrowid
            // 
            this.textBoxrowid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrowid.Location = new System.Drawing.Point(3, 53);
            this.textBoxrowid.Name = "textBoxrowid";
            this.textBoxrowid.Size = new System.Drawing.Size(242, 36);
            this.textBoxrowid.TabIndex = 60;
            this.textBoxrowid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(451, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Return Entry";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources._return;
            this.pictureBox1.Location = new System.Drawing.Point(357, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(825, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 36);
            this.label12.TabIndex = 52;
            this.label12.Text = "Books Returned";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(825, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 36);
            this.label11.TabIndex = 51;
            this.label11.Text = "Books Issued";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(480, 532);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(914, 318);
            this.dataGridView2.TabIndex = 50;
            // 
            // dateTimereturn
            // 
            this.dateTimereturn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimereturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimereturn.Location = new System.Drawing.Point(185, 611);
            this.dateTimereturn.Name = "dateTimereturn";
            this.dateTimereturn.Size = new System.Drawing.Size(269, 36);
            this.dateTimereturn.TabIndex = 49;
            this.dateTimereturn.Value = new System.DateTime(2023, 4, 16, 0, 0, 0, 0);
            this.dateTimereturn.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 604);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 40);
            this.label10.TabIndex = 48;
            this.label10.Text = "Return";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dateTimeissue
            // 
            this.dateTimeissue.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeissue.Location = new System.Drawing.Point(185, 552);
            this.dateTimeissue.Name = "dateTimeissue";
            this.dateTimeissue.Size = new System.Drawing.Size(269, 36);
            this.dateTimeissue.TabIndex = 47;
            this.dateTimeissue.Value = new System.DateTime(2023, 3, 18, 10, 22, 13, 0);
            this.dateTimeissue.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 40);
            this.label9.TabIndex = 46;
            this.label9.Text = "Issue";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(480, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 303);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(335, 796);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 49);
            this.button4.TabIndex = 42;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 739);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(442, 51);
            this.button1.TabIndex = 41;
            this.button1.Text = "Return Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxmobile
            // 
            this.textBoxmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmobile.Location = new System.Drawing.Point(185, 440);
            this.textBoxmobile.Name = "textBoxmobile";
            this.textBoxmobile.ReadOnly = true;
            this.textBoxmobile.Size = new System.Drawing.Size(269, 36);
            this.textBoxmobile.TabIndex = 40;
            this.textBoxmobile.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxdepart
            // 
            this.textBoxdepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdepart.Location = new System.Drawing.Point(185, 384);
            this.textBoxdepart.Name = "textBoxdepart";
            this.textBoxdepart.ReadOnly = true;
            this.textBoxdepart.Size = new System.Drawing.Size(269, 36);
            this.textBoxdepart.TabIndex = 39;
            this.textBoxdepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxdepart.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(185, 323);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.ReadOnly = true;
            this.textBoxname.Size = new System.Drawing.Size(269, 36);
            this.textBoxname.TabIndex = 38;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxreturnno
            // 
            this.textBoxreturnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxreturnno.Location = new System.Drawing.Point(185, 137);
            this.textBoxreturnno.Name = "textBoxreturnno";
            this.textBoxreturnno.Size = new System.Drawing.Size(269, 36);
            this.textBoxreturnno.TabIndex = 37;
            this.textBoxreturnno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 40);
            this.label8.TabIndex = 36;
            this.label8.Text = "Book";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 40);
            this.label7.TabIndex = 35;
            this.label7.Text = "Mobile";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 36);
            this.label6.TabIndex = 34;
            this.label6.Text = "Department";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 40);
            this.label5.TabIndex = 33;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 40);
            this.label4.TabIndex = 32;
            this.label4.Text = "K Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 40);
            this.label3.TabIndex = 31;
            this.label3.Text = "Return No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 664);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 40);
            this.label2.TabIndex = 55;
            this.label2.Text = "Penalty";
            // 
            // textBoxpenalty
            // 
            this.textBoxpenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpenalty.Location = new System.Drawing.Point(185, 668);
            this.textBoxpenalty.Name = "textBoxpenalty";
            this.textBoxpenalty.Size = new System.Drawing.Size(269, 36);
            this.textBoxpenalty.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(14, 796);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 49);
            this.button2.TabIndex = 60;
            this.button2.Text = "Penalty";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxissueno
            // 
            this.textBoxissueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxissueno.Location = new System.Drawing.Point(185, 202);
            this.textBoxissueno.Name = "textBoxissueno";
            this.textBoxissueno.ReadOnly = true;
            this.textBoxissueno.Size = new System.Drawing.Size(269, 36);
            this.textBoxissueno.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 40);
            this.label13.TabIndex = 61;
            this.label13.Text = "Issue No.";
            // 
            // textBoxkid
            // 
            this.textBoxkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxkid.Location = new System.Drawing.Point(185, 264);
            this.textBoxkid.Name = "textBoxkid";
            this.textBoxkid.ReadOnly = true;
            this.textBoxkid.Size = new System.Drawing.Size(269, 36);
            this.textBoxkid.TabIndex = 63;
            // 
            // textBoxbook
            // 
            this.textBoxbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbook.Location = new System.Drawing.Point(185, 495);
            this.textBoxbook.Name = "textBoxbook";
            this.textBoxbook.ReadOnly = true;
            this.textBoxbook.Size = new System.Drawing.Size(269, 36);
            this.textBoxbook.TabIndex = 64;
            this.textBoxbook.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Image = global::LMS.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(1122, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(1257, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 56);
            this.button6.TabIndex = 67;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.BackColor = System.Drawing.Color.Green;
            this.buttonsearch.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsearch.Location = new System.Drawing.Point(1101, 96);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(141, 56);
            this.buttonsearch.TabIndex = 66;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // searchkey
            // 
            this.searchkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchkey.Location = new System.Drawing.Point(794, 108);
            this.searchkey.Name = "searchkey";
            this.searchkey.Size = new System.Drawing.Size(255, 36);
            this.searchkey.TabIndex = 65;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(176, 796);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 49);
            this.button3.TabIndex = 69;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1406, 853);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.searchkey);
            this.Controls.Add(this.textBoxbook);
            this.Controls.Add(this.textBoxkid);
            this.Controls.Add(this.textBoxissueno);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxpenalty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimereturn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimeissue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxmobile);
            this.Controls.Add(this.textBoxdepart);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxreturnno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimereturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimeissue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxmobile;
        private System.Windows.Forms.TextBox textBoxdepart;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxreturnno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxpenalty;
        private System.Windows.Forms.TextBox textBoxrowid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxissueno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxkid;
        private System.Windows.Forms.TextBox textBoxbook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.TextBox searchkey;
        private System.Windows.Forms.Button button3;
    }
}