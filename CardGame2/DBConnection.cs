using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Oracle.ManagedDataAccess.Client;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace cardGame
{
    /// <summary>
    /// DataBase를 연결하기 위한 클래스
    /// </summary>
    /// 
    class DBConnection
    {
        private static DBConnection _instance;
        private string _connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ToString();

        public static DBConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        public void Insert(string username, string levelname, int Score, string gametime)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString)) 
            {
                String query = "INSERT INTO CARDGAME VALUES (:username,:levelname, :Score,:gametime)";
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                   try
                    { 
                        command.Parameters.Add(":username", username);
                        command.Parameters.Add(":levelname", levelname);
                        command.Parameters.Add(":Score", Score);
                        command.Parameters.Add(":gametime", gametime);
                    
                        int result = command.ExecuteNonQuery();

                        // Check Error //
                        if (result < 0)
                            Console.WriteLine("Error inserting data into Database!");
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.ToString(), "Error Messge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}