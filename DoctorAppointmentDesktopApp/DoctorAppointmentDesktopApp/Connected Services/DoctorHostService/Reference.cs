﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorAppointmentDesktopApp.DoctorHostService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor", Namespace="http://schemas.datacontract.org/2004/07/DoctorAppointmentWebService")]
    [System.SerializableAttribute()]
    public partial class Doctor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DoctorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecialtyField;
        
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
        public int DoctorId {
            get {
                return this.DoctorIdField;
            }
            set {
                if ((this.DoctorIdField.Equals(value) != true)) {
                    this.DoctorIdField = value;
                    this.RaisePropertyChanged("DoctorId");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Specialty {
            get {
                return this.SpecialtyField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecialtyField, value) != true)) {
                    this.SpecialtyField = value;
                    this.RaisePropertyChanged("Specialty");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DoctorHostService.IDoctorService")]
    public interface IDoctorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorsResponse")]
        DoctorAppointmentDesktopApp.DoctorHostService.Doctor[] GetDoctors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorsResponse")]
        System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.DoctorHostService.Doctor[]> GetDoctorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctorById", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorByIdResponse")]
        DoctorAppointmentDesktopApp.DoctorHostService.Doctor GetDoctorById(int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctorById", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorByIdResponse")]
        System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.DoctorHostService.Doctor> GetDoctorByIdAsync(int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/AddDoctor", ReplyAction="http://tempuri.org/IDoctorService/AddDoctorResponse")]
        void AddDoctor(DoctorAppointmentDesktopApp.DoctorHostService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/AddDoctor", ReplyAction="http://tempuri.org/IDoctorService/AddDoctorResponse")]
        System.Threading.Tasks.Task AddDoctorAsync(DoctorAppointmentDesktopApp.DoctorHostService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/UpdateDoctor", ReplyAction="http://tempuri.org/IDoctorService/UpdateDoctorResponse")]
        void UpdateDoctor(DoctorAppointmentDesktopApp.DoctorHostService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/UpdateDoctor", ReplyAction="http://tempuri.org/IDoctorService/UpdateDoctorResponse")]
        System.Threading.Tasks.Task UpdateDoctorAsync(DoctorAppointmentDesktopApp.DoctorHostService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/DeleteDoctor", ReplyAction="http://tempuri.org/IDoctorService/DeleteDoctorResponse")]
        void DeleteDoctor(int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/DeleteDoctor", ReplyAction="http://tempuri.org/IDoctorService/DeleteDoctorResponse")]
        System.Threading.Tasks.Task DeleteDoctorAsync(int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetTotalDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetTotalDoctorsResponse")]
        int GetTotalDoctors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetTotalDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetTotalDoctorsResponse")]
        System.Threading.Tasks.Task<int> GetTotalDoctorsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDoctorServiceChannel : DoctorAppointmentDesktopApp.DoctorHostService.IDoctorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DoctorServiceClient : System.ServiceModel.ClientBase<DoctorAppointmentDesktopApp.DoctorHostService.IDoctorService>, DoctorAppointmentDesktopApp.DoctorHostService.IDoctorService {
        
        public DoctorServiceClient() {
        }
        
        public DoctorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DoctorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DoctorAppointmentDesktopApp.DoctorHostService.Doctor[] GetDoctors() {
            return base.Channel.GetDoctors();
        }
        
        public System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.DoctorHostService.Doctor[]> GetDoctorsAsync() {
            return base.Channel.GetDoctorsAsync();
        }
        
        public DoctorAppointmentDesktopApp.DoctorHostService.Doctor GetDoctorById(int doctorId) {
            return base.Channel.GetDoctorById(doctorId);
        }
        
        public System.Threading.Tasks.Task<DoctorAppointmentDesktopApp.DoctorHostService.Doctor> GetDoctorByIdAsync(int doctorId) {
            return base.Channel.GetDoctorByIdAsync(doctorId);
        }
        
        public void AddDoctor(DoctorAppointmentDesktopApp.DoctorHostService.Doctor doctor) {
            base.Channel.AddDoctor(doctor);
        }
        
        public System.Threading.Tasks.Task AddDoctorAsync(DoctorAppointmentDesktopApp.DoctorHostService.Doctor doctor) {
            return base.Channel.AddDoctorAsync(doctor);
        }
        
        public void UpdateDoctor(DoctorAppointmentDesktopApp.DoctorHostService.Doctor doctor) {
            base.Channel.UpdateDoctor(doctor);
        }
        
        public System.Threading.Tasks.Task UpdateDoctorAsync(DoctorAppointmentDesktopApp.DoctorHostService.Doctor doctor) {
            return base.Channel.UpdateDoctorAsync(doctor);
        }
        
        public void DeleteDoctor(int doctorId) {
            base.Channel.DeleteDoctor(doctorId);
        }
        
        public System.Threading.Tasks.Task DeleteDoctorAsync(int doctorId) {
            return base.Channel.DeleteDoctorAsync(doctorId);
        }
        
        public int GetTotalDoctors() {
            return base.Channel.GetTotalDoctors();
        }
        
        public System.Threading.Tasks.Task<int> GetTotalDoctorsAsync() {
            return base.Channel.GetTotalDoctorsAsync();
        }
    }
}
