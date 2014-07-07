using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Projects.MySociety.BusinessObjects
{
    class Society
    {
        public Int16 SocietyId { get; set; }
        public string SocietyName { get; set; }
        public bool IsRegistered { get; set; }
        public string RegistrationInfo { get; set; }

    }
}
