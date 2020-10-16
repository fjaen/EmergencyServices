using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class EmergencyCallService
    {
        public virtual ICollection<Ambulance> ambulances
        {
            get;
            set;
        }

        public virtual ICollection<Hospital> hospitals
        {
            get;
            set;
        }
        public virtual ICollection<EmergencyCall> calls
        {
            get;
            set;
        }

}
}
