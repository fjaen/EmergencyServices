using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Speciality
    {
   

        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public virtual ICollection<Deployment> supportedbyHospital
        {
            get;
            set;
        }
        public virtual ICollection<Symptom> belongs_to
        {
            get;
            set;
        }


    }
}
