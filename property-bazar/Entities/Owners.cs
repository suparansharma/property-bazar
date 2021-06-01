using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_bazar.Entities
{
    class Owners
    {
        public int ownerId;
        public string ownerUserName;
        public string ownerPassword;

        public Owners(int ownerId, string ownerUserName, string ownerPassword)
        {
            this.ownerId = ownerId;
            this.ownerUserName = ownerUserName;
            this.ownerPassword = ownerPassword;
        }
    }
}
