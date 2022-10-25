using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genisis
{
    class Product
    {
        private string packageName;
        private double packagePrice;
        private bool availability;
        private int packageID;
        private double preformance;
        private int coverLevel;
        private bool promotion;

        public Product(string packageName, double packagePrice, bool availability, int packageID, double preformance, int coverLevel, bool promotion)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
            this.availability = availability;
            this.packageID = packageID;
            this.preformance = preformance;
            this.coverLevel = coverLevel;
            this.promotion = promotion;
        }

        public string getPackageName()
        {
            return packageName;
        }

        public void setPackageName(string packageName)
        {
            this.packageName = packageName;
        }

        public double getPackagePrice()
        {
            return packagePrice;
        }

        public void setPackagePrice(double packagePrice)
        {
            this.packagePrice = packagePrice;
        }

        public bool isAvailability()
        {
            return availability;
        }

        public void setAvailability(bool availability)
        {
            this.availability = availability;
        }

        public int getPackageID()
        {
            return packageID;
        }

        public void setPackageID(int packageID)
        {
            this.packageID = packageID;
        }

        public double getPreformance()
        {
            return preformance;
        }

        public void setPreformance(double preformance)
        {
            this.preformance = preformance;
        }

        public int getCoverLevel()
        {
            return coverLevel;
        }

        public void setCoverLevel(int coverLevel)
        {
            this.coverLevel = coverLevel;
        }

        public bool getPromotion()
        {
            return promotion;
        }

        public void setPromotion(bool promotion)
        {
            this.promotion = promotion;
        }

        private static string displayProduction(string packageName)
        {

            return packageName;
        }

        private static void createPackage()
        {

        }

        private static string displayLevel(string coverLevel)
        {

            return coverLevel;
        }
    }
}
