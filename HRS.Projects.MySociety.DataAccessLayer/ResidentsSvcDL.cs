using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Projects.MySociety.DataAccessLayer
{
    public class ResidentsSvcDL
    {
        public IList<Society> GetSocieties()
        {
            using (var db = new MySocietyEntities())
            {
                return db.Societies.ToList();
            }
        }

        public DbSet<Society> GetPersons()
        {
            using (var db = new MySocietyEntities())
            {
                return db.Societies;
            }
        }
        public void AddBuildings(Bldg objBldg)
        {
            using (var db = new MySocietyEntities())
            {
                db.Bldgs.Add(objBldg);
                db.SaveChanges();
            }
        }
        public void AddWings(Wing objWing)
        {
            using (var db = new MySocietyEntities())
            {
                db.Wings.Add(objWing);
                db.SaveChanges();
            }
        }
        public void AddFlats(Flat objFlat)
        {

        }
        public void AddPersons(Person objPerson)
        {

        }
        public DbSet<Flat> GetFlats(int societyId)
        {
            using (var db = new MySocietyEntities())
            {
                return db.Flats;
            }
        }
    }
}
