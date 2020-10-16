using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Private:Ambulance
    {

        public Private(string comp_name,string eq_type, double lat, double longit, int reg_num) 
            : base(eq_type, lat, longit, reg_num)
        {
            CompanyName = comp_name;
        }
    }
}
