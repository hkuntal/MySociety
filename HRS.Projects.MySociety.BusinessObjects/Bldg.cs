using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Projects.MySociety.BusinessObjects
{
    public class Bldg
    {
        public Int16 BldgId { get; set; }
        public string Name { get; set; }
        public  Int16 NoOfWings { get; set; }
        public Int16 NoOfFloors { get; set; }
        public string Comment { get; set; }
    }
}
