using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservice.asmx
{    
    [WebService(Name = "Vehicle Tracking System")]

    public class VehicleTrackingService : System.Web.Services.WebService
    {
        [WebMethod]
        public string VehicleTrackingChecksum()
        {
            return "Vehicle Tracking System is active.";
        }
                
        [WebMethod]
        public int GetTutorialService(string Vehicle)
        {
            string TutorialName = "Web Services";
            return TutorialName;
        }
    }
}
