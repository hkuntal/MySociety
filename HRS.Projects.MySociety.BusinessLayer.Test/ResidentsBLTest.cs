using System;
using System.Collections.Generic;
using System.Data.Entity;
using HRS.Projects.MySociety.DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRS.Projects.MySociety.BusinessLayer;

namespace HRS.Projects.MySociety.BusinessLayer.Test
{
    [TestClass]
    public class ResidentsBLTest
    {
        [TestMethod]
        public void TestGetPersons()
        {
            ResidenceSvcBL objResidenceSvcBL = new ResidenceSvcBL();

            Wing objWing = new Wing();
            objWing.BldgId = 1;
            objWing.Name = "Wing A";
            objWing.Description = "Wing A";
            
            //Constructopn of Flats
            Flat objFlat = new Flat();
            objFlat.FlatNo = "602";
            objFlat.NoOfResidents = 6;
            
            objWing.Flats.Add(objFlat);

            objResidenceSvcBL.AddWings(objWing);
        }
    }
}
