using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class EmergencyCall
    {


        public EmergencyCall() {
            symptoms = new List<Symptom>();
        }
        //Constructor relaxed because of 1-1 relationship
        public EmergencyCall(DateTime date, double lat, double longit, TimeSpan time, Patient pat):this()
        {
            Date = date;
            Latitude = lat;
            Longitude = longit;         
            Time = time;
            patient = pat;
            ambulance = null;
            hospital = null;
            
        }
    }
}
