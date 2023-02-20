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
    public class Adminas
    {
        public string source = @"Data source=D:\Programavimas\Sharpas\Praktika\Praktika\Duombaze.db;Version=3;";


        public string uniqueid(string dalykas, string pasirinkimas)
        {
            string ats = "";
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = "select id from '" + dalykas + "' where pavadinimas ='" + pasirinkimas + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                ats = Convert.ToString(reader[0]);
            return ats;
        }        


        public void filldatagird_SD(string table, string dalykas, DataGridView gridview, ComboBox combo)
        {
            string dalykasid = dalykas + "id";
            SQLiteConnection conn = new SQLiteConnection(source);
            string query = "select '"+table+"'.id, vardas, pavarde, username, password, pavadinimas from '"+table+"' inner join '"+dalykas+"' on '"+dalykas+"'.id = '"+table+"'.'"+dalykasid+"'";
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            gridview.DataSource = ds.Tables[table].DefaultView;

            query = "select pavadinimas from '"+dalykas+"'";
            cmd = new SQLiteCommand(query, conn);
            da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                combo.Items.Add(dr["pavadinimas"].ToString());
            }
        }

        public void insert_SD(string id, string vardas, string pavarde, string id2, string table)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = "INSERT INTO '" + table + "' VALUES ('" + id + "','" + vardas + "','" + pavarde + "','" + vardas + "','" + pavarde + "','" + id2 + "')";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        public void update_SD(string id, string vardas, string pavarde,string username, string password, string id2, string table, string dalykasid)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = ("update '" + table + "' set id='" + id + "',vardas='" + vardas + "',pavarde='" + pavarde + "',username='" + username + "',password='" + password + "','" + dalykasid + "'= '" + id2 + "' where id = '" + id + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        public void delete_SD(string id, string table)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = ("delete from '"+table+"' where id='" + id + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }


        public void fillgrid_GD(string table, DataGridView gridView)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = "select * from '"+table+"'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            gridView.DataSource = ds.Tables[table].DefaultView;
        }

        public void insert_GD(string id, string pavadinimas, string table)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = ("INSERT INTO '"+table+"' VALUES ('" + id + "','" + pavadinimas + "')");
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        public void update_GD(string id, string pavadinimas, string table)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = ("update '"+table+"' set id='" + id + "',pavadinimas='" + pavadinimas + "' where id = '" + id + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        public void delete_GD(string id, string table)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = ("delete from '"+table+"' where id='" + id + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        
    }
}
