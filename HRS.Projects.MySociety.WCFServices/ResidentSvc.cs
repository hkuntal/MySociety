using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRS.Projects.MySociety.BusinessObjects;
using HRS.Projects.MySociety.BusinessLayer;

namespace HRS.Projects.MySociety.WCFServices
{
    class ResidentSvc:IResidentSvc
    {
        public Flat GetFlatDetails(int societyId)
        {
            var objResidenceSvcBL = new ResidenceSvcBL();
            objResidenceSvcBL.
        }
    }
}
