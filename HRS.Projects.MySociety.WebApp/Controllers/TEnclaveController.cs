using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HRS.Projects.MySociety.WebApp.MySocietyResidentService;


namespace HRS.Projects.MySociety.WebApp.Controllers
{
    [System.Web.Mvc.Authorize]
    public class TEnclaveController : Controller
    {
        //
        // GET: /TEnclave/

        public ActionResult Index()
        {
            //Get the Flat details from the Wcf service
            var objResidentSvcClient = new ResidentSvcClient("WSHttpBinding_IResidentSvc");
            var flatDtls = objResidentSvcClient.GetFlatDetails(1);
            ViewBag.FlatDetails = flatDtls;
            return View();
        }
        public ActionResult CreateNewFlat()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult CreateNewFlat(int FlatId, string FlatName, int txtNoOfPersons)
        {
            return View();
        }
    }
}
