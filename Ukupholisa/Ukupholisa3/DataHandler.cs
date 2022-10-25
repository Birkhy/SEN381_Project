using Genisis;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Ukupholisa3
{
    internal class DataHandler
    {
        public static string server = "localhost";
        public static string database = "ukupholisadb";
        public static string username = "root";
        public static string password = "";
        public static string conn = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
        
        public List<Accounts> GetAccount()
        {
        List<Accounts> AllAccounts = new List<Accounts>();
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("getAccounts", connect);
                command.CommandType = CommandType.StoredProcedure;

                

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AllAccounts.Add(new Accounts(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString())));
                    }
                }
            }
            //else
            //{
            //    return "Iets het hier verkeerd gegaan.";
            //}
            connect.Close();
            return AllAccounts;
        }

        public string UpdateClient(string CID, string SName, string SSName, DateTime DOB, string Sex)
        { 
            MySqlConnection connect = new MySqlConnection(conn);

            if(DOB.Year > 1900 && DOB.Year < DateTime.Now.Year)
            {
                if (CID != "" && SName != "" && SSName != "" && Sex != "")
                {
                    connect.Open();
                    MySqlCommand sql_cmnd = new MySqlCommand("updateClient", connect);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                    sql_cmnd.Parameters.AddWithValue("@FIRST_NAME", SqlDbType.NVarChar).Value = CID;
                    sql_cmnd.Parameters.AddWithValue("@LAST_NAME", SqlDbType.NVarChar).Value = SName;
                    sql_cmnd.Parameters.AddWithValue("@AGE", SqlDbType.NVarChar).Value = SSName;
                    sql_cmnd.Parameters.AddWithValue("@DOB", SqlDbType.Date).Value = DOB;
                    sql_cmnd.Parameters.AddWithValue("@SEX", SqlDbType.NVarChar).Value = Sex;
                    int Row = sql_cmnd.ExecuteNonQuery();
                    if (Row > 0)
                    {
                        connect.Close();
                        return "Client with ID " + CID + " was updated.";
                    }
                    else
                    {
                        connect.Close();
                        return "Client with ID " + CID + " failed to be updated.";
                    }
                }
                else
                {
                    connect.Close();
                    return "Please enter all the needed data to be updated.";
                }
            }
            else
            {
                return "Please enter a correct date.";
            }

            
        }

        public string AddClient(string CID, string SName, string SSName, DateTime DOB, string Sex)
        {
            SqlConnection connect = new SqlConnection(conn);
            if (CID != "" && SName != "" && SSName != "" && Sex != "")
            {
                connect.Open();
                SqlCommand sql_cmnd = new SqlCommand("addClient", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = CID;
                sql_cmnd.Parameters.AddWithValue("@FIRST_NAME", SqlDbType.NVarChar).Value = SName;
                sql_cmnd.Parameters.AddWithValue("@SURNAME", SqlDbType.NVarChar).Value = SSName;
                sql_cmnd.Parameters.AddWithValue("@DOB", SqlDbType.Date).Value = DOB;
                sql_cmnd.Parameters.AddWithValue("@SEX", SqlDbType.NVarChar).Value = Sex;
                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    return "Client with ID " + CID + " was added.";
                }
                else
                {
                    connect.Close();
                    return "Client with ID " + CID + " failed to be added.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter all the required data.";
            }
        }

        public string DeleteClient(string CID)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();

            if (CID != "")
            {
                SqlCommand command = new SqlCommand("deleteClient", connect);
                command.CommandType = CommandType.StoredProcedure;
                int Row = command.ExecuteNonQuery();
                if (Row >= 0)
                {
                    connect.Close();
                    return "Deleted details of Client with the ID: " + CID + ".";
                }
                else
                {
                    connect.Close();
                    return "This Client does not exits.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter the Clients ID.";
            }
        }

        public List<Client> SearchClient(string CID)
        {
            List<Client> FoundList = new List<Client>();
            SqlConnection connect = new SqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("searchClient", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = CID;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FoundList.Add(new Client(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
                    }
                }
            }
            connect.Close();
            return FoundList;
        }
    }
}
