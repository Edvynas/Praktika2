namespace Praktika
{
    partial class Studentas
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
            System.Windows.Forms.ColumnHeader Paskaitos;
            this.Sarasas = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.perziureti = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leg1 = new System.Windows.Forms.Label();
            this.lsd1 = new System.Windows.Forms.Label();
            this.lkd1 = new System.Windows.Forms.Label();
            this.leg2 = new System.Windows.Forms.Label();
            this.lsd2 = new System.Windows.Forms.Label();
            this.lkd2 = new System.Windows.Forms.Label();
            this.lpavadinimas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            Paskaitos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Paskaitos
            // 
            Paskaitos.Text = "Paskaitų sąrašas:";
            Paskaitos.Width = 300;
            // 
            // Sarasas
            // 
            this.Sarasas.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.Sarasas.BackColor = System.Drawing.Color.White;
            this.Sarasas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Paskaitos});
            this.Sarasas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Sarasas.GridLines = true;
            this.Sarasas.HideSelection = false;
            this.Sarasas.Location = new System.Drawing.Point(23, 79);
            this.Sarasas.Name = "Sarasas";
            this.Sarasas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sarasas.Size = new System.Drawing.Size(286, 359);
            this.Sarasas.TabIndex = 1;
            this.Sarasas.UseCompatibleStateImageBehavior = false;
            this.Sarasas.View = System.Windows.Forms.View.Details;
            this.Sarasas.SelectedIndexChanged += new System.EventHandler(this.Sarasas_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.perziureti);
            this.panel1.Controls.Add(this.Sarasas);
            this.panel1.Location = new System.Drawing.Point(1, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 467);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(534, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Atsijungti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // perziureti
            // 
            this.perziureti.BackColor = System.Drawing.Color.OrangeRed;
            this.perziureti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perziureti.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perziureti.Location = new System.Drawing.Point(346, 97);
            this.perziureti.Name = "perziureti";
            this.perziureti.Size = new System.Drawing.Size(158, 75);
            this.perziureti.TabIndex = 3;
            this.perziureti.Text = "Peržiūrėti pažymius";
            this.perziureti.UseVisualStyleBackColor = false;
            this.perziureti.Click += new System.EventHandler(this.pazymiai_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.leg1);
            this.panel2.Controls.Add(this.lsd1);
            this.panel2.Controls.Add(this.lkd1);
            this.panel2.Controls.Add(this.leg2);
            this.panel2.Controls.Add(this.lsd2);
            this.panel2.Controls.Add(this.lkd2);
            this.panel2.Controls.Add(this.lpavadinimas);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 464);
            this.panel2.TabIndex = 2;
            // 
            // leg1
            // 
            this.leg1.BackColor = System.Drawing.Color.DimGray;
            this.leg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leg1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leg1.Location = new System.Drawing.Point(692, 102);
            this.leg1.Name = "leg1";
            this.leg1.Size = new System.Drawing.Size(85, 67);
            this.leg1.TabIndex = 9;
            this.leg1.Text = "EG";
            this.leg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsd1
            // 
            this.lsd1.BackColor = System.Drawing.Color.DimGray;
            this.lsd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsd1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsd1.Location = new System.Drawing.Point(601, 102);
            this.lsd1.Name = "lsd1";
            this.lsd1.Size = new System.Drawing.Size(85, 67);
            this.lsd1.TabIndex = 8;
            this.lsd1.Text = "SD";
            this.lsd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lkd1
            // 
            this.lkd1.BackColor = System.Drawing.Color.DimGray;
            this.lkd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lkd1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkd1.Location = new System.Drawing.Point(510, 102);
            this.lkd1.Name = "lkd1";
            this.lkd1.Size = new System.Drawing.Size(85, 67);
            this.lkd1.TabIndex = 7;
            this.lkd1.Text = "KD";
            this.lkd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leg2
            // 
            this.leg2.BackColor = System.Drawing.Color.DimGray;
            this.leg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leg2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leg2.Location = new System.Drawing.Point(692, 181);
            this.leg2.Name = "leg2";
            this.leg2.Size = new System.Drawing.Size(85, 67);
            this.leg2.TabIndex = 6;
            this.leg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsd2
            // 
            this.lsd2.BackColor = System.Drawing.Color.DimGray;
            this.lsd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsd2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsd2.Location = new System.Drawing.Point(601, 181);
            this.lsd2.Name = "lsd2";
            this.lsd2.Size = new System.Drawing.Size(85, 67);
            this.lsd2.TabIndex = 5;
            this.lsd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lkd2
            // 
            this.lkd2.BackColor = System.Drawing.Color.DimGray;
            this.lkd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lkd2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkd2.Location = new System.Drawing.Point(510, 181);
            this.lkd2.Name = "lkd2";
            this.lkd2.Size = new System.Drawing.Size(85, 67);
            this.lkd2.TabIndex = 4;
            this.lkd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lpavadinimas
            // 
            this.lpavadinimas.BackColor = System.Drawing.Color.DimGray;
            this.lpavadinimas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpavadinimas.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpavadinimas.Location = new System.Drawing.Point(23, 181);
            this.lpavadinimas.Name = "lpavadinimas";
            this.lpavadinimas.Size = new System.Drawing.Size(481, 67);
            this.lpavadinimas.TabIndex = 3;
            this.lpavadinimas.Text = "Pavadinimas";
            this.lpavadinimas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pavadinimas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gryžti atgal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImageLocation = "D:\\Programavimas\\Sharpas\\Praktika\\Praktika\\nuotrauka\\x-mark-16.png";
            this.pictureBox1.Location = new System.Drawing.Point(754, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Studentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Studentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView Sarasas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button perziureti;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label leg1;
        private System.Windows.Forms.Label lsd1;
        private System.Windows.Forms.Label lkd1;
        private System.Windows.Forms.Label leg2;
        private System.Windows.Forms.Label lsd2;
        private System.Windows.Forms.Label lkd2;
        private System.Windows.Forms.Label lpavadinimas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}