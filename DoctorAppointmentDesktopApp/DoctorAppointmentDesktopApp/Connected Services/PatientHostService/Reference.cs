﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorAppointmentDesktopApp.PatientHostService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/DoctorAppointmentWebService")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PatientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PatientId {
            get {
                return this.PatientIdField;
            }
            set {
                if ((this.PatientIdField.Equals(value) != true)) {
                    this.PatientIdField = value;
                    this.RaisePropertyChanged("PatientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PatientHostService.IPatientService")]
    public interface IPatientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatients", ReplyAction="http://tempuri.org/IPatientService/GetPatientsResponse")]
        DoctorAppointmentDesktopApp.PatientHostService.Patient[] GetPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatients", ReplyAction="http://tempuri.org/IPatientService/GetPatientsResponse")]
        System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.PatientHostService.Patient[]> GetPatientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatientById", ReplyAction="http://tempuri.org/IPatientService/GetPatientByIdResponse")]
        DoctorAppointmentDesktopApp.PatientHostService.Patient GetPatientById(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatientById", ReplyAction="http://tempuri.org/IPatientService/GetPatientByIdResponse")]
        System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.PatientHostService.Patient> GetPatientByIdAsync(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/AddPatient", ReplyAction="http://tempuri.org/IPatientService/AddPatientResponse")]
        void AddPatient(DoctorAppointmentDesktopApp.PatientHostService.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/AddPatient", ReplyAction="http://tempuri.org/IPatientService/AddPatientResponse")]
        System.Threading.Tasks.Task AddPatientAsync(DoctorAppointmentDesktopApp.PatientHostService.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/UpdatePatient", ReplyAction="http://tempuri.org/IPatientService/UpdatePatientResponse")]
        void UpdatePatient(DoctorAppointmentDesktopApp.PatientHostService.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/UpdatePatient", ReplyAction="http://tempuri.org/IPatientService/UpdatePatientResponse")]
        System.Threading.Tasks.Task UpdatePatientAsync(DoctorAppointmentDesktopApp.PatientHostService.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/DeletePatient", ReplyAction="http://tempuri.org/IPatientService/DeletePatientResponse")]
        void DeletePatient(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/DeletePatient", ReplyAction="http://tempuri.org/IPatientService/DeletePatientResponse")]
        System.Threading.Tasks.Task DeletePatientAsync(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetTotalPatients", ReplyAction="http://tempuri.org/IPatientService/GetTotalPatientsResponse")]
        int GetTotalPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetTotalPatients", ReplyAction="http://tempuri.org/IPatientService/GetTotalPatientsResponse")]
        System.Threading.Tasks.Task<int> GetTotalPatientsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPatientServiceChannel : DoctorAppointmentDesktopApp.PatientHostService.IPatientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PatientServiceClient : System.ServiceModel.ClientBase<DoctorAppointmentDesktopApp.PatientHostService.IPatientService>, DoctorAppointmentDesktopApp.PatientHostService.IPatientService {
        
        public PatientServiceClient() {
        }
        
        public PatientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PatientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PatientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PatientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DoctorAppointmentDesktopApp.PatientHostService.Patient[] GetPatients() {
            return base.Channel.GetPatients();
        }
        
        public System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.PatientHostService.Patient[]> GetPatientsAsync() {
            return base.Channel.GetPatientsAsync();
        }
        
        public DoctorAppointmentDesktopApp.PatientHostService.Patient GetPatientById(int patientId) {
            return base.Channel.GetPatientById(patientId);
        }
        
        public System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.PatientHostService.Patient> GetPatientByIdAsync(int patientId) {
            return base.Channel.GetPatientByIdAsync(patientId);
        }
        
        public void AddPatient(DoctorAppointmentDesktopApp.PatientHostService.Patient patient) {
            base.Channel.AddPatient(patient);
        }
        
        public System.Threading.Tasks.Task AddPatientAsync(DoctorAppointmentDesktopApp.PatientHostService.Patient patient) {
            return base.Channel.AddPatientAsync(patient);
        }
        
        public void UpdatePatient(DoctorAppointmentDesktopApp.PatientHostService.Patient patient) {
            base.Channel.UpdatePatient(patient);
        }
        
        public System.Threading.Tasks.Task UpdatePatientAsync(DoctorAppointmentDesktopApp.PatientHostService.Patient patient) {
            return base.Channel.UpdatePatientAsync(patient);
        }
        
        public void DeletePatient(int patientId) {
            base.Channel.DeletePatient(patientId);
        }
        
        public System.Threading.Tasks.Task DeletePatientAsync(int patientId) {
            return base.Channel.DeletePatientAsync(patientId);
        }
        
        public int GetTotalPatients() {
            return base.Channel.GetTotalPatients();
        }
        
        public System.Threading.Tasks.Task<int> GetTotalPatientsAsync() {
            return base.Channel.GetTotalPatientsAsync();
        }
    }
}
