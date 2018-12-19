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
    class DBQuery
    {
        private static DBQuery instance;
        private string _connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ToString();

        public static DBQuery getInstance()
        {
            if (instance == null)
            {
                instance = new DBQuery();
            }
            return instance;
        }
        public void Insert(String username, String levelname, int Score, string gametime)
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

                        // Check Error
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