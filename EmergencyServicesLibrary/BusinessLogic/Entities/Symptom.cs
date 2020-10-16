using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Symptom
    {

        public Symptom() {
            specialities = new List<Speciality>();
            calls = new List<EmergencyCall>();
        }

        public Symptom(string descr, double dur, int sever, EmergencyCall call,Speciality spe):this()
        {
            Description = descr;
            Duration = dur;            
            Severity = sever;
            specialities.Add(spe);
            calls.Add(call);
        }
    }
}
