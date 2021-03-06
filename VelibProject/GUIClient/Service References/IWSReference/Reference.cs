﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUIClient.IWSReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/IntermediaryWS")]
    [System.SerializableAttribute()]
    public partial class City : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/IntermediaryWS")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Available_bikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Available_bikes {
            get {
                return this.Available_bikesField;
            }
            set {
                if ((this.Available_bikesField.Equals(value) != true)) {
                    this.Available_bikesField = value;
                    this.RaisePropertyChanged("Available_bikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IWSReference.IIWS")]
    public interface IIWS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetCitiesName", ReplyAction="http://tempuri.org/IIWS/GetCitiesNameResponse")]
        GUIClient.IWSReference.City[] GetCitiesName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetCitiesName", ReplyAction="http://tempuri.org/IIWS/GetCitiesNameResponse")]
        System.Threading.Tasks.Task<GUIClient.IWSReference.City[]> GetCitiesNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStations", ReplyAction="http://tempuri.org/IIWS/GetStationsResponse")]
        GUIClient.IWSReference.Station[] GetStations(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStations", ReplyAction="http://tempuri.org/IIWS/GetStationsResponse")]
        System.Threading.Tasks.Task<GUIClient.IWSReference.Station[]> GetStationsAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStation", ReplyAction="http://tempuri.org/IIWS/GetStationResponse")]
        GUIClient.IWSReference.Station GetStation(string city, string station_name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStation", ReplyAction="http://tempuri.org/IIWS/GetStationResponse")]
        System.Threading.Tasks.Task<GUIClient.IWSReference.Station> GetStationAsync(string city, string station_name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIWSChannel : GUIClient.IWSReference.IIWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IWSClient : System.ServiceModel.ClientBase<GUIClient.IWSReference.IIWS>, GUIClient.IWSReference.IIWS {
        
        public IWSClient() {
        }
        
        public IWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GUIClient.IWSReference.City[] GetCitiesName() {
            return base.Channel.GetCitiesName();
        }
        
        public System.Threading.Tasks.Task<GUIClient.IWSReference.City[]> GetCitiesNameAsync() {
            return base.Channel.GetCitiesNameAsync();
        }
        
        public GUIClient.IWSReference.Station[] GetStations(string city) {
            return base.Channel.GetStations(city);
        }
        
        public System.Threading.Tasks.Task<GUIClient.IWSReference.Station[]> GetStationsAsync(string city) {
            return base.Channel.GetStationsAsync(city);
        }
        
        public GUIClient.IWSReference.Station GetStation(string city, string station_name) {
            return base.Channel.GetStation(city, station_name);
        }
        
        public System.Threading.Tasks.Task<GUIClient.IWSReference.Station> GetStationAsync(string city, string station_name) {
            return base.Channel.GetStationAsync(city, station_name);
        }
    }
}
