using Genisis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Ukupholisa3
{
    internal class DataHandler
    {
        public string conn = "Data source=.;Initial Catalog=StudentInfo;Integrated security=True";

        public List<Client> GetClient()
        {
            List<Client> AllClients = new List<Client>();
            SqlConnection connect = new SqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("showClient", connect);
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AllClients.Add(new Client(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
                    }
                }
            }
            connect.Close();
            return AllClients;
        }

        public string UpdateClient(string CID, string SName, string SSName, DateTime DOB, string Sex)
        {
            SqlConnection connect = new SqlConnection(conn);

            if (CID != "" && SName != "" && SSName != "" && Sex != "")
            {
                connect.Open();
                SqlCommand sql_cmnd = new SqlCommand("updateClient", connect);
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
