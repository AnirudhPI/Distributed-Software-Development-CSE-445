﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.SolarEnergyReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SolarEnergyData", Namespace="http://schemas.datacontract.org/2004/07/SolarEnergy")]
    [System.SerializableAttribute()]
    public partial class SolarEnergyData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] errorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication1.SolarEnergyReference.Inputs inputsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication1.SolarEnergyReference.Metadata metadataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication1.SolarEnergyReference.Outputs outputsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string versionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] warningsField;
        
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
        public string[] errors {
            get {
                return this.errorsField;
            }
            set {
                if ((object.ReferenceEquals(this.errorsField, value) != true)) {
                    this.errorsField = value;
                    this.RaisePropertyChanged("errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.SolarEnergyReference.Inputs inputs {
            get {
                return this.inputsField;
            }
            set {
                if ((object.ReferenceEquals(this.inputsField, value) != true)) {
                    this.inputsField = value;
                    this.RaisePropertyChanged("inputs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.SolarEnergyReference.Metadata metadata {
            get {
                return this.metadataField;
            }
            set {
                if ((object.ReferenceEquals(this.metadataField, value) != true)) {
                    this.metadataField = value;
                    this.RaisePropertyChanged("metadata");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.SolarEnergyReference.Outputs outputs {
            get {
                return this.outputsField;
            }
            set {
                if ((object.ReferenceEquals(this.outputsField, value) != true)) {
                    this.outputsField = value;
                    this.RaisePropertyChanged("outputs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                if ((object.ReferenceEquals(this.versionField, value) != true)) {
                    this.versionField = value;
                    this.RaisePropertyChanged("version");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] warnings {
            get {
                return this.warningsField;
            }
            set {
                if ((object.ReferenceEquals(this.warningsField, value) != true)) {
                    this.warningsField = value;
                    this.RaisePropertyChanged("warnings");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Inputs", Namespace="http://schemas.datacontract.org/2004/07/SolarEnergy")]
    [System.SerializableAttribute()]
    public partial class Inputs : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string latField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lonField;
        
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
        public string lat {
            get {
                return this.latField;
            }
            set {
                if ((object.ReferenceEquals(this.latField, value) != true)) {
                    this.latField = value;
                    this.RaisePropertyChanged("lat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lon {
            get {
                return this.lonField;
            }
            set {
                if ((object.ReferenceEquals(this.lonField, value) != true)) {
                    this.lonField = value;
                    this.RaisePropertyChanged("lon");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Metadata", Namespace="http://schemas.datacontract.org/2004/07/SolarEnergy")]
    [System.SerializableAttribute()]
    public partial class Metadata : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] sourcesField;
        
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
        public string[] sources {
            get {
                return this.sourcesField;
            }
            set {
                if ((object.ReferenceEquals(this.sourcesField, value) != true)) {
                    this.sourcesField = value;
                    this.RaisePropertyChanged("sources");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Outputs", Namespace="http://schemas.datacontract.org/2004/07/SolarEnergy")]
    [System.SerializableAttribute()]
    public partial class Outputs : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication1.SolarEnergyReference.AvgDni avg_dniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication1.SolarEnergyReference.AvgGhi avg_ghiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication1.SolarEnergyReference.AvgLatTilt avg_lat_tiltField;
        
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
        public WebApplication1.SolarEnergyReference.AvgDni avg_dni {
            get {
                return this.avg_dniField;
            }
            set {
                if ((object.ReferenceEquals(this.avg_dniField, value) != true)) {
                    this.avg_dniField = value;
                    this.RaisePropertyChanged("avg_dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.SolarEnergyReference.AvgGhi avg_ghi {
            get {
                return this.avg_ghiField;
            }
            set {
                if ((object.ReferenceEquals(this.avg_ghiField, value) != true)) {
                    this.avg_ghiField = value;
                    this.RaisePropertyChanged("avg_ghi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.SolarEnergyReference.AvgLatTilt avg_lat_tilt {
            get {
                return this.avg_lat_tiltField;
            }
            set {
                if ((object.ReferenceEquals(this.avg_lat_tiltField, value) != true)) {
                    this.avg_lat_tiltField = value;
                    this.RaisePropertyChanged("avg_lat_tilt");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AvgDni", Namespace="http://schemas.datacontract.org/2004/07/SolarEnergy")]
    [System.SerializableAttribute()]
    public partial class AvgDni : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double annualField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication1.SolarEnergyReference.Monthly monthlyField;
        
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
        public double annual {
            get {
                return this.annualField;
            }
            set {
                if ((this.annualField.Equals(value) != true)) {
                    this.annualField = value;
                    this.RaisePropertyChanged("annual");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.SolarEnergyReference.Monthly monthly {
            get {
                return this.monthlyField;
            }
            set {
                if ((object.ReferenceEquals(this.monthlyField, value) != true)) {
                    this.monthlyField = value;
                    this.RaisePropertyChanged("monthly");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AvgGhi", Namespace="http://schemas.datacontract.org/2004/07/SolarEnergy")]
    [System.SerializableAttribute()]
    public partial class AvgGhi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double annualField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication1.SolarEnergyReference.Monthly monthlyField;
        
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
        public double annual {
            get {
                return this.annualField;
            }
            set {
                if ((this.annualField.Equals(value) != true)) {
                    this.annualField = value;
                    this.RaisePropertyChanged("annual");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.SolarEnergyReference.Monthly monthly {
            get {
                return this.monthlyField;
            }
            set {
                if ((object.ReferenceEquals(this.monthlyField, value) != true)) {
                    this.monthlyField = value;
                    this.RaisePropertyChanged("monthly");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AvgLatTilt", Namespace="http://schemas.datacontract.org/2004/07/SolarEnergy")]
    [System.SerializableAttribute()]
    public partial class AvgLatTilt : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double annualField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication1.SolarEnergyReference.Monthly monthlyField;
        
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
        public double annual {
            get {
                return this.annualField;
            }
            set {
                if ((this.annualField.Equals(value) != true)) {
                    this.annualField = value;
                    this.RaisePropertyChanged("annual");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication1.SolarEnergyReference.Monthly monthly {
            get {
                return this.monthlyField;
            }
            set {
                if ((object.ReferenceEquals(this.monthlyField, value) != true)) {
                    this.monthlyField = value;
                    this.RaisePropertyChanged("monthly");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Monthly", Namespace="http://schemas.datacontract.org/2004/07/SolarEnergy")]
    [System.SerializableAttribute()]
    public partial class Monthly : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double aprField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double augField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double decField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double febField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double janField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double julField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double junField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double marField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double mayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double novField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double octField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double sepField;
        
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
        public double apr {
            get {
                return this.aprField;
            }
            set {
                if ((this.aprField.Equals(value) != true)) {
                    this.aprField = value;
                    this.RaisePropertyChanged("apr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double aug {
            get {
                return this.augField;
            }
            set {
                if ((this.augField.Equals(value) != true)) {
                    this.augField = value;
                    this.RaisePropertyChanged("aug");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double dec {
            get {
                return this.decField;
            }
            set {
                if ((this.decField.Equals(value) != true)) {
                    this.decField = value;
                    this.RaisePropertyChanged("dec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double feb {
            get {
                return this.febField;
            }
            set {
                if ((this.febField.Equals(value) != true)) {
                    this.febField = value;
                    this.RaisePropertyChanged("feb");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double jan {
            get {
                return this.janField;
            }
            set {
                if ((this.janField.Equals(value) != true)) {
                    this.janField = value;
                    this.RaisePropertyChanged("jan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double jul {
            get {
                return this.julField;
            }
            set {
                if ((this.julField.Equals(value) != true)) {
                    this.julField = value;
                    this.RaisePropertyChanged("jul");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double jun {
            get {
                return this.junField;
            }
            set {
                if ((this.junField.Equals(value) != true)) {
                    this.junField = value;
                    this.RaisePropertyChanged("jun");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double mar {
            get {
                return this.marField;
            }
            set {
                if ((this.marField.Equals(value) != true)) {
                    this.marField = value;
                    this.RaisePropertyChanged("mar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double may {
            get {
                return this.mayField;
            }
            set {
                if ((this.mayField.Equals(value) != true)) {
                    this.mayField = value;
                    this.RaisePropertyChanged("may");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double nov {
            get {
                return this.novField;
            }
            set {
                if ((this.novField.Equals(value) != true)) {
                    this.novField = value;
                    this.RaisePropertyChanged("nov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double oct {
            get {
                return this.octField;
            }
            set {
                if ((this.octField.Equals(value) != true)) {
                    this.octField = value;
                    this.RaisePropertyChanged("oct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double sep {
            get {
                return this.sepField;
            }
            set {
                if ((this.sepField.Equals(value) != true)) {
                    this.sepField = value;
                    this.RaisePropertyChanged("sep");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SolarEnergyReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSolarEnergyData", ReplyAction="http://tempuri.org/IService1/GetSolarEnergyDataResponse")]
        WebApplication1.SolarEnergyReference.SolarEnergyData GetSolarEnergyData(double lati, double longi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSolarEnergyData", ReplyAction="http://tempuri.org/IService1/GetSolarEnergyDataResponse")]
        System.Threading.Tasks.Task<WebApplication1.SolarEnergyReference.SolarEnergyData> GetSolarEnergyDataAsync(double lati, double longi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSolarReport", ReplyAction="http://tempuri.org/IService1/GetSolarReportResponse")]
        string GetSolarReport(double lati, double longi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSolarReport", ReplyAction="http://tempuri.org/IService1/GetSolarReportResponse")]
        System.Threading.Tasks.Task<string> GetSolarReportAsync(double lati, double longi);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.SolarEnergyReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.SolarEnergyReference.IService1>, WebApplication1.SolarEnergyReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication1.SolarEnergyReference.SolarEnergyData GetSolarEnergyData(double lati, double longi) {
            return base.Channel.GetSolarEnergyData(lati, longi);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.SolarEnergyReference.SolarEnergyData> GetSolarEnergyDataAsync(double lati, double longi) {
            return base.Channel.GetSolarEnergyDataAsync(lati, longi);
        }
        
        public string GetSolarReport(double lati, double longi) {
            return base.Channel.GetSolarReport(lati, longi);
        }
        
        public System.Threading.Tasks.Task<string> GetSolarReportAsync(double lati, double longi) {
            return base.Channel.GetSolarReportAsync(lati, longi);
        }
    }
}