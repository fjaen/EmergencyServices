using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Symptom
    {

        public int Id
        {
            get;
            set;
        }
        public int Severity
        {
            get;
            set;
        }
        public double Duration
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public virtual ICollection<Speciality> specialities
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
