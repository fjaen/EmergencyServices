using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Speciality
    {
 
        public Speciality() {
            supportedbyHospital = new List<Deployment>();
            belongs_to = new List<Symptom>();
        }
        //Constructor relaxed because of 1-1 relationship
        public Speciality(string name):this()
        {
            Name = name;          

        }
    }
}
