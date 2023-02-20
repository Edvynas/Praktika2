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
    public partial class Studentas : Form
    {
        string source = @"Data source=D:\Programavimas\Sharpas\Praktika\Praktika\Duombaze.db;Version=3;";
        Vartotojas studentas = new Vartotojas();
        public Studentas(Vartotojas Student1)
        {
            studentas = Student1;
            InitializeComponent();

            panel2.Hide();
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                conn.Open();
                string query = "select pavadinimas from dalykas inner JOIN paskaitos on dalykas.id = paskaitos.dalykasid where grupeid= '" + studentas.id2 + "'";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                while (reader.Read())
                    Sarasas.Items.Add(reader.GetString(0));
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sarasas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sarasas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pazymiai_Click(object sender, EventArgs e)
        {
            string dalykasid = "";

            if(Sarasas.SelectedItems.Count == 1)
            {
                lkd2.Text = "";
                lsd2.Text = "";
                leg2.Text = "";
                panel1.Hide();
                panel2.Show();

                lpavadinimas.Text = Sarasas.SelectedItems[0].Text.Trim();

                SQLiteConnection conn = new SQLiteConnection(source);

                try
                {
                    conn.Open();
                    string query = "select id from dalykas where pavadinimas ='" + lpavadinimas.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        dalykasid = Convert.ToString(reader[0]);


                    lkd2.Text = studentas.pazimys(dalykasid, "1");

                    lsd2.Text = studentas.pazimys(dalykasid, "2");

                    leg2.Text = studentas.pazimys(dalykasid, "3");

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
            else
            {
                MessageBox.Show("Pasirinkite paskaita");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
