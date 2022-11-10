using Genisis;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (Row > 0)
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
        //updates account
        public string UpdateAccount(string HolderKey, string HolderID, string HolderCell, int PackageID)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (HolderID != "" && HolderID.Length == 13 && Regex.Match(HolderID, "^[0-9]{13}$").Success)
            {
                if (HolderKey != "" && HolderKey.Length == 5)
                {
                    if (HolderCell.Length == 10)
                    {
                        connect.Open();
                        MySqlCommand sql_cmnd = new MySqlCommand("updateAccount", connect);
                        sql_cmnd.CommandType = CommandType.StoredProcedure;
                        sql_cmnd.Parameters.AddWithValue("@HolderKey", HolderKey);
                        sql_cmnd.Parameters.AddWithValue("@HolderID", HolderID);
                        sql_cmnd.Parameters.AddWithValue("@HolderCell", HolderCell);
                        sql_cmnd.Parameters.AddWithValue("@PackageID", PackageID);

                        int Row = sql_cmnd.ExecuteNonQuery();
                        if (Row > 0)
                        {
                            connect.Close();
                            return "Account with the ID " + HolderID + " was updated in the database.";
                        }
                        else
                        {
                            connect.Close();
                            return $"The Account with the ID {HolderID} does not exist.";
                        }
                    }
                    else
                    {
                        return "Please enter a valid contact number.";
                    }

                }
                else
                {
                    return "Please enter a valid Key.";
                }
            }
            else
            {
                return "Please enter a valid ID.";
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

        //updates dependant
        public string updateDependant(string DependantID, string DependantName, string DependantSurname, DateTime DOB, string Sex)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (DependantID.Length == 13)
            {
                if (DependantName != "" && DependantName.Length <= 50 && Regex.Match(DependantName, "^[A-Z][a-zA-Z]*$").Success)
                {
                    if (DependantSurname != "" && DependantSurname.Length <= 150)
                    {
                            if (Sex != "")
                            {
                                    connect.Open();
                                    MySqlCommand sql_cmnd = new MySqlCommand("updateDependant", connect);
                                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                                    sql_cmnd.Parameters.AddWithValue("@DependantID", DependantID);
                                    sql_cmnd.Parameters.AddWithValue("@DependantName", DependantName);
                                    sql_cmnd.Parameters.AddWithValue("@DependantSurname", DependantSurname);
                                    sql_cmnd.Parameters.AddWithValue("@sDOB", DOB);
                                    sql_cmnd.Parameters.AddWithValue("@sSex", Sex);

                                    int Row = sql_cmnd.ExecuteNonQuery();
                                    if (Row > 0)
                                    {
                                        connect.Close();
                                        return "Dependant with the ID " + DependantID + " was updated in the database.";
                                    }
                                    else
                                    {
                                        connect.Close();
                                        return $"Dependant with the ID {DependantID} does not exist.";
                                    }
                            }
                            else
                            {
                                return "Please enter a valid sex.";
                            }
                    }
                    else
                    {
                        return "Please enter a valid surname.";
                    }
                }
                else
                {
                    return "Please enter a valid Name.";
                }
            }
            else
            {
                return "Please enter a valid ID.";
            }
        }

        //This method gets the last ID in the Call table in order to add new ones.
        public Int32 getLastCallID()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand selectlastID = new MySqlCommand("getLastCallID", connect);
                selectlastID.CommandType = CommandType.StoredProcedure;
                selectlastID.Parameters.Add("lastCallID", MySqlDbType.Int32);
                selectlastID.Parameters["lastCallID"].Direction = ParameterDirection.Output;

                selectlastID.ExecuteNonQuery();

                Int32 lastID = (Int32)selectlastID.Parameters["lastCallID"].Value;





                connect.Close();

                return lastID;

            }
            return 1;
        }

        //adds call to the call table
        public bool AddCallStart(int CallID, DateTime CallDate, DateTime CallStartTime)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (CallDate != null && CallStartTime != null)
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("AddCall", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@CallID", CallID);
                sql_cmnd.Parameters.AddWithValue("@CallDate", CallDate);
                sql_cmnd.Parameters.AddWithValue("@CallStartTime", CallStartTime);

                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    MessageBox.Show("Call added");
                    return true;
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Call failed to be added.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter all required data");
                connect.Close();
                return false;
            }
        }

        public bool AddCallEnd(int CallID, string HolderID, DateTime CallEndTime, TimeSpan CallDuration)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (CallEndTime != null && CallEndTime != null)
            {

                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("AddCallEnd", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                if (HolderID == null)
                {
                    sql_cmnd.Parameters.AddWithValue("@HolderID", "Not Regstered");
                }
                else
                {
                    sql_cmnd.Parameters.AddWithValue("@HolderID", HolderID);
                }
                sql_cmnd.Parameters.AddWithValue("@CallID", CallID);
                sql_cmnd.Parameters.AddWithValue("@CallEndTime", CallEndTime);
                sql_cmnd.Parameters.AddWithValue("@CallDuration", CallDuration);

                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    MessageBox.Show("Call added");
                    return true;
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Call failed to be added.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter all required data");
                connect.Close();
                return false;
            }
        }
        //adds to accountcall
        public bool AddAccountCall(string HolderID, int CallID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (HolderID != "")
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("AddAccountCall", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@HolderID", HolderID);
                sql_cmnd.Parameters.AddWithValue("@CallID", CallID);


                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    //MessageBox.Show("Condition with ID " + ConditionID + " was aAdded.");
                    return true;
                }
                else
                {
                    connect.Close();
                    //MessageBox.Show("Condition with ID " + ConditionID + " failed to be added.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter all required data");
                connect.Close();
                return false;
            }
        }

        //Adds account to database and returns a bool.
        public bool AddAccount(int AccountID, string HolderKey, string HolderID, string HolderCell, int PackageID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (HolderID != "" && HolderID.Length == 13 && Regex.Match(HolderID, "^[0-9]{13}$").Success)
            {
                if (HolderCell != "" && HolderCell.Length == 10 && Regex.Match(HolderCell, "^[0-9]{10}$").Success)
                {
                    if (HolderKey != "" && HolderKey.Length == 5 && Regex.Match(HolderKey, "^[0-9]{5}$").Success)
                    {
                        connect.Open();
                        MySqlCommand sql_cmnd = new MySqlCommand("AddAccount", connect);
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
                            MessageBox.Show("Client with ID " + HolderID + " was added.");
                            return true;
                        }
                        else
                        {
                            connect.Close();
                            MessageBox.Show("Client with ID " + HolderID + " failed to be added.");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Key");
                        connect.Close();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid cell");
                    connect.Close();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Please enter valid ID");
                connect.Close();
                return false;
            }
        }

        //Adds dependant to the database
        public bool AddDependant(string DependantID, int AccountID, string DependantName, string DependantSurname, DateTime DOB, string Sex)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (DependantID != "" && DependantID.Length == 13 && Regex.Match(DependantID, "^[0-9]{13}$").Success)
            {
                if (DependantName != "" && Regex.Match(DependantName, "^[A-Z][a-zA-Z]*$").Success)
                {
                    if (DependantSurname != "" && Regex.Match(DependantSurname, "^[A-Z][a-zA-Z]*$").Success)
                    {
                        connect.Open();
                        MySqlCommand sql_cmnd = new MySqlCommand("AddDependant", connect);
                        sql_cmnd.CommandType = CommandType.StoredProcedure;
                        sql_cmnd.Parameters.AddWithValue("@DependantID", DependantID);
                        sql_cmnd.Parameters.AddWithValue("@AccountID", AccountID);
                        sql_cmnd.Parameters.AddWithValue("@DependantName", DependantName);
                        sql_cmnd.Parameters.AddWithValue("@DependantSurname", DependantSurname);
                        sql_cmnd.Parameters.AddWithValue("@DOB", DOB);
                        sql_cmnd.Parameters.AddWithValue("@Sex", Sex);
                        int Row = sql_cmnd.ExecuteNonQuery();
                        if (Row > 0)
                        {
                            connect.Close();
                            MessageBox.Show("Client with ID " + DependantID + " was added.");
                            return true;
                        }
                        else
                        {
                            connect.Close();
                            MessageBox.Show("Client with ID " + DependantID + " failed to be added.");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid surname");
                        connect.Close();
                        return false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter valid name");
                    connect.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid ID");
                connect.Close();
                return false;
            }
            
        }
        //adds claim
        public bool AddClaim(int AccountID, string TreatmentName)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (TreatmentName != "")
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("AddClaim", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@AccountID", AccountID);
                sql_cmnd.Parameters.AddWithValue("@TreatmentName", TreatmentName);

                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    MessageBox.Show("Claim was added.");
                    return true;
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Claim failed to be added.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter all required data");
                connect.Close();
                return false;
            }
        }

        //adds condition to dependant
        public bool AddDependantCondition(string DependantID, int ConditionID)

        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (DependantID != "" && DependantID.Length == 13 && Regex.Match(DependantID, "^[0-9]{13}$").Success)
            {
                
                    connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("newAddDependantCondition", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@DependantID", DependantID);
                sql_cmnd.Parameters.AddWithValue("@ConditionID", ConditionID);


                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    MessageBox.Show("Condition with ID " + ConditionID + " was added.");
                    return true;
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Condition with ID " + ConditionID + " failed to be added.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please valid ID");
                connect.Close();
                return false;
            }
        }

        //updates dependant condition
        public string updateDependantCondition(string DependantID, int ConditionID, int CurrentConditionID)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (DependantID != "" && DependantID.Length == 13 && Regex.Match(DependantID, "^[0-9]{13}$").Success)
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("updateDependantCondition", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@DependantID", DependantID);
                sql_cmnd.Parameters.AddWithValue("@ConditionID", ConditionID);
                sql_cmnd.Parameters.AddWithValue("@CurrentConditionID", CurrentConditionID);

                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    return "Dependant condition with the ID " + DependantID + " was updated in the database.";
                }
                else
                {
                    connect.Close();
                    return $"Dependant condition with the ID {DependantID} does not exist or record could not be updated.";
                }
            }
            else
            {
                return "Please enter a valid ID.";
            }
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
        //Method returns datatable with account details.
        public DataTable ViewAccount(string HolderID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("ViewAccount", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@HolderID", HolderID);
                MySqlDataAdapter sda = new MySqlDataAdapter(command);

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

        public DataTable ViewDependentsByAccount(int AccountID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("ViewDependentsByAccount", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountID", AccountID);
                MySqlDataAdapter sda = new MySqlDataAdapter(command);

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

        //public bool checkClaimValid(string ConditionName)
        //{
        //    MySqlConnection connect = new MySqlConnection(conn);
        //    if (ConditionName != "")
        //    {
        //        connect.Open();

        //        // THIS WORKS AS WELL!!!!!!!
        //        MySqlCommand check_if_account_exists = new MySqlCommand("SELECT COUNT(*) FROM account WHERE Holder_ID =@hID", connect);
        //        check_if_account_exists.Parameters.AddWithValue("@hID", ConditionName);
        //        Int32 accExists = Convert.ToInt32(check_if_account_exists.ExecuteScalar());

        //        if (accExists > 0)
        //        {
        //            connect.Close();
        //            return true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Account does not exist within the system!");
        //            connect.Close();
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid ID number");
        //        connect.Close();
        //        return false;
        //    }
        //}

        //This method verifies an account holderkey and returns a boolean, it works.
        public bool checkHolderKey(string holderKey, string holderID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (holderKey != "" && (holderKey.ToString()).Length == 5)
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
            if (holderPhone != "" && holderPhone.Length == 10 && Regex.Match(holderPhone, "^[0-9]{10}$").Success)
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
        //sets account id according to holder id
        public string getAccountID(string HolderID)
        {

            MySqlConnection connect = new MySqlConnection(conn);

            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("getAccountID", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@HolderID", HolderID);
                command.Parameters.Add("AccountID", MySqlDbType.Int32);
                command.Parameters["AccountID"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                string AccountID = command.Parameters["AccountID"].Value.ToString();





                connect.Close();

                return AccountID;
            }
            return "";
        }

        //public Int32 getLastID()
        //{
        //    MySqlConnection connect = new MySqlConnection(conn);
        //    if (connect.State != ConnectionState.Open)
        //    {
        //        connect.Open();
        //        MySqlCommand selectlastID = new MySqlCommand("getLastAccountID", connect);
        //        selectlastID.CommandType = CommandType.StoredProcedure;
        //        selectlastID.Parameters.Add("lastAccountID", MySqlDbType.Int32);
        //        selectlastID.Parameters["lastAccountID"].Direction = ParameterDirection.Output;

        //        selectlastID.ExecuteNonQuery();

        //        Int32 lastID = (Int32)selectlastID.Parameters["lastAccountID"].Value;





        //        connect.Close();

        //        return lastID;

        //    }
        //    return 0;
        //}

        //Method returns List to populate combobox associated with conditions.
        public List<string> getConditions()
        {
            List<string> AllConditions = new List<string>();
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("SELECT conditions.Condition FROM conditions", connect);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AllConditions.Add(reader[0].ToString());
                    }
                }
            }
            connect.Close();
            return AllConditions;
        }

        public List<string> getPackageTreatments(int PackageID)
        {
            List<string> PackageTreatments = new List<string>();
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("getPackageTreatments", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PackageID", PackageID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PackageTreatments.Add(reader[0].ToString());
                    }
                }
            }
            connect.Close();
            return PackageTreatments;
        }

        //Sets package Id for specific claim
        public string setPackageIDClaim(string HolderID)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("getAccountID", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@HolderID", HolderID);
                command.Parameters.Add("AccountID", MySqlDbType.Int32);
                command.Parameters["AccountID"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                string AccountID = command.Parameters["AccountID"].Value.ToString();





                connect.Close();

                return AccountID;
            }
            return "";
        }

        // sets package id according to package name
        public int setPackageID(string PackageName)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            int PackageID = 0;
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

        // sets condition id according to condition name
        public string setConditionID(string VCondition)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("setConditionID", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VCondition", VCondition);
                command.Parameters.Add("ConditionID", MySqlDbType.Int32);
                command.Parameters["ConditionID"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                string ConditionID = command.Parameters["ConditionID"].Value.ToString();

                connect.Close();

                return ConditionID;
            }
            return "";
        }

        // sets condition name according to condition id
        public string setConditionName(string ConditionID)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("setConditionName", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ConditionID", ConditionID);
                command.Parameters.Add("VCondition", MySqlDbType.String);
                command.Parameters["VCondition"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                string ConditionName = command.Parameters["VCondition"].Value.ToString();

                connect.Close();

                return ConditionName;
            }
            return "";
        }

        // sets package name according to package id
        public string setPackageName(string PackageID)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("setPackageName", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PackageID", PackageID);
                command.Parameters.Add("PackageName", MySqlDbType.String);
                command.Parameters["PackageName"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                string ConditionName = command.Parameters["PackageName"].Value.ToString();

                connect.Close();

                return ConditionName;
            }
            return "";
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
        //The getProduct function gets the products from the database and will be used to display the data in the PRoduct DataGridView.
        public DataTable getProduct()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand vpt = new MySqlCommand("Select * From Product", connect);
                MySqlDataAdapter sda = new MySqlDataAdapter(vpt);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                connect.Close();
                return dt;

            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }
        }

        //The updateProduct function will be used to update the products in the database.
        public string updateProduct(string Name, double Price, int Availability, double Preformance, int coverLevel, int Promotion)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (Preformance >= 0 || Preformance <= 100)
            {
                if (Name != "" && Name.Length <= 20)
                {
                    if (Price >= 0)
                    {
                        if (coverLevel >= 0 && coverLevel <= 11)
                        {
                            connect.Open();
                            MySqlCommand sql_cmnd = new MySqlCommand("updateProduct", connect);
                            sql_cmnd.CommandType = CommandType.StoredProcedure;
                            sql_cmnd.Parameters.AddWithValue("@PName", Name);
                            sql_cmnd.Parameters.AddWithValue("@PPrice", Price);
                            sql_cmnd.Parameters.AddWithValue("@PAvailability", Availability);
                            sql_cmnd.Parameters.AddWithValue("@PPerformance", Preformance);
                            sql_cmnd.Parameters.AddWithValue("@CLevel", coverLevel);
                            sql_cmnd.Parameters.AddWithValue("@PPromotion", Promotion);

                            int Row = sql_cmnd.ExecuteNonQuery();

                            if (Row > 0)
                            {
                                connect.Close();
                                return $"Product with name {Name} was updated";
                            }
                            else
                            {
                                connect.Close();
                                return $"Product with name {Name} was not updated";
                            }
                        }
                        else
                        {
                            connect.Close();
                            return "Please enter a valid Cover level. Must be between 1 and 11.";
                        }
                    }
                    else
                    {
                        return "Please enter a valid Price.";
                    }
                }
                else
                {
                    return "Please enter a valid Name.";
                }

            }
            else
            {
                return "Please enter a valid Precentage for the Preformance of the product.";
            }
        }

        //The addProduct function will be used to add a new product into the Database.
        public string addProduct(string Name, double Price, int Availability, double Preformance, int coverLevel, int Promotion)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (Preformance >= 0 || Preformance <= 100)
            {
                if (Name != "" && Name.Length <= 20)
                {
                    if (Price >= 0)
                    {
                        if (coverLevel >= 0 && coverLevel <= 11)
                        {
                            connect.Open();
                            MySqlCommand sql_cmnd = new MySqlCommand("insertProduct", connect);
                            sql_cmnd.CommandType = CommandType.StoredProcedure;
                            sql_cmnd.Parameters.AddWithValue("@PName", Name);
                            sql_cmnd.Parameters.AddWithValue("@PPrice", Price);
                            sql_cmnd.Parameters.AddWithValue("@Avial", Availability);
                            sql_cmnd.Parameters.AddWithValue("@PPerformance", Preformance);
                            sql_cmnd.Parameters.AddWithValue("@CLevel", coverLevel);
                            sql_cmnd.Parameters.AddWithValue("@PPromotion", Promotion);
                            int Row = sql_cmnd.ExecuteNonQuery();
                            if (Row > 0)
                            {
                                connect.Close();
                                return "Product with the name " + Name + " was added to the database.";
                            }
                            else
                            {
                                connect.Close();
                                return $"Product with name {Name} does not exist.";
                            }
                        }
                        else
                        {
                            connect.Close();
                            return "Please enter a valid Cover level. Must be between 1 and 11.";
                        }
                    }
                    else
                    {
                        return "Please enter a valid Price.";
                    }
                }
                else
                {
                    return "Please enter a valid Name.";
                }

            }
            else
            {
                return "Please enter a valid Precentage for the Preformance of the product.";
            }
        }

        //The deleteProduct function will be used to delete a product out of the database using the ProductName.
        public string deleteProduct(string Name)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            connect.Open();

            if (Name != "" && Name.Length <= 20)
            {
                MySqlCommand command = new MySqlCommand("deleteProduct", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PName", Name);

                int Row = command.ExecuteNonQuery();
                if (Row >= 0)
                {
                    connect.Close();
                    return "Deleted details of Product with the Name: " + Name + ".";
                }
                else
                {
                    connect.Close();
                    return $"Product with name {Name} does not exist.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a valid Product Name for the record to be deleted.";
            }
        }

        //The getProviderS function gets the Provider from the database and will be used to display the data in the Provider DataGridView.
        public DataTable getProvider()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand vpt = new MySqlCommand("Select * From Provider", connect);
                MySqlDataAdapter sda = new MySqlDataAdapter(vpt);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                connect.Close();
                return dt;

            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }
        }

        //updateProvider will be used to update the specified Provider in the database.
        public string updateProvider(string PName, int Status, string Agreement, string Contact)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (PName != "" && PName.Length <= 100)
            {
                if (Agreement != "" && Agreement.Length <= 100)
                {
                    if (Contact.Length == 10)
                    {
                        connect.Open();
                        MySqlCommand sql_cmnd = new MySqlCommand("updateProvider", connect);
                        sql_cmnd.CommandType = CommandType.StoredProcedure;
                        sql_cmnd.Parameters.AddWithValue("@PName", PName);
                        sql_cmnd.Parameters.AddWithValue("@PStatus", Status);
                        sql_cmnd.Parameters.AddWithValue("@PAgreement", Agreement);
                        sql_cmnd.Parameters.AddWithValue("@PContact", Contact);
                        int Row = sql_cmnd.ExecuteNonQuery();
                        if (Row > 0)
                        {
                            connect.Close();
                            return "Provider with the name " + PName + " was updated in the database.";
                        }
                        else
                        {
                            connect.Close();
                            return "Provider with the name " + PName + " was not updated in the database.";
                        }
                    }
                    else
                    {
                        connect.Close();
                        return "Please enter a Valid contact number.";
                    }
                }
                else
                {
                    connect.Close();
                    return "Please enter a Valid Agreement.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a Valid Name.";
            }
        }

        //addProvider will be able to add a new provider to the database.
        public string addProvider(string PName, int Status, string Agreement, string Contact)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (PName != "" && PName.Length <= 100)
            {
                if (Agreement != "" && Agreement.Length <= 100)
                {
                    if (Contact.Length == 10)
                    {
                        connect.Open();
                        MySqlCommand sql_cmnd = new MySqlCommand("insertProvider", connect);
                        sql_cmnd.CommandType = CommandType.StoredProcedure;
                        sql_cmnd.Parameters.AddWithValue("@PName", PName);
                        sql_cmnd.Parameters.AddWithValue("@PStatus", Status);
                        sql_cmnd.Parameters.AddWithValue("@PAgreement", Agreement);
                        sql_cmnd.Parameters.AddWithValue("@PContact", Contact);
                        int Row = sql_cmnd.ExecuteNonQuery();
                        if (Row > 0)
                        {
                            connect.Close();
                            return "Provider with the name " + PName + " was added to the database.";
                        }
                        else
                        {
                            connect.Close();
                            return "Provider with the name " + PName + " was not added to the database.";
                        }
                    }
                    else
                    {
                        connect.Close();
                        return "Please enter a Valid contact number.";
                    }
                }
                else
                {
                    connect.Close();
                    return "Please enter a Valid Agreement.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a Valid Name.";
            }

        }

        //The deleteProduct function will be used to delete a product out of the database using the ProductName.
        public string deleteProvider(string Name)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            connect.Open();

            if (Name != "")
            {
                MySqlCommand command = new MySqlCommand("deleteProvider", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PName", Name);

                int Row = command.ExecuteNonQuery();
                if (Row >= 0)
                {
                    connect.Close();
                    return "Deleted details of Provider with the Name: " + Name + ".";
                }
                else
                {
                    connect.Close();
                    return $"Provider with name {Name} does not exist.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter the Product Name you want to delete.";
            }
        }

        //The getProviderS function gets the Provider from the database and will be used to display the data in the Provider DataGridView.
        public DataTable getUser()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand vpt = new MySqlCommand("Select * From Staff", connect);
                MySqlDataAdapter sda = new MySqlDataAdapter(vpt);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                connect.Close();
                return dt;

            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }
        }

        //updateProvider will be used to update the specified Provider in the database.
        public string updateUser(string name, string surname, string contact, string ID, string username, string password, int clearance)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (ID.Length == 13)
            {
                if (name != "" && name.Length <= 50)
                {
                    if (surname != "" && surname.Length <= 150)
                    {
                        if (contact.Length == 10)
                        {
                            if (username != "" && username.Length <= 50)
                            {
                                if (password != "" && password.Length <= 100)
                                {
                                    connect.Open();
                                    MySqlCommand sql_cmnd = new MySqlCommand("updateUser", connect);
                                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                                    sql_cmnd.Parameters.AddWithValue("@EName", name);
                                    sql_cmnd.Parameters.AddWithValue("@SName", surname);
                                    sql_cmnd.Parameters.AddWithValue("@EContact", contact);
                                    sql_cmnd.Parameters.AddWithValue("@EID", username);
                                    sql_cmnd.Parameters.AddWithValue("@UName", password);
                                    sql_cmnd.Parameters.AddWithValue("@UPassword", clearance);
                                    sql_cmnd.Parameters.AddWithValue("@UClearance", ID);

                                    int Row = sql_cmnd.ExecuteNonQuery();
                                    if (Row > 0)
                                    {
                                        connect.Close();
                                        return "User with the ID " + ID + " was updated in the database.";
                                    }
                                    else
                                    {
                                        connect.Close();
                                        return $"The User with the ID {ID} does not exist.";
                                    }
                                }
                                else
                                {
                                    connect.Close();
                                    return "Please enter a valid password";
                                }
                            }
                            else
                            {
                                return "Please enter a valid username.";
                            }
                        }
                        else
                        {
                            return "Please enter a valid contact number.";
                        }
                    }
                    else
                    {
                        return "Please enter a valid surname.";
                    }
                }
                else
                {
                    return "Please enter a valid Name.";
                }
            }
            else
            {
                return "Please enter a valid ID.";
            }
        }

        //addUser will be able to add a new User to the database.
        public string addUser(string name, string surname, string contact, string ID, string username, string password, int clearance)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (ID.Length == 13)
            {
                if (name != "" && name.Length <= 50)
                {
                    if (surname != "" && surname.Length <= 150)
                    {
                        if (contact.Length == 10)
                        {
                            if (username != "" && username.Length <= 50)
                            {
                                if (password != "" && password.Length <= 100)
                                {
                                    connect.Open();
                                    MySqlCommand sql_cmnd = new MySqlCommand("inserUser", connect);
                                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                                    sql_cmnd.Parameters.AddWithValue("@EName", name);
                                    sql_cmnd.Parameters.AddWithValue("@SName", surname);
                                    sql_cmnd.Parameters.AddWithValue("@UContact", contact);
                                    sql_cmnd.Parameters.AddWithValue("@UID", ID);
                                    sql_cmnd.Parameters.AddWithValue("@UName", username);
                                    sql_cmnd.Parameters.AddWithValue("@UPassword", password);
                                    sql_cmnd.Parameters.AddWithValue("@UClearance", clearance);
                                    int Row = sql_cmnd.ExecuteNonQuery();
                                    if (Row > 0)
                                    {
                                        connect.Close();
                                        return "User with the ID " + ID + " was added to the database.";
                                    }
                                    else
                                    {
                                        connect.Close();
                                        return $"The User with the ID {ID} does not exist.";
                                    }
                                }
                                else
                                {
                                    connect.Close();
                                    return "Please enter a valid password";
                                }
                            }
                            else
                            {
                                return "Please enter a valid username.";
                            }
                        }
                        else
                        {
                            return "Please enter a valid contact number.";
                        }
                    }
                    else
                    {
                        return "Please enter a valid surname.";
                    }
                }
                else
                {
                    return "Please enter a valid Name.";
                }
            }
            else
            {
                return "Please enter a valid ID.";
            }
        }

        //The deleteUser function will be used to delete a User out of the database using the EmployeeID.
        public string deleteUser(string ID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            connect.Open();

            if (ID.Length == 13)
            {
                MySqlCommand command = new MySqlCommand("deleteUser", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", ID);

                int Row = command.ExecuteNonQuery();
                if (Row >= 0)
                {
                    connect.Close();
                    return "Deleted details of User with the ID: " + ID + ".";
                }
                else
                {
                    connect.Close();
                    return $"User with ID {ID} does not exist.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter the User ID you want to delete.";
            }
        }

        //getTreatments will be used to display all the Treatments before search.
        public DataTable getTreatments()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand vpt = new MySqlCommand("Select * From Treatments", connect);
                MySqlDataAdapter sda = new MySqlDataAdapter(vpt);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                connect.Close();
                return dt;
            }
            else
            {
                MessageBox.Show("Returns a null");
                DataTable dt = new DataTable();
                return dt;
            }
        }

        //getCondition will get the Conditions data and display it in the Data grid view.
        public DataTable getCondition()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand vpt = new MySqlCommand("Select * From conditions", connect);
                MySqlDataAdapter sda = new MySqlDataAdapter(vpt);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                connect.Close();
                return dt;
            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }
        }

        //updateConditions will be used to update the specified Conditions in the database.
        public string updateCondition(string Name, string NewName)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (Name != "" && Name.Length <= 150)
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("updateCondition", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@CName", Name);
                sql_cmnd.Parameters.AddWithValue("@NewName", NewName);

                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    return "Condition with the Name " + Name + " was updated in the database.";
                }
                else
                {
                    connect.Close();
                    return $"The Condition with the Name {Name} does not exist.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a valid Condition Name to update the record.";
            }
        }

        //addConditions will be able to add a new Conditions to the database.
        public string addCondtion(string name)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (name != "" && name.Length <= 150)
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("addCondition", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@CName", name);
                int Row = sql_cmnd.ExecuteNonQuery();
                if (Row > 0)
                {
                    connect.Close();
                    return "Condition with the Name " + name + " was added to the database.";
                }
                else
                {
                    connect.Close();
                    return $"The Condition with the Name {name} does not exist.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a valid Condition Name to insert the record.";
            }
        }

        //The deleteConditions function will be used to delete a Conditions out of the database using the ConditionName.
        public string deleteCondition(string Name)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            connect.Open();

            if (Name != "" && Name.Length <= 150)
            {
                MySqlCommand command = new MySqlCommand("deleteCondition", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CName", Name);

                int Row = command.ExecuteNonQuery();
                if (Row >= 0)
                {
                    connect.Close();
                    return "Deleted details of Condition with the Name: " + Name + ".";
                }
                else
                {
                    connect.Close();
                    return $"Condition with Name {Name} does not exist.";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a valid Condition Name to delete the record.";
            }
        }

        public List<int> getAccountIDs()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            List<int> IDs = new List<int>();
            MySqlCommand GetIDs = new MySqlCommand($"Select * From account", connect);
            connect.Open();
            MySqlDataReader reader = GetIDs.ExecuteReader();

            while (reader.Read())
            {
                int ID = int.Parse(reader[0].ToString());
                IDs.Add(ID);
            }

            return IDs;
        }

        public List<double> getPerformance(List<int> IDs)
        {
            List<double> Preformance = new List<double>();
            int accExists = 0;

            MySqlConnection connect = new MySqlConnection(conn);
            connect.Open();

            MySqlCommand GetRows = new MySqlCommand($"Select Count(*) From account", connect);
            double Row = int.Parse(GetRows.ExecuteScalar().ToString());

            connect.Close();

            foreach (var item in IDs)
            {
                connect.Open();
                MySqlCommand SUPERQUERY = new MySqlCommand($"Select Count(*) From account Where account.Package_ID = {item}", connect);

                accExists = int.Parse(SUPERQUERY.ExecuteScalar().ToString());

                double percentComplete = (accExists / Row) * 100;
                Preformance.Add(percentComplete);

                connect.Close();
            }

            return Preformance;
        }

        //updatePrecentages will be used to update the Precentages in the database.
        public void updatePrecentages(List<int> IDs, List<double> Preformance)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            int counter = 0;
            connect.Open();
            int row = 0;
            foreach (var ID in IDs)
            {
                MySqlCommand command = new MySqlCommand("updatePercentages", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PID", ID);
                command.Parameters.AddWithValue("@ProPerformance", Preformance[counter]);
                row = command.ExecuteNonQuery();
                counter++;
            }
        }

        // gets all accounts for the dgv
        public DataTable getAccount()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand vpt = new MySqlCommand("Select Account_ID, Holder_Key, Holder_ID, Holder_Cell, Package_ID From account", connect);
                MySqlDataAdapter sda = new MySqlDataAdapter(vpt);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                connect.Close();
                return dt;

            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }
        }

        //gets all dependants for the dgv
        public DataTable getDependants()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand vpt = new MySqlCommand("Select * From dependants", connect);
                MySqlDataAdapter sda = new MySqlDataAdapter(vpt);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                connect.Close();
                return dt;

            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }
        }

        //gets all dependantconditions for the dgv
        public DataTable getDependantCondition()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand vpt = new MySqlCommand("Select dependantcondition.Dependant_ID, dependantcondition.Condition_ID, conditions.Condition From dependantcondition INNER JOIN conditions ON dependantcondition.Condition_ID = conditions.Condition_ID", connect);
                MySqlDataAdapter sda = new MySqlDataAdapter(vpt);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                connect.Close();
                return dt;

            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }
        }

        public List<int> getProdcutIDs()
        {
            MySqlConnection connect = new MySqlConnection(conn);
            List<int> IDs = new List<int>();
            MySqlCommand GetIDs = new MySqlCommand($"Select * From product", connect);
            connect.Open();
            MySqlDataReader reader = GetIDs.ExecuteReader();

            while (reader.Read())
            {
                int ID = int.Parse(reader[0].ToString());
                IDs.Add(ID);
            }

            return IDs;
        }

        public List<double> checkPromotion(List<int> IDs)
        {
            List<double> myList = new List<double>();
            bool CheckingChecked;
            int CheckingPrice;

            MySqlConnection connect = new MySqlConnection(conn);
            connect.Open();

            foreach (var item in IDs)
            {
                MySqlCommand CheckPrice = new MySqlCommand($"Select Price From product Where product.package_ID = {item}", connect);

                CheckingPrice = int.Parse(CheckPrice.ExecuteScalar().ToString());

                MySqlCommand CheckChecked = new MySqlCommand($"Select Price From product Where product.package_ID = {item}", connect);
                if (CheckingChecked = bool.Parse(CheckChecked.ExecuteScalar().ToString()))
                {
                    double newPrice = CheckingPrice * 0.8;
                    myList.Add(newPrice);
                }
            }

            connect.Close();
            return myList;
        }

        //updatePrecentages will be used to update the Precentages in the database.
        public void updateProductPromotion(List<int> IDs, List<double> myList)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            int counter = 0;
            connect.Open();
            int row = 0;
            foreach (var ID in IDs)
            {
                MySqlCommand command = new MySqlCommand("updatePromotion", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PID", ID);
                command.Parameters.AddWithValue("@NewPrice", myList[counter]);
                row = command.ExecuteNonQuery();
                counter++;
            }
        }

        //deletes account
        public string deleteAccount(string HolderID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            connect.Open();

            if (HolderID != "" && HolderID.Length == 13)
            {
                MySqlCommand command = new MySqlCommand("deleteAccount", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@HolderID", HolderID);

                int Row = command.ExecuteNonQuery();
                if (Row >= 0)
                {
                    connect.Close();
                    return "Deleted account with ID: " + HolderID + ".";
                }
                else
                {
                    connect.Close();
                    return $"Failed to delete account with ID {HolderID}";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a valid ID to delete the record.";
            }
        }

        //deletes dependant
        public string deleteDependant(string DependantID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            connect.Open();

            if (DependantID != "" && DependantID.Length == 13)
            {
                MySqlCommand command = new MySqlCommand("deleteDependant", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DependantID", DependantID);

                int Row = command.ExecuteNonQuery();
                if (Row >= 0)
                {
                    connect.Close();
                    return "Deleted dependant with ID: " + DependantID + ".";
                }
                else
                {
                    connect.Close();
                    return $"Failed to delete dependant with ID {DependantID}";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a valid ID to delete the record.";
            }
        }
        //deletes DependentCondition
        public string deleteDependentCondition(string DependantID, int ConditionID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            connect.Open();

            if (DependantID != "" && DependantID.Length == 13)
            {
                MySqlCommand command = new MySqlCommand("deleteDependentCondition", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DependantID", DependantID);
                command.Parameters.AddWithValue("@ConditionID", ConditionID);

                int Row = command.ExecuteNonQuery();
                if (Row >= 0)
                {
                    connect.Close();
                    return "Deleted condition from dependant with ID: " + DependantID + ".";
                }
                else
                {
                    connect.Close();
                    return $"Failed to delete condition from dependant with ID {DependantID}";
                }
            }
            else
            {
                connect.Close();
                return "Please enter a valid ID to delete the record.";
            }
        }
    }

}
