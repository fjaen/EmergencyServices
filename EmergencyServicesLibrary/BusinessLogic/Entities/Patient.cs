using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyServices.Entities
{
    public partial class Patient
    {
 
        public Patient(string address,int age, string dni, char gender, string name, string phone, string srname)
        {
            Address = address;
            Age = age;
            Dni = dni;
            Gender = gender;
            Name = name;
            PhoneNumber = phone;
            Surname = srname;

        }

    }
}
