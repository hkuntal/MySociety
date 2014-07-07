using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRS.Projects.MySociety.DataAccessLayer;

namespace HRS.Projects.MySociety.BusinessLayer
{
    public class ResidenceSvcBL
    {
        public IList<Society> GetSocieties()
        {
            var objPersonsDL = new ResidentsSvcDL();
            return objPersonsDL.GetSocieties();
        }

        public void AddBuildings(Bldg objBldg)
        {
            var objPersonsDL = new ResidentsSvcDL();
            objPersonsDL.AddBuildings(objBldg);
        }
        public void AddWings(Wing objWing)
        {
            try
            {
                var objPersonsDL = new ResidentsSvcDL();
                objPersonsDL.AddWings(objWing);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
        public void AddFlats(Flat objFlat)
        {
            
        }
        public void AddPersons(Person objPerson)
        {
            
        }

        public void GetFlats(int societyId)
        {
            var objPersonsDL = new ResidentsSvcDL();
            objPersonsDL.GetFlats(objBldg);
        }
    }
}
