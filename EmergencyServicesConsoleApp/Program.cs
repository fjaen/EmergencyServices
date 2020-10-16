using System;
using EmergencyServices.Entities;

namespace EmergencyServicesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Objects...");

            //Relationship Hospital-Speciality
            Hospital hosp = new Hospital("Av Sur 48", 22.3, 21.4, "La Fe");
            Speciality speci = new Speciality("Cardiología");
            Deployment dep = new Deployment(3, 24, hosp, speci);
            hosp.supported_specialities.Add(dep);
            speci.supportedbyHospital.Add(dep);

            //Relationship EmergencyCall->Patient


            Patient pat = new Patient("Camino de Vera s/n", 46, "11111111A", 'H', "Javier", "+34666555444", "Jaen");
            EmergencyCall call = new EmergencyCall(new DateTime(2016, 3, 4), 23.5, 22.5, new TimeSpan(12, 12, 45), pat);


            //Relationship Symptom - Speciality
            //Relationship Symptom -> EmergencyCall
            Symptom sy = new Symptom("Taquicardia", 69.5, 3, call, speci);
            speci.belongs_to.Add(sy);

            //Relationship EmergencyCall ->Symptom
            call.symptoms.Add(sy);


            //Relationship HospitalBased - Hospital
            Private private_ambulance = new Private("Ambulancias ISW", "full equiped", 23.5, 22.1, 12345);
            HospitalBased hospital_ambulance = new HospitalBased("full equiped", 20.1, 10.6, 5555, hosp);
            hosp.owned_ambulances.Add(hospital_ambulance);


            //Relationship Hospital - EmergencyCall
            hosp.assigned_calls.Add(call);
            call.hospital = hosp;

            //Relationship EmergencyCall - Ambulance
            call.ambulance = hospital_ambulance;
            hospital_ambulance.assigned_calls.Add(call);

            //Relationship EmergencyCallService -> Ambulance
            //Relationship EmergencyCallService -> Hospital
            //Relationship EmergencyCallService -> EmergencyCall            
            EmergencyCallService emergencyService = new EmergencyCallService(private_ambulance, hosp);
            emergencyService.ambulances.Add(hospital_ambulance);
            emergencyService.calls.Add(call);
            Console.WriteLine("Objects Created...");
        }
    }
}
