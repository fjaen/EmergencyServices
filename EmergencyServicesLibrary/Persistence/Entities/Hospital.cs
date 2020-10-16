using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Hospital
    {
      
        public int Id
        {
            get;
            set;
        }
        public string Name {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public double Latitude
        {
            get;
            set;
        }
        public double Longitude
        {
            get;
            set;
        }

        public virtual ICollection<EmergencyCall> assigned_calls
        {
            get;
            set;
        }
        public virtual ICollection<Deployment> supported_specialities
        {
            get;
            set;
        }
        public virtual ICollection<HospitalBased> owned_ambulances
        {
            get;
            set;
        }

    }
}
