using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace DoctorAppointmentWebService
{
    [ServiceContract]
    public interface IPatientService
    {
        [OperationContract]
        List<Patient> GetPatients();

        [OperationContract]
        Patient GetPatientById(int patientId);

        [OperationContract]
        void AddPatient(Patient patient);

        [OperationContract]
        void UpdatePatient(Patient patient);

        [OperationContract]
        void DeletePatient(int patientId);

        [OperationContract]
        int GetTotalPatients();
    }

    [DataContract]
    public class Patient
    {
        [DataMember]
        public int PatientId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Phone { get; set; }
    }
}
