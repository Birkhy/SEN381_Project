using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genisis
{
    class Provider
    {
        public string providerName;
        public bool providerStatus;

        public Provider(string providerName, bool providerStatus)
        {
            this.providerName = providerName;
            this.providerStatus = providerStatus;
        }

        private static string displayProvider(string providerName)
        {
            return providerName;
        }

        private static string displayStatus(string displayStatus)
        {
            return displayStatus;
        }
    }
}
