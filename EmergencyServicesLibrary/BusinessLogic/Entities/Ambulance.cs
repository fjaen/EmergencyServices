using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Ambulance
    {


        public Ambulance()
        {
            assigned_calls = new List<EmergencyCall>();
        }

        public Ambulance(string eq_type, double lat, double longit,int reg_num) :this()
        {
            
            EquipmentType = eq_type;
            Latitude = lat;
            Longitude = longit;
            RegistrationNumber = reg_num;
        }
    }
}
