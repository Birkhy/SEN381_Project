using Genisis;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
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

        //This method does verification for user at login. WORKS!
        //Not finished
        public bool CheckUserLog(string UName, string Password)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand sql_cmnd = new MySqlCommand("getLoginUser", connect);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@UName", UName);
            sql_cmnd.Parameters.AddWithValue("@UPassword", Password);
            connect.Open();
            Int16 Row = Convert.ToInt16(sql_cmnd.ExecuteScalar());
            if(Row > 0)
            {
                connect.Close();
                return true;
            }
            connect.Close();
            return false;
        }

        //This method does verification for admin at login. WORKS!
        //Not finished
        public bool CheckAdminLog(string UName, string Password)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand sql_cmnd = new MySqlCommand("getLoginAdmin", connect);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@UName", UName);
            sql_cmnd.Parameters.AddWithValue("@UPassword", Password);
            connect.Open();
            Int16 Row = Convert.ToInt16(sql_cmnd.ExecuteScalar());
            if (Row > 0)
            {
                connect.Close();
                return true;
            }
            connect.Close();
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
        //This method gets the last ID in the Account table in order to add new ones.
        public Int32 getLastID()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand selectlastID = new MySqlCommand("getLastAccountID", connect);
                selectlastID.CommandType = CommandType.StoredProcedure;
                selectlastID.Parameters.Add("lastAccountID", MySqlDbType.Int32);
                selectlastID.Parameters["lastAccountID"].Direction = ParameterDirection.Output;

                selectlastID.ExecuteNonQuery();

                Int32 lastID = (Int32)selectlastID.Parameters["lastAccountID"].Value;





                connect.Close();
                
                return lastID;

            }
            return 0;
        }

        public string AddAccount(int AccountID, int HolderKey, string HolderID, string HolderCell, int PackageID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (HolderKey.ToString().Length == 5 && HolderID != "" && HolderID.Length == 13 && HolderCell.ToString().Length == 10)
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("ddAccount", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@AccountID", AccountID);
                sql_cmnd.Parameters.AddWithValue("@HolderKey", HolderKey);
                sql_cmnd.Parameters.AddWithValue("@HolderID", HolderID);
                sql_cmnd.Parameters.AddWithValue("@HolderCell", HolderCell);
                sql_cmnd.Parameters.AddWithValue("@PackageID", PackageID);
                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    return "Client with ID " + HolderID + " was added.";
                }
                else
                {
                    connect.Close();
                    return "Client with ID " + HolderID + " failed to be added.";
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

        // This method returns a datatable to show the treatments that is searched with relevant providers. WORKS!
        public DataTable SearchTreatment(string partialString)
        {
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
        // This method returns a datatable to show the relevant account and dependants and their conditions. WORKS!
        public DataTable ViewAccountCall(string AccountID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("ViewAccountCall", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@hID", AccountID);
                MySqlDataAdapter sda = new MySqlDataAdapter(command);

                DataTable dt = new DataTable();
                sda.Fill(dt);

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

                // THIS WORKS AS WELL!!!!!!!
                MySqlCommand check_if_account_exists = new MySqlCommand("SELECT COUNT(*) FROM account WHERE Holder_ID =@hID", connect);
                check_if_account_exists.Parameters.AddWithValue("@hID", holderID);
                Int32 accExists = Convert.ToInt32(check_if_account_exists.ExecuteScalar());

                if (accExists > 0)
                {
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
                Int16 keyCorrect = Convert.ToInt16(check_holderkey_correct.ExecuteScalar());

                if (keyCorrect > 0)
                {
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
        //Method returns List to populate combobox associated with a package.
        public List<string> getPackages()
        {
            List<string> AllPackages = new List<string>();
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("SELECT Package_Name FROM product", connect);
                //command.CommandType = CommandType.StoredProcedure;



                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AllPackages.Add(reader[0].ToString());
                    }
                }
            }
            connect.Close();
            return AllPackages;
        }

        public int setPackageID(string PackageName)
        {
            //List<string> AllPackages = new List<string>();
            MySqlConnection connect = new MySqlConnection(conn);
            int PackageID =0;
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand spi = new MySqlCommand("setPackageID", connect);
                spi.CommandType = CommandType.StoredProcedure;
                spi.Parameters.AddWithValue("@PackageName", PackageName);



                using (var reader = spi.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PackageID = int.Parse(reader[0].ToString());
                    }
                    
                }
            }
            connect.Close();
            return PackageID;
        }

        //Method returns datatable to view treatments associated with a package.
        public DataTable ViewPackageTreatments(string PackageName)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand vpt = new MySqlCommand("ViewPackageTreatments", connect);
                vpt.CommandType = CommandType.StoredProcedure;
                vpt.Parameters.AddWithValue("@PackageName", PackageName);
                MySqlDataAdapter sda = new MySqlDataAdapter(vpt);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                connect.Close();
                //MessageBox.Show("Actually returns the datatable");
                return dt;

            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }


        }


    }
}
