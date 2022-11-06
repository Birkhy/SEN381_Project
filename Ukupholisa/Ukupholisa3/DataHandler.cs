﻿using Genisis;
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
        //Adds account to database and returns a bool.
        public bool AddAccount(int AccountID, string HolderKey, string HolderID, string HolderCell, int PackageID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (HolderKey != "" && HolderID != "" && HolderCell != "")
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
                MessageBox.Show("Please enter all required data");
                connect.Close();
                return false;
            }
        }

        //Adds dependant to the database
        public bool AddDependant(string DependantID, int AccountID, string DependantName, string DependantSurname, DateTime DOB, string Sex)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (DependantID != "" && DependantName != "" && DependantSurname != "" && Sex != "")
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
                MessageBox.Show("Please enter all required data");
                connect.Close();
                return false;
            }
        }

        public bool AddDependantCondition(string DependantID, int ConditionID)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (DependantID != "")
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("AddDependantCondition", connect);
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
                MessageBox.Show("Please enter all required data");
                connect.Close();
                return false;
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
        public int setConditionID(string Condition)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            int PackageID = 0;
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand spi = new MySqlCommand("setConditionID", connect);
                spi.CommandType = CommandType.StoredProcedure;
                spi.Parameters.AddWithValue("@VCondition", Condition);



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
                return dt;

            }
            else
            {
                MessageBox.Show("Returns a null");
                return null;
            }


        }

        //The getProduct function gets the products from the database and will be used to display the data in the PRoduct DataGridView.
        public List<Product> getProduct()
        {
            List<Product> allProducts = new List<Product>();
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("getProduct", connect);
                command.CommandType = CommandType.StoredProcedure;



                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allProducts.Add(new Product(reader[0].ToString(), double.Parse(reader[1].ToString()), int.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), int.Parse(reader[4].ToString()), int.Parse(reader[4].ToString())));
                    }
                }
            }
            connect.Close();
            return allProducts;
        }

        //The updateProduct function will be used to update the products in the database.
        public string updateProduct(string Name, double Price, int Availability, double Preformance, int coverLevel, int Promotion)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (Preformance >= 0 || Preformance <= 100)
            {
                if (Name != "" && Price >= 0 && coverLevel >= 0)
                {
                    connect.Open();
                    MySqlCommand sql_cmnd = new MySqlCommand("updateProducts", connect);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                    sql_cmnd.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = Name;
                    sql_cmnd.Parameters.AddWithValue("@PPrice", SqlDbType.Decimal).Value = Price;
                    sql_cmnd.Parameters.AddWithValue("@PAvailability", SqlDbType.Binary).Value = Availability;
                    sql_cmnd.Parameters.AddWithValue("@PPreformance", SqlDbType.Int).Value = Preformance;
                    sql_cmnd.Parameters.AddWithValue("@CLevel", SqlDbType.Int).Value = coverLevel;
                    sql_cmnd.Parameters.AddWithValue("@PPromotion", SqlDbType.Binary).Value = Promotion;

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
                    return "Please enter all the needed data for the record to be updated.";
                }
            }
            else
            {
                return "Please make sure you enter a valid precentage for the preformance of the product.";
            }
        }

        //The addProduct function will be used to add a new product into the Database.
        public string addProduct(string Name, double Price, int Availability, double Preformance, int coverLevel, int Promotion)
        {
            MySqlConnection connect = new MySqlConnection(conn);

            if (Preformance >= 0 || Preformance <= 100)
            {
                if (Name != "" && Price >= 0 && coverLevel >= 0)
                {
                    connect.Open();
                    MySqlCommand sql_cmnd = new MySqlCommand("insertProduct", connect);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                    sql_cmnd.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = Name;
                    sql_cmnd.Parameters.AddWithValue("@PPrice", SqlDbType.Decimal).Value = Price;
                    sql_cmnd.Parameters.AddWithValue("@PAvailability", SqlDbType.Binary).Value = Availability;
                    sql_cmnd.Parameters.AddWithValue("@PPreformance", SqlDbType.Int).Value = Preformance;
                    sql_cmnd.Parameters.AddWithValue("@CLevel", SqlDbType.Int).Value = coverLevel;
                    sql_cmnd.Parameters.AddWithValue("@PPromotion", SqlDbType.Binary).Value = Promotion;
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
                    return "Please enter all required data to update the product";
                }
            }
            else
            {
                return "Please make sure you enter a valid precentage for the preformance of the product.";
            }
        }

        //The deleteProduct function will be used to delete a product out of the database using the ProductName.
        public string deleteProduct(string Name)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();

            if (Name != "")
            {
                SqlCommand command = new SqlCommand("deleteProduct", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = Name;

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
                return "Please enter the Product Name you want to delete.";
            }
        }

        //The getProviderS function gets the Provider from the database and will be used to display the data in the Provider DataGridView.
        public List<Provider> getProvider()
        {
            List<Provider> allProviders = new List<Provider>();
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("getProvider", connect);
                command.CommandType = CommandType.StoredProcedure;



                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allProviders.Add(new Provider(reader[0].ToString(), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString()));
                    }
                }
            }
            connect.Close();
            return allProviders;
        }

        //updateProvider will be used to update the specified Provider in the database.
        public string updateProvider(string PName, int Status, string Agreement, string Contact)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (PName != "" && Agreement != "" && Contact != "")
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("updateProduct", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = PName;
                sql_cmnd.Parameters.AddWithValue("@PPrice", SqlDbType.Binary).Value = Status;
                sql_cmnd.Parameters.AddWithValue("@PAvailability", SqlDbType.NVarChar).Value = Agreement;
                sql_cmnd.Parameters.AddWithValue("@PPreformance", SqlDbType.NVarChar).Value = Contact;
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
                return "Please enter all required data to update the Provider";
            }
        }

        //addProvider will be able to add a new provider to the database.
        public string addProvider(string PName, int Status, string Agreement, string Contact)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (PName != "" && Agreement != "" && Contact != "")
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("insertProduct", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = PName;
                sql_cmnd.Parameters.AddWithValue("@PPrice", SqlDbType.Binary).Value = Status;
                sql_cmnd.Parameters.AddWithValue("@PAvailability", SqlDbType.NVarChar).Value = Agreement;
                sql_cmnd.Parameters.AddWithValue("@PPreformance", SqlDbType.NVarChar).Value = Contact;
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
                return "Please enter all required data to update the Provider";
            }
        }

        //The deleteProduct function will be used to delete a product out of the database using the ProductName.
        public string deleteProvider(string Name)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();

            if (Name != "")
            {
                SqlCommand command = new SqlCommand("deleteProvider", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = Name;

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
        public List<Staff> getUser()
        {
            List<Staff> allStaff = new List<Staff>();
            MySqlConnection connect = new MySqlConnection(conn);
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand("getUsers", connect);
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allStaff.Add(new Staff(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString())));
                    }
                }
            }
            connect.Close();
            return allStaff;
        }

        //updateProvider will be used to update the specified Provider in the database.
        public string updateUser(string name, string surname, string contact, string ID, string username, string password, int clearance)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (name != "" && surname != "" && contact != "" && ID != "" && username != "" && password != "")
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("updateUser", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = name;
                sql_cmnd.Parameters.AddWithValue("@PPrice", SqlDbType.NVarChar).Value = surname;
                sql_cmnd.Parameters.AddWithValue("@PAvailability", SqlDbType.NVarChar).Value = contact;
                sql_cmnd.Parameters.AddWithValue("@PPreformance", SqlDbType.NVarChar).Value = username;
                sql_cmnd.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = password;
                sql_cmnd.Parameters.AddWithValue("@PPrice", SqlDbType.Binary).Value = clearance;
                sql_cmnd.Parameters.AddWithValue("@PAvailability", SqlDbType.NVarChar).Value = ID;

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
                return "Please enter all required data to update the specified User.";
            }
        }

        //addUser will be able to add a new User to the database.
        public string addUser(string name, string surname, string contact, string ID, string username, string password, int clearance)
        {
            MySqlConnection connect = new MySqlConnection(conn);
            if (name != "" && surname != "" && contact != "" && ID != "" && username != "" && password != "")
            {
                connect.Open();
                MySqlCommand sql_cmnd = new MySqlCommand("inserUser", connect);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = name;
                sql_cmnd.Parameters.AddWithValue("@PPrice", SqlDbType.NVarChar).Value = surname;
                sql_cmnd.Parameters.AddWithValue("@PAvailability", SqlDbType.NVarChar).Value = contact;
                sql_cmnd.Parameters.AddWithValue("@PPreformance", SqlDbType.NVarChar).Value = username;
                sql_cmnd.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = password;
                sql_cmnd.Parameters.AddWithValue("@PPrice", SqlDbType.Bit).Value = clearance;
                sql_cmnd.Parameters.AddWithValue("@PAvailability", SqlDbType.NVarChar).Value = ID;
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
                return "Please enter all required data to insert the specified User.";
            }
        }

        //The deleteUser function will be used to delete a User out of the database using the EmployeeID.
        public string deleteUser(string ID)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();

            if (ID != "")
            {
                SqlCommand command = new SqlCommand("deleteUser", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PName", SqlDbType.NVarChar).Value = ID;

                int Row = command.ExecuteNonQuery();
                if (Row >= 0)
                {
                    connect.Close();
                    return "Deleted details of Provider with the ID: " + ID + ".";
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
                return null;
            }
        }
    }
}
