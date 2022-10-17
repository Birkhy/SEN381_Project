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
        private bool availabilty;
        private double performance;
        private ArrayList treatments = new ArrayList();
        private int coverLevel;
        private bool promotion;

        public Product() { }

        public Product(int packageID, string packageName, double packagePrice, bool availabilty, double performance, ArrayList treatments, int coverLevel, bool promotion)
        {
            this.packageID = packageID;
            this.packageName = packageName;
            this.packagePrice = packagePrice;
            this.availabilty = availabilty;
            this.performance = performance;
            this.treatments = treatments;
            this.coverLevel = coverLevel;
            this.promotion = promotion;
        }

        public int PackageID { get => packageID; set => packageID = value; }
        public string PackageName { get => packageName; set => packageName = value; }
        public double PackagePrice { get => packagePrice; set => packagePrice = value; }
        public bool Availabilty { get => availabilty; set => availabilty = value; }
        public double Performance { get => performance; set => performance = value; }
        public ArrayList Treatments { get => treatments; set => treatments = value; }
        public int CoverLevel { get => coverLevel; set => coverLevel = value; }
        public bool Promotion { get => promotion; set => promotion = value; }
    }
}
