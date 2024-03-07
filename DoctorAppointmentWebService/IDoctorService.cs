using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentWebService
{
    [ServiceContract]
    public interface IDoctorService
    {
        [OperationContract]
        List<Doctor> GetDoctors();

        [OperationContract]
        Doctor GetDoctorById(int doctorId);

        [OperationContract]
        void AddDoctor(Doctor doctor);

        [OperationContract]
        void UpdateDoctor(Doctor doctor);

        [OperationContract]
        void DeleteDoctor(int doctorId);

        [OperationContract]
        int GetTotalDoctors();
    }

    [DataContract]
    public class Doctor
    {
        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Specialty { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Phone { get; set; }
    }
}
