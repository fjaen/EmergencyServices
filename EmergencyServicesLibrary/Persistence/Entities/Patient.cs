using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Patient
    {
 
        public string Dni{ get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }


    }
}
