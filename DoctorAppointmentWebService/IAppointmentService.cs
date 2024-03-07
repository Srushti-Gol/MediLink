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
        List<Appointment> GetDoctorAppointments(int doctorId);
        [OperationContract]
        List<Appointment> GetPatientAppointments(int patientId);

        [OperationContract]
        int GetTotalAppointments();

        [OperationContract]
        int GetActiveAppointments();

        [OperationContract]
        int GetCanceledAppointments();

        [OperationContract]
        int GetCompletedAppointments();

        [OperationContract]
        List<Doctor> GetDoctors();

        [OperationContract]
        List<Patient> GetPatients();

        [OperationContract]
        List<Appointment> GetAllAppointments();

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
            public string DoctorName { get; set; }

            [DataMember]
            public string PatientName { get; set; }

            [DataMember]
            public string Status { get; set; }
            [DataMember]    
            public DateTime AppointmentDateTime { get; set; }
            [DataMember]
            public int StatusID { get; set; }
        }
}