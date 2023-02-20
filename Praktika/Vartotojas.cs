using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Data.SQLite;

namespace Praktika
{
    public class Vartotojas
    {
        public string source = @"Data source=D:\Programavimas\Sharpas\Praktika\Praktika\Duombaze.db;Version=3;";
        public string id;
        public string vardas;
        public string pavarde;
        public string username;
        public string password;
        public string id2;

        public Vartotojas()
        {
            id = "";
            vardas = "";
            pavarde = "";
            username = "";
            password = "";
            id2 = "";
        }

        public Vartotojas(string id1, string v, string p, string usern, string pass, string idd)
        {
            id = id1;
            vardas = v;
            pavarde = p;
            username = usern;
            password = pass;
            id2 = idd;
        }
        public string pazimys(string dalykasid, string darbasid)
        {
            string pazimys = "";
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();

            string query = "select pazimys from pazimys where studentasid = '" + id + "' and darbasid ='" + darbasid + "' and dalykasid= '" + dalykasid + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                pazimys = Convert.ToString(reader[0]);
            conn.Close();

            return pazimys;

        }
        public string pazymiai(string studentasid, string darbasid)
        {
            string pazimys = "";
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = "select pazimys from pazimys where pazimys.dalykasid ='" + id2 + "' and pazimys.studentasid ='" + studentasid + "' and pazimys.darbasid = '" + darbasid + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                pazimys = Convert.ToString(reader[0]);
            if (pazimys.Length == 0)
                pazimys = "0";

            return pazimys;
        }
        public void update_pazimys(string studentasid, string darbasid, string pazimys)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = "update pazimys set pazimys = '" + pazimys + "' where studentasid ='" + studentasid + "' and darbasid = '" + darbasid + "' and dalykasid ='" + id2 + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        public void insert_pazimys(string studentasid, string darbasid, string pazimys)
        {
            SQLiteConnection conn = new SQLiteConnection(source);
            conn.Open();
            string query = "insert into pazimys values ('" + studentasid + "', '" + darbasid + "','" + id2 + "','" + pazimys + "')";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
