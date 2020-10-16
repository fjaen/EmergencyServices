using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class HospitalBased:Ambulance
    {
        public virtual Hospital hospital
        {
            get;
            set;
        }
        

    }
}
