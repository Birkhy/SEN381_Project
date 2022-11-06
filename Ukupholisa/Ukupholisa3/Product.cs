using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa3
{
    internal class Product
    {
        private int packageID;
        private string packageName;
        private double packagePrice;
        private int availabilty;
        private double performance;
        private int coverLevel;
        private int promotion;

        public Product() { }

        public Product(string packageName, double packagePrice, int availabilty, double performance, int coverLevel, int promotion)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
            this.availabilty = availabilty;
            this.performance = performance;
            this.coverLevel = coverLevel;
            this.promotion = promotion;
        }

        public int PackageID { get => packageID; set => packageID = value; }
        public string PackageName { get => packageName; set => packageName = value; }
        public double PackagePrice { get => packagePrice; set => packagePrice = value; }
        public int Availabilty { get => availabilty; set => availabilty = value; }
        public double Performance { get => performance; set => performance = value; }
        public int CoverLevel { get => coverLevel; set => coverLevel = value; }
        public int Promotion { get => promotion; set => promotion = value; }
    }
}
