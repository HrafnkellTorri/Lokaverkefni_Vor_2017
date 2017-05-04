using System;
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

        public int FindHighscore(string username, int game_ID)
        {
            int highscore = 0;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT score FROM Scores JOIN Users ON Scores.user_ID = Users.ID WHERE username = '" + username + "' AND game_ID = " + game_ID + "";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = mySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        highscore += (Convert.ToInt32(sqllesari.GetValue(i)));
                    }
                }
                CloseConnection();
                return highscore;
            }
            return highscore;
        }

        public int FindUser_ID(string username)
        {
            int user_ID = 0;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT ID FROM Users WHERE username = '" + username + "';";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = mySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        user_ID += (Convert.ToInt32(sqllesari.GetValue(i)));
                    }
                }
                CloseConnection();
                return user_ID;
            }
            return user_ID;
        }

        public void UpdateHighscore(int userID, int newHScore, int gameID)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE Scores SET score = " + newHScore + " WHERE user_ID = " + userID + " AND game_ID = " + gameID + "";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                mySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void InsertHighscore(int userID, int newHScore, int game_ID)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "INSERT INTO Scores (user_ID, game_ID, score) VALUES (" + userID + "," + game_ID + "," + newHScore + ")";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                mySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
