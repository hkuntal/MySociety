using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using HRS.Projects.MySociety.BusinessObjects;
using HRS.Projects.MySociety.BusinessLayer;

namespace HRS.Projects.MySociety.WCFServices
{
    class ResidentSvc:IResidentSvc
    {
        public IList<FlatBO> GetFlatDetails(int societyId)
        {
            var objResidenceSvcBL = new ResidenceSvcBL();
            return objResidenceSvcBL.GetFlats(societyId);
        }


        public string TestException()
        {
            // Throw an exception to test how it is handled at the client side
            // Throwing a file not found exception
            try
            {

            
            using (var a = File.Open(@"C:\Hariom\kk\jj\ll.txt",FileMode.Open))
            {
                return a.ReadByte().ToString();
            }
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new FaultException(ex.Message);
            }
            return "File Found";
        }
    }
}
