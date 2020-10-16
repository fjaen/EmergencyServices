using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class HospitalBased:Ambulance
    {

        
        public HospitalBased(string eq_type, double lat, double longit, int reg_num, Hospital hosp) : base(eq_type, lat, longit, reg_num)
        {
            hospital = hosp;
        }
    }
}
