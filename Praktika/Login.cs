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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = "";
            string vardas = "";
            string pavarde = "";
            string username = "";
            string password = "";
            string uniqueid = "";

            string query = ("select * from studentas where username= '" + user.Text.Trim() + "' and password= '" + pass.Text.Trim() + "'");
            SQLiteConnection conn = new SQLiteConnection(@"Data source=D:\Programavimas\Sharpas\Praktika\Praktika\Duombaze.db;Version=3;");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToString(reader[0]);
                    vardas = Convert.ToString(reader[1]);
                    pavarde = Convert.ToString(reader[2]);
                    username = Convert.ToString(reader[3]);
                    password = Convert.ToString(reader[4]);
                    uniqueid = Convert.ToString(reader[5]);
                }

                Vartotojas studentas1 = new Vartotojas(id, vardas, pavarde, username, password, uniqueid);
                Studentas stu = new Studentas(studentas1);
                this.Hide();
                stu.ShowDialog(this);
                this.Show();
                user.Text = "";
                pass.Text = "";
            }
            else
            {
                query = ("select * from destytojas where username= '" + user.Text.Trim() + "' and password= '" + pass.Text.Trim() + "'");
                cmd = new SQLiteCommand(query, conn);
                da = new SQLiteDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = Convert.ToString(reader[0]);
                        vardas = Convert.ToString(reader[1]);
                        pavarde = Convert.ToString(reader[2]);
                        username = Convert.ToString(reader[3]);
                        password = Convert.ToString(reader[4]);
                        uniqueid = Convert.ToString(reader[5]);
                    }


                    Vartotojas destytojas1 = new Vartotojas(id, vardas, pavarde, username, password, uniqueid);

                    Destytojas dest = new Destytojas(destytojas1);
                    this.Hide();
                    dest.ShowDialog(this);
                    this.Show();
                    user.Text = "";
                    pass.Text = "";
                }

                else
                {
                    query = ("select * from admin where username= '" + user.Text.Trim() + "' and password= '" + pass.Text.Trim() + "'");
                    cmd = new SQLiteCommand(query, conn);
                    da = new SQLiteDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Adminas admin = new Adminas();
                        Admin adm = new Admin(admin);
                        this.Hide();
                        adm.ShowDialog(this);
                        this.Show();
                        user.Text = "";
                        pass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Kazkas inncorect");
                    }

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
