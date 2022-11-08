using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa3
{
    internal class Staff
    {
        private string name;
        private string surname;
        private string contact;
        private string iD;
        private string username;
        private string password;
        private int clearance;

        public Staff(string name, string surname, string contact, string iD, string username, string password, int clearance)
        {
            Name = name;
            Surname = surname;
            Contact = contact;
            ID = iD;
            Username = username;
            Password = password;
            Clearance = clearance;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Contact { get => contact; set => contact = value; }
        public string ID { get => iD; set => iD = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Clearance { get => clearance; set => clearance = value; }
    }
}
