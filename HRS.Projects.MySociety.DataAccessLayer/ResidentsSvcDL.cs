using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
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
        public IList<Flat> GetFlats(int societyId)
        {
            //var appConfig = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            //string dllConfigData = appConfig.AppSettings.Settings["dllConfigData"].Value;
            //var conn = GetConfig();
            using (var db = new MySocietyEntities())
            {
                return db.Flats.ToList();
            }
        }

        private string GetConfig()
        {

            //Open the configuration file using the dll location

            Configuration myDllConfig =

                   ConfigurationManager.OpenExeConfiguration(this.GetType().Assembly.Location);

            // Get the appSettings section

            AppSettingsSection myDllConfigAppSettings =

                   (AppSettingsSection)myDllConfig.GetSection("appSettings");

            ConnectionStringsSection myDllConfigAppSettings1 =
                
                   (ConnectionStringsSection)myDllConfig.GetSection("connectionStrings");
            


            // return the desired field

            //return myDllConfigAppSettings.Settings["ConnectionString"].Value;
            return myDllConfig.AppSettings.Settings["ConnectionString"].Value;

        }
    }
}
