using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa3
{
    internal class Accounts
    {
        private int accountID;
        private int holderKey;
        private string holderID;
        private string holderCell;
        private int packageID;

        public Accounts(int accountID, int holderKey, string holderID, string holderCell, int packageID)
        {
            this.accountID = accountID;
            this.holderKey = holderKey;
            this.holderID = holderID;
            this.holderCell = holderCell;
            this.packageID = packageID;
        }

        public int AccountID { get => accountID; set => accountID = value; }
        public int HolderKey { get => holderKey; set => holderKey = value; }
        public string HolderID { get => holderID; set => holderID = value; }
        public string HolderCell { get => holderCell; set => holderCell = value; }
        public int PackageID { get => packageID; set => packageID = value; }
    }
}
