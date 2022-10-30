using Genisis;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ukupholisa3
{
    internal class DataHandler
    {
        public static string server = "localhost";
        public static string database = "ukupholisadb";
        public static string username = "root";
        public static string password = "";
        public static string conn = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

        public bool CheckUserLog(string UName, string Password)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand sql_cmnd = new MySqlCommand("getLogin", connect);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@UName", SqlDbType.NVarChar).Value = UName;
            sql_cmnd.Parameters.AddWithValue("@UPassword", SqlDbType.NVarChar).Value = Password;

            int Row = sql_cmnd.ExecuteNonQuery();
            if(Row > 0)
            {
                return true;
            }
            return false;
        }

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
            connect.Close();
            return AllAccounts;
        }

        public string UpdateClient(string CID, string SName, string SSName, DateTime DOB, string Sex)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (DOB.Year > 1900 && DOB.Year < DateTime.Now.Year)
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

        public DataTable SearchTreatment(string partialString)
        {
            //ArrayList FoundList = new ArrayList();
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("GetProviderWithTreatment", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TreatmentName", partialString);
                MySqlDataAdapter sda = new MySqlDataAdapter(command);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                //while (reader.Read())
                //{
                //    // var Foundlist = new ArrayList() { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                //    FoundList.Add(reader[0].ToString());
                //    FoundList.Add(reader[1].ToString());
                //    FoundList.Add(reader[2].ToString());
                //}
                connect.Close();
                MessageBox.Show("Actually returns the datatable");
                return dt;

            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }


        }
        //This method checks whether an account exists and returns a boolean, it works.
        public bool checkAccount(string holderID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (holderID != "" && holderID.Length == 13)
            {
                connect.Open();
                //string testID = "0101265114088";

                // THIS WORKS AS WELL!!!!!!!
                MySqlCommand check_if_account_exists = new MySqlCommand("SELECT COUNT(*) FROM account WHERE Holder_ID =@hID", connect);
                check_if_account_exists.Parameters.AddWithValue("@hID", holderID);
                Int32 accExists = Convert.ToInt32(check_if_account_exists.ExecuteScalar());

                // THIS WORKS!!!!!!
                //MySqlCommand check_if_account_exists = new MySqlCommand("CheckAccount", connect);
                //check_if_account_exists.CommandType = CommandType.StoredProcedure;
                //check_if_account_exists.Parameters.AddWithValue("@hID", holderID);
                //Int32 accExists = Convert.ToInt32(check_if_account_exists.ExecuteScalar());

                // THIS WORKS!!!!!!!
                //MessageBox.Show("We got here");
                //MySqlCommand check_if_account_exists = new MySqlCommand("SELECT COUNT(*) FROM account WHERE Holder_ID =" + holderID + ";", connect);
                //MessageBox.Show("We got there");
                //Int32 accExists = Convert.ToInt32(check_if_account_exists.ExecuteScalar());

                if (accExists > 0)
                {
                    //MessageBox.Show("account does indeed exist");
                    connect.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Account does not exist within the system!");
                    connect.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid ID number");
                connect.Close();
                return false;
            }
        }
        //This method verifies an account holderkey and returns a boolean, it works.
        public bool checkHolderKey(int holderKey, string holderID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (holderKey != 0 && (holderKey.ToString()).Length == 5)
            {
                connect.Open();

                // THIS WORKS AS WELL!!!!!!!
                MySqlCommand check_holderkey_correct = new MySqlCommand("SELECT COUNT(*) FROM account WHERE Holder_ID =@hID AND Holder_Key = @hKey", connect);
                check_holderkey_correct.Parameters.AddWithValue("@hID", holderID);
                check_holderkey_correct.Parameters.AddWithValue("@hKey", holderKey);
                Int32 keyCorrect = Convert.ToInt32(check_holderkey_correct.ExecuteScalar());

                if (keyCorrect > 0)
                {
                    //MessageBox.Show("account does indeed exist");
                    connect.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect Key!");
                    connect.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Key");
                connect.Close();
                return false;
            }
        }

        //This method verifies an account phone number and returns a boolean, it works.
        public bool checkHolderPhone(string holderPhone, string holderID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (holderPhone != "" && holderPhone.Length == 10)
            {
                connect.Open();

                // THIS WORKS AS WELL!!!!!!!
                MySqlCommand check_holderkey_correct = new MySqlCommand("SELECT COUNT(*) FROM account WHERE Holder_ID =@hID AND Holder_Cell = @hPhone", connect);
                check_holderkey_correct.Parameters.AddWithValue("@hID", holderID);
                check_holderkey_correct.Parameters.AddWithValue("@hPhone", holderPhone);
                Int32 keyCorrect = Convert.ToInt32(check_holderkey_correct.ExecuteScalar());

                if (keyCorrect > 0)
                {
                    //MessageBox.Show("account does indeed exist");
                    connect.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect Phone Number!");
                    connect.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Phone Number");
                connect.Close();
                return false;
            }
        }


    }
}
