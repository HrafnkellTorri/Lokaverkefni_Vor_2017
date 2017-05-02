﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/* Lokaverkefni
 * Vor 2017
 * Erla Óskarsdóttir
 * Hrafnkell Þorri Þrastarson */

namespace Lokaverkefni
{
    class Gagnagrunnur
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        string tengistrengur = null;
        string fyrirspurn = null;

        MySqlConnection sqltenging;
        MySqlCommand mySQLskipun;
        MySqlDataReader sqllesari;

        public void TengingVidGagnagrunn()
        {
            server = "localhost";//"188.166.169.15";
            database = "Lokaverkefni";
            uid = "erlalocal";
            password = "ZIPZm5dpN8Vw2uw6";
            tengistrengur = "server=" + server + ";port=3306;userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }

        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex ;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public string FindPassword(string username)
        {
            string passw = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT password FROM Users WHERE username = '" + username + "';";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = mySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        passw += (sqllesari.GetValue(i).ToString());
                    }
                }
                CloseConnection();
                return passw;
            }
            return passw;
        }

        public void SignUpUser(string user, string passw, string date, string email, string country)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "INSERT INTO Users (username, password, date_of_birth, email, country) VALUES ('" + user + "','" + passw + "','" + date + "','" + email + "','" + country + "')";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                mySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
