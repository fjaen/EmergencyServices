using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Hospital
    {   

        public Hospital() {
            assigned_calls = new List<EmergencyCall>();
            supported_specialities = new List<Deployment>();
            owned_ambulances = new List<HospitalBased>();
        }
        // Constructor relaxed because of 1-1 relationship
        public Hospital(string address, double lat, double longit, string name):this()
        {
            
            Address = address;
            Latitude = lat;
            Longitude = longit;
            Name = name;

        }
    }
}
