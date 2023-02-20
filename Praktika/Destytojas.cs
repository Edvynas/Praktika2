using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Praktika
{

    public partial class Destytojas : Form
    {
        Vartotojas destytojas = new Vartotojas();
        string vardas = "";
        string pavarde = "";
        string source = @"Data source=D:\Programavimas\Sharpas\Praktika\Praktika\Duombaze.db;Version=3;";
        string studentasid = "";
        string kd = "";
        string sd = "";
        string eg = "";
        public Destytojas(Vartotojas destytojas1)
        {

            destytojas = destytojas1;
            InitializeComponent();

            panel1.Hide();
            panel2.Hide();
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                string query = "select grupe.pavadinimas from grupe inner join paskaitos on paskaitos.grupeid = grupe.id inner join dalykas on paskaitos.dalykasid = dalykas.id where dalykas.id = '"+ destytojas.id2+"'";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    combogrupe.Items.Add(dr["pavadinimas"].ToString());
                }

                query = "select pavadinimas from dalykas inner join destytojas on dalykas.id = destytojas.dalykasid where destytojas.dalykasid ='" + destytojas.id2 + "'";
                cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    label2.Text = Convert.ToString(reader[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }



        private void Pgrupe_Click(object sender, EventArgs e)
        {
            string grupeid = "";
            panel1.Show();
            panel2.Hide();
            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                string query = "select id from grupe where pavadinimas ='" + combogrupe.Text + "'";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    grupeid = Convert.ToString(reader[0]);

                query = "select vardas, pavarde from studentas where grupeid='" + grupeid + "'";
                cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Studentai");
                Gstudentai.DataSource = ds.Tables["Studentai"].DefaultView;
                Gstudentai.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            tkd.Text = "";
            tsd.Text = "";
            teg.Text = "";
            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                conn.Open();
                string query = "select id from studentas where vardas='" + vardas + "' and pavarde ='" + pavarde + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    studentasid = Convert.ToString(reader[0]);

                lvardas.Text = vardas + " " + pavarde;

                tkd.Text = destytojas.pazymiai(studentasid, "1");

                tsd.Text = destytojas.pazymiai(studentasid, "2");

                teg.Text = destytojas.pazymiai(studentasid, "3");

                kd = tkd.Text;
                sd = tsd.Text;
                eg = teg.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void Gstudentai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = Gstudentai.Rows[index];
            vardas = selectedRow.Cells[0].Value.ToString();
            pavarde = selectedRow.Cells[1].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                if (Int32.Parse(tkd.Text) <= 10 && Int32.Parse(tkd.Text) >= 0 && Int32.Parse(tsd.Text) <= 10 && Int32.Parse(tsd.Text) >= 0 && Int32.Parse(teg.Text) <= 10 && Int32.Parse(teg.Text) >= 0)
                {
                    conn.Open();

                    //Kontrolinio
                    if (kd != "0" && kd != tkd.Text)
                        destytojas.update_pazimys(studentasid, "1", tkd.Text);
                    else if (kd == "0" && kd != tkd.Text)
                        destytojas.insert_pazimys(studentasid, "1", tkd.Text);


                    //Savarankisko
                    if (sd != "0" && sd != tsd.Text)
                        destytojas.update_pazimys(studentasid, "2", tsd.Text);
                    else if (sd == "0" && sd != tsd.Text)
                        destytojas.insert_pazimys(studentasid, "2", tsd.Text);


                    //Egzamino
                    if (eg != "0" && eg != teg.Text)
                        destytojas.update_pazimys(studentasid, "3", teg.Text);
                    else if (eg == "0" && eg != teg.Text)
                        destytojas.insert_pazimys(studentasid, "3", teg.Text);


                    MessageBox.Show("Pazymiai pakeisti");

                }
                else
                {
                    MessageBox.Show("Parašykite pažymį nuo 0 iki 10");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
    
}

    


