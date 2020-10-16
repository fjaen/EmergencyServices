using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Deployment
    {

        public Deployment(int floor, int num_emp,Hospital hosp, Speciality sp)
        {
            
            Floor = floor;
            NumEmployees = num_emp;
            hospital = hosp;
            speciality = sp;
        }
    }
}
