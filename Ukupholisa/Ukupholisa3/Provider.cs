using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genisis
{
    class Provider
    {
        private string providerName;
        private int providerStatus;
        private string agreement;
        private string contact;

        public Provider(string providerName, int providerStatus)
        {
            this.ProviderName = providerName;
            this.ProviderStatus = providerStatus;
        }

        public Provider(string providerName, int providerStatus, string Agreement, string Contact)
        {
            this.ProviderName = providerName;
            this.ProviderStatus = providerStatus;
            this.Agreement = Agreement;
            this.Contact = Contact;
        }

        public string ProviderName { get => providerName; set => providerName = value; }
        public int ProviderStatus { get => providerStatus; set => providerStatus = value; }
        public string Agreement { get => agreement; set => agreement = value; }
        public string Contact { get => contact; set => contact = value; }

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
