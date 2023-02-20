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
    public partial class Admin : Form
    {
        string source = @"Data source=D:\Programavimas\Sharpas\Praktika\Praktika\Duombaze.db;Version=3;";
        Adminas admin = new Adminas();
        public Admin(Adminas adm)
        {
            admin = adm;
            InitializeComponent();

            student1.Hide();
            destytojai1.Hide();
            grupe1.Hide();
            dalykai1.Hide();
            grupiudalykai1.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = Gstudentai.Rows[index];
                Sid.Text = selectedRow.Cells[0].Value.ToString();
                Svardas.Text = selectedRow.Cells[1].Value.ToString();
                Spavarde.Text = selectedRow.Cells[2].Value.ToString();
                Susername.Text = selectedRow.Cells[3].Value.ToString();
                Spassword.Text = selectedRow.Cells[4].Value.ToString();
                Sgrupe.SelectedItem = selectedRow.Cells[5].Value.ToString();
            }

        }

        private void studentai_Click(object sender, EventArgs e)
        {
            student1.Show();
            destytojai1.Hide();
            grupe1.Hide();
            dalykai1.Hide();
            grupiudalykai1.Hide();
            Sgrupe.Items.Clear();

            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                admin.filldatagird_SD("studentas", "grupe", Gstudentai, Sgrupe);
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

        private void Prideti_Click(object sender, EventArgs e)
        {
            string grupeid = "";
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                grupeid = admin.uniqueid("grupe", Sgrupe.SelectedItem.ToString());

                admin.insert_SD(Sid.Text, Svardas.Text, Spavarde.Text, grupeid, "studentas");

                MessageBox.Show("Inserted sucessfully");
                Sid.Text = "";
                Svardas.Text = "";
                Spavarde.Text = "";
                Susername.Text = "";
                Spassword.Text = "";
                Sgrupe.SelectedItem = null;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string grupeid = "";
            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                grupeid = admin.uniqueid("grupe", Sgrupe.SelectedItem.ToString());

                admin.update_SD(Sid.Text, Svardas.Text, Spavarde.Text, Susername.Text, Spassword.Text, grupeid, "studentas", "grupeid");
                
                MessageBox.Show("Updated sucessfully");
                Sid.Text = "";
                Svardas.Text = "";
                Spavarde.Text = "";
                Susername.Text = "";
                Spassword.Text = "";
                Sgrupe.SelectedItem = null;
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

            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                if (Sid.Text != "")
                {
                    admin.delete_SD(Sid.Text, "studentas");

                    MessageBox.Show("Deleted succesfully");
                    Sid.Text = "";
                    Svardas.Text = "";
                    Spavarde.Text = "";
                    Susername.Text = "";
                    Spassword.Text = "";
                    Sgrupe.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Pasirinkite studentą");
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

        private void destytojai_Click(object sender, EventArgs e)
        {
            destytojai1.Show();
            student1.Hide();
            grupe1.Hide();
            dalykai1.Hide();
            grupiudalykai1.Hide();

            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                admin.filldatagird_SD("destytojas", "dalykas", Gdestytojai, Ddalykas);
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

        private void Gdestytojai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = Gdestytojai.Rows[index];
                Did.Text = selectedRow.Cells[0].Value.ToString();
                Dvardas.Text = selectedRow.Cells[1].Value.ToString();
                Dpavarde.Text = selectedRow.Cells[2].Value.ToString();
                Dusername.Text = selectedRow.Cells[3].Value.ToString();
                Dpassword.Text = selectedRow.Cells[4].Value.ToString();
                Ddalykas.SelectedItem = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dalykasid = "";
            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                dalykasid = admin.uniqueid("dalykas", Ddalykas.SelectedItem.ToString());

                admin.insert_SD(Did.Text, Dvardas.Text, Dpavarde.Text, dalykasid, "destytojas");
                MessageBox.Show("Inserted sucessfully");
                Did.Text = "";
                Dvardas.Text = "";
                Dpavarde.Text = "";
                Dusername.Text = "";
                Dpassword.Text = "";
                Ddalykas.SelectedItem = null;
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

        private void button4_Click(object sender, EventArgs e)
        {
            string dalykasid = "";
            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                dalykasid = admin.uniqueid("dalykas", Ddalykas.SelectedItem.ToString());

                admin.update_SD(Did.Text, Dvardas.Text, Dpavarde.Text, Dusername.Text, Dpassword.Text, dalykasid, "destytojas", "dalykasid");
                MessageBox.Show("Updated sucessfully");
                Did.Text = "";
                Dvardas.Text = "";
                Dpavarde.Text = "";
                Dusername.Text = "";
                Dpassword.Text = "";
                Ddalykas.SelectedItem = null;
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
            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                admin.delete_SD(Did.Text, "destytojas");

                MessageBox.Show("Deleted succesfully");
                Did.Text = "";
                Dvardas.Text = "";
                Dpavarde.Text = "";
                Dusername.Text = "";
                Dpassword.Text = "";
                Ddalykas.SelectedItem = null;
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

        private void grupe_Click(object sender, EventArgs e)
        {
            grupe1.Show();
            destytojai1.Hide();
            student1.Hide();
            dalykai1.Hide();
            grupiudalykai1.Hide();

            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                admin.fillgrid_GD("grupe", Ggrupe);
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

        private void Ggrupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = Ggrupe.Rows[index];
            Gid.Text = selectedRow.Cells[0].Value.ToString();
            Gpavadinimas.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                admin.insert_GD(Gid.Text, Gpavadinimas.Text, "grupe");

                MessageBox.Show("Inserted sucessfully");
                Gid.Text = "";
                Gpavadinimas.Text = "";
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

        private void button7_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                admin.update_GD(Gid.Text, Gpavadinimas.Text, "grupe");

                MessageBox.Show("Updated sucessfully");
                Gid.Text = "";
                Gpavadinimas.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                admin.delete_GD(Gid.Text, "grupe");
                MessageBox.Show("Deleted succesfully");
                Gid.Text = "";
                Gpavadinimas.Text = "";
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

        private void button11_Click(object sender, EventArgs e)
        {
            Sgrupe.Items.Clear();
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {

                admin.filldatagird_SD("studentas", "grupe", Gstudentai, Sgrupe);

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

        private void button9_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {

                admin.fillgrid_GD("grupe", Ggrupe);

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

        private void button10_Click(object sender, EventArgs e)
        {   
            Ddalykas.Items.Clear();
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {

                admin.filldatagird_SD("destytojas", "dalykas", Gdestytojai, Ddalykas);

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

        private void Gdalykas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = Gdalykas.Rows[index];
            Daid.Text = selectedRow.Cells[0].Value.ToString();
            Dapavadinimas.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void dalykai_Click(object sender, EventArgs e)
        {
            dalykai1.Show();
            grupe1.Hide();
            destytojai1.Hide();
            student1.Hide();
            grupiudalykai1.Hide();

            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {

                admin.fillgrid_GD("dalykas", Gdalykas);

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

        private void button15_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {

                admin.insert_GD(Daid.Text, Dapavadinimas.Text, "dalykas");

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

        private void button14_Click(object sender, EventArgs e)
        {   
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {

                admin.update_GD(Daid.Text, Dapavadinimas.Text, "dalykas");

                MessageBox.Show("Inserted sucessfully");
                Daid.Text = "";
                Dapavadinimas.Text = "";
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

        private void button13_Click(object sender, EventArgs e)
        {   
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                admin.delete_GD(Daid.Text, "dalykas");
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

        private void button12_Click(object sender, EventArgs e)
        {   

            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {

                admin.fillgrid_GD("dalykas", Gdalykas);

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

        private void Ggrupiudalykai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grupiudalykai_Click(object sender, EventArgs e)
        {
            grupiudalykai1.Show();
            dalykai1.Hide();
            grupe1.Hide();
            destytojai1.Hide();
            student1.Hide();
            Combogrupes.Items.Clear();
            Ggrupiudalykai.DataSource = null;
            Ggrupiudalykai.Rows.Clear();
            Ggrupiudalykai.Columns.Clear();
            Ggrupiudalykai.Refresh();

            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                string query = "select * from grupe";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Combogrupes.Items.Add(dr["pavadinimas"].ToString());
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

        private void button16_Click(object sender, EventArgs e)
        {
            comboprideti.Items.Clear();
            combopasalinti.Items.Clear();
            
            SQLiteConnection conn = new SQLiteConnection(source);
            try
            {
                string query = ("SELECT dalykas.pavadinimas FROM dalykas inner JOIN paskaitos ON paskaitos.dalykasid = dalykas.id inner join grupe on paskaitos.grupeid = grupe.id where grupe.pavadinimas = '" + Combogrupes.SelectedItem.ToString() + "'");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Grupiu dalykai");
                Ggrupiudalykai.DataSource = ds.Tables["Grupiu dalykai"].DefaultView;
                Ggrupiudalykai.Columns["pavadinimas"].Width = 200;

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    combopasalinti.Items.Add(dr["pavadinimas"].ToString());
                }

                query = "select * from dalykas";
                cmd = new SQLiteCommand(query, conn);
                da = new SQLiteDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    if (combopasalinti.Items.Contains(dr["pavadinimas"].ToString()) == false)
                        comboprideti.Items.Add(dr["pavadinimas"].ToString());
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

        private void button17_Click(object sender, EventArgs e)
        {
            string grupeid = "";
            string dalykasid = "";
            
            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                string query = ("select id from grupe where pavadinimas ='" + Combogrupes.SelectedItem.ToString() + "'");

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    grupeid = Convert.ToString(reader[0]);


                query = ("select id from dalykas where pavadinimas ='" + comboprideti.SelectedItem.ToString() + "'");
                cmd = new SQLiteCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    dalykasid = Convert.ToString(reader[0]);


                query = "insert into paskaitos values ('" + grupeid + "','" + dalykasid + "')";
                cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted sucessfully");
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

        private void button19_Click(object sender, EventArgs e)
        {
            

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string grupeid = "";
            string dalykasid = "";
            
            SQLiteConnection conn = new SQLiteConnection(source);

            try
            {
                string query = ("select id from grupe where pavadinimas ='" + Combogrupes.SelectedItem.ToString() + "'");

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    grupeid = Convert.ToString(reader[0]);


                query = ("select id from dalykas where pavadinimas ='" + combopasalinti.SelectedItem.ToString() + "'");
                cmd = new SQLiteCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    dalykasid = Convert.ToString(reader[0]);


                query = "delete from paskaitos where grupeid= '" + grupeid + "' and dalykasid= '" + dalykasid + "'";
                cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted sucessfully");
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

        private void button19_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Daid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Combogrupes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ggrupiudalykai_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
