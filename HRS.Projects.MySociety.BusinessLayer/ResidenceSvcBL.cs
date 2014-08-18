using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRS.Projects.MySociety.BusinessObjects;
using HRS.Projects.MySociety.DataAccessLayer;
using Bldg = HRS.Projects.MySociety.DataAccessLayer.Bldg;
using Wing = HRS.Projects.MySociety.DataAccessLayer.Wing;

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

        public IList<FlatBO> GetFlats(int societyId)
        {
            var objPersonsDL = new ResidentsSvcDL();
            
            // The data type of flats is DbSet<Flat>
            var flats = objPersonsDL.GetFlats(societyId);
            
            //Return a list of Flats as per the business objects
            IList<FlatBO> fbo = new List<FlatBO>();
            foreach (var f in flats)
            {
                FlatBO a = new FlatBO();
                a.FlatId = f.Id;
                a.FlatName = f.FlatNo;
                a.NoOfResidents = Convert.ToInt32(f.NoOfResidents);
                fbo.Add(a);
            }
            return fbo;
        }
    }
}
