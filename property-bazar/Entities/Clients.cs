using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_bazar.Entities
{
    class Clients
    {
        public int clientId;
        public string clientUserName;
        public string clientPassword;

        public Clients(int clientId, string clientUserName, string clientPassword)
        {
            this.clientId = clientId;
            this.clientUserName = clientUserName;
            this.clientPassword = clientPassword;
        }
    }
}
