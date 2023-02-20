namespace Praktika
{
    partial class Destytojas
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
            this.button1 = new System.Windows.Forms.Button();
            this.Gstudentai = new System.Windows.Forms.DataGridView();
            this.combogrupe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pgrupe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.teg = new System.Windows.Forms.TextBox();
            this.tsd = new System.Windows.Forms.TextBox();
            this.tkd = new System.Windows.Forms.TextBox();
            this.leg = new System.Windows.Forms.Label();
            this.lsd = new System.Windows.Forms.Label();
            this.lkd = new System.Windows.Forms.Label();
            this.lstudentas = new System.Windows.Forms.Label();
            this.lvardas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gstudentai)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Gstudentai);
            this.panel1.Location = new System.Drawing.Point(334, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 230);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(358, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pasirinkti studentą";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gstudentai
            // 
            this.Gstudentai.BackgroundColor = System.Drawing.Color.Black;
            this.Gstudentai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gstudentai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Gstudentai.Location = new System.Drawing.Point(0, 0);
            this.Gstudentai.Name = "Gstudentai";
            this.Gstudentai.RowHeadersWidth = 51;
            this.Gstudentai.RowTemplate.Height = 24;
            this.Gstudentai.Size = new System.Drawing.Size(352, 227);
            this.Gstudentai.TabIndex = 0;
            this.Gstudentai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gstudentai_CellContentClick);
            this.Gstudentai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gstudentai_CellContentClick);
            // 
            // combogrupe
            // 
            this.combogrupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogrupe.FormattingEnabled = true;
            this.combogrupe.Location = new System.Drawing.Point(29, 100);
            this.combogrupe.Name = "combogrupe";
            this.combogrupe.Size = new System.Drawing.Size(299, 24);
            this.combogrupe.TabIndex = 3;
            this.combogrupe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pasirinkite grupę";
            // 
            // Pgrupe
            // 
            this.Pgrupe.BackColor = System.Drawing.Color.OrangeRed;
            this.Pgrupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pgrupe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pgrupe.Location = new System.Drawing.Point(104, 144);
            this.Pgrupe.Name = "Pgrupe";
            this.Pgrupe.Size = new System.Drawing.Size(151, 42);
            this.Pgrupe.TabIndex = 5;
            this.Pgrupe.Text = "Pasirinkti";
            this.Pgrupe.UseVisualStyleBackColor = false;
            this.Pgrupe.Click += new System.EventHandler(this.Pgrupe_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.teg);
            this.panel2.Controls.Add(this.tsd);
            this.panel2.Controls.Add(this.tkd);
            this.panel2.Controls.Add(this.leg);
            this.panel2.Controls.Add(this.lsd);
            this.panel2.Controls.Add(this.lkd);
            this.panel2.Controls.Add(this.lstudentas);
            this.panel2.Controls.Add(this.lvardas);
            this.panel2.Location = new System.Drawing.Point(364, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 117);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(356, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 80);
            this.button2.TabIndex = 8;
            this.button2.Text = "Pakeisti pažymius";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teg
            // 
            this.teg.BackColor = System.Drawing.Color.DimGray;
            this.teg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teg.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teg.Location = new System.Drawing.Point(296, 58);
            this.teg.Multiline = true;
            this.teg.Name = "teg";
            this.teg.Size = new System.Drawing.Size(54, 40);
            this.teg.TabIndex = 7;
            this.teg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tsd
            // 
            this.tsd.BackColor = System.Drawing.Color.DimGray;
            this.tsd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsd.Location = new System.Drawing.Point(245, 58);
            this.tsd.Multiline = true;
            this.tsd.Name = "tsd";
            this.tsd.Size = new System.Drawing.Size(54, 40);
            this.tsd.TabIndex = 6;
            this.tsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tkd
            // 
            this.tkd.BackColor = System.Drawing.Color.DimGray;
            this.tkd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tkd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tkd.Location = new System.Drawing.Point(196, 58);
            this.tkd.Multiline = true;
            this.tkd.Name = "tkd";
            this.tkd.Size = new System.Drawing.Size(54, 40);
            this.tkd.TabIndex = 5;
            this.tkd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leg
            // 
            this.leg.BackColor = System.Drawing.Color.DimGray;
            this.leg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leg.Location = new System.Drawing.Point(296, 18);
            this.leg.Name = "leg";
            this.leg.Size = new System.Drawing.Size(54, 40);
            this.leg.TabIndex = 4;
            this.leg.Text = "EG";
            this.leg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsd
            // 
            this.lsd.BackColor = System.Drawing.Color.DimGray;
            this.lsd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsd.Location = new System.Drawing.Point(245, 18);
            this.lsd.Name = "lsd";
            this.lsd.Size = new System.Drawing.Size(54, 40);
            this.lsd.TabIndex = 3;
            this.lsd.Text = "SD";
            this.lsd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lkd
            // 
            this.lkd.BackColor = System.Drawing.Color.DimGray;
            this.lkd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lkd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkd.Location = new System.Drawing.Point(196, 18);
            this.lkd.Name = "lkd";
            this.lkd.Size = new System.Drawing.Size(54, 40);
            this.lkd.TabIndex = 2;
            this.lkd.Text = "KD";
            this.lkd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstudentas
            // 
            this.lstudentas.BackColor = System.Drawing.Color.DimGray;
            this.lstudentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstudentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstudentas.Location = new System.Drawing.Point(5, 18);
            this.lstudentas.Name = "lstudentas";
            this.lstudentas.Size = new System.Drawing.Size(190, 40);
            this.lstudentas.TabIndex = 1;
            this.lstudentas.Text = "Studentas";
            // 
            // lvardas
            // 
            this.lvardas.BackColor = System.Drawing.Color.DimGray;
            this.lvardas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvardas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvardas.Location = new System.Drawing.Point(5, 58);
            this.lvardas.Name = "lvardas";
            this.lvardas.Size = new System.Drawing.Size(190, 40);
            this.lvardas.TabIndex = 0;
            this.lvardas.Text = "Studentas vardas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImageLocation = "D:\\Programavimas\\Sharpas\\Praktika\\Praktika\\nuotrauka\\x-mark-16.png";
            this.pictureBox1.Location = new System.Drawing.Point(826, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(29, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 58);
            this.button3.TabIndex = 8;
            this.button3.Text = "Atsijungti";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Destytojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(873, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pgrupe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combogrupe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Destytojas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destytojas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gstudentai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combogrupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pgrupe;
        private System.Windows.Forms.DataGridView Gstudentai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label leg;
        private System.Windows.Forms.Label lsd;
        private System.Windows.Forms.Label lkd;
        private System.Windows.Forms.Label lstudentas;
        private System.Windows.Forms.Label lvardas;
        private System.Windows.Forms.TextBox teg;
        private System.Windows.Forms.TextBox tsd;
        private System.Windows.Forms.TextBox tkd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}