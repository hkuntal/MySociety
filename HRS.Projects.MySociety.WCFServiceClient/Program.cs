using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRS.Projects.MySociety.WCFServiceClient.ResidentSvcReference;

namespace HRS.Projects.MySociety.WCFServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var objResidentSvcClient = new ResidentSvcClient("BasicHttpBinding_IResidentSvc");
            var a = objResidentSvcClient.GetFlatDetails(1);
            Console.WriteLine(a.ToArray());

            TestExceptionFromWcfService(objResidentSvcClient);
            Console.ReadLine();
        }

        private static void TestExceptionFromWcfService(ResidentSvcClient objResidentSvcClient)
        {
// Test the exception
            try
            {
                var result = objResidentSvcClient.TestException();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
