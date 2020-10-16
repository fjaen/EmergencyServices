using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Deployment
    {
        
        public int Id
        {
            get;
            set;
        }
        
        public int Floor
        {
            get;
            set;
        }
        public int NumEmployees
        {
            get;
            set;
        }

        public virtual Hospital hospital
        {
            get;
            set;
        }
        public virtual Speciality speciality
        {
            get;
            set;
        }

     
    }
}
