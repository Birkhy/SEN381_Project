using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukupholisa3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Product banana = new Product();
            banana.Availabilty = true;
            banana.Treatments.Add("hahsdi");
            banana.Treatments.Add("asdsa");
            banana.Treatments.Add("hadsgfdghsdi");
            banana.Treatments.Add("hahsaeqwedi");
            banana.Treatments.Add("hahqwewwersdi");

            Console.WriteLine(banana.Treatments[1]);

            string server = "localhost";
            string database = "ukupholisadb";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select Provider_ID from provider, providermedical where providermedical.trt_ID = 4";
            MySqlCommand cmd1 = new MySqlCommand(query,conn);
            MySqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read()) {
                //Console.WriteLine(reader["Provider_ID"]);
                //Console.WriteLine(reader["Provider_Name"]);
                //Console.WriteLine(reader["Provider_Status"]);
                //Console.WriteLine(reader["Agreement"]);
            };

        }
    }
}
