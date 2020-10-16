using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class EmergencyCall
    {

        public int Id
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
        public DateTime Date
        {
            get;
            set;
        }
        public TimeSpan Time
        {
            get;
            set;
        }

        public virtual Hospital? hospital
        {
            get;
            set;
        }
        public virtual Ambulance? ambulance
        {
            get;
            set;
        }
        public virtual Patient patient
        {
            get;
            set;
        }
        public virtual ICollection<Symptom> symptoms
        {
            get;
            set;
        }

  
    }
}
