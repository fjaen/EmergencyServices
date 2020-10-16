using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class EmergencyCallService
    {
  
        public EmergencyCallService()
        {
            ambulances = new List<Ambulance>();
            hospitals = new List<Hospital>();
            calls = new List<EmergencyCall>();
        }
        public EmergencyCallService(Ambulance amb, Hospital hosp):this()
        {
            
            ambulances.Add(amb);
            hospitals.Add(hosp);

          
        }

}
}
