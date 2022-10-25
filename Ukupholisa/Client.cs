using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genisis
{
    class Client
    {
        private string firstName;
        private string lastName;
        private string ID;
        private string adress;
        private string cellNumber;
        private string packageName;

        public Client(string firstName, string lastName, string iD, string adress, string cellNumber, string packageName, object p, object p1)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ID = iD;
            this.adress = adress;
            this.cellNumber = cellNumber;
            this.packageName = packageName;
        }

        public Client(string firstName, string lastName, string iD, string adress, string cellNumber, string packageName, object p, object p1, object p2) : this(firstName, lastName, iD, adress, cellNumber, packageName, p, p1)
        {
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string getLastName()
        {
            return lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getID()
        {
            return ID;
        }

        public void setID(string iD)
        {
            ID = iD;
        }

        public string getAdress()
        {
            return adress;
        }

        public void setAdress(string adress)
        {
            this.adress = adress;
        }

        public string getCellNumber()
        {
            return cellNumber;
        }

        public void setCellNumber(string cellNumber)
        {
            this.cellNumber = cellNumber;
        }

        public string getPackageName()
        {
            return packageName;
        }
    }
}
