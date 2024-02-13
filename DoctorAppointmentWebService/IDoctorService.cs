using System;
using System.Collections.Generic;
using System.Linq;
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
    }

    // Define the Doctor entity class here or in a separate file
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        // Add other properties as needed
    }
}
