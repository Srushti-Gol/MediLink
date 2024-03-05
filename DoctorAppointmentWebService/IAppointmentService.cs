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
    public interface IAppointmentService
    {
        [OperationContract]
        void ScheduleAppointment(int doctorId, int patientId, DateTime appointmentDateTime);
        [OperationContract]
        void CancelAppointment(int appointmentId);
        [OperationContract]
        void CompleteAppointment(int appointmentId);
        [OperationContract]
        List<Appointment> GetAllAppointments();
        [OperationContract]
        List<Appointment> GetDoctorAppointments(int doctorId);
        [OperationContract]
        List<Appointment> GetPatientAppointments(int patientId);

        [OperationContract]
        List<Doctor> GetDoctors();

        [OperationContract]
        List<Patient> GetPatients();
    }

    [DataContract]
    public class Appointment
    {
        [DataMember]
        public int AppointmentID { get; set; }
        [DataMember]
        public int DoctorID { get; set; }
        [DataMember]
        public int PatientID { get; set; }
        [DataMember]
        public DateTime AppointmentDateTime { get; set; }
        [DataMember]
        public int StatusID { get; set; }
    }
}