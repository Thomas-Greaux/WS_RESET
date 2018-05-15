﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventsConsoleClient.IWSReference {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IWSReference.IIWS", CallbackContract=typeof(EventsConsoleClient.IWSReference.IIWSCallback))]
    public interface IIWS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetCitiesName", ReplyAction="http://tempuri.org/IIWS/GetCitiesNameResponse")]
        EventsConsoleClient.IWSReference.City[] GetCitiesName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetCitiesName", ReplyAction="http://tempuri.org/IIWS/GetCitiesNameResponse")]
        System.Threading.Tasks.Task<EventsConsoleClient.IWSReference.City[]> GetCitiesNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStations", ReplyAction="http://tempuri.org/IIWS/GetStationsResponse")]
        EventsConsoleClient.IWSReference.Station[] GetStations(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStations", ReplyAction="http://tempuri.org/IIWS/GetStationsResponse")]
        System.Threading.Tasks.Task<EventsConsoleClient.IWSReference.Station[]> GetStationsAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStation", ReplyAction="http://tempuri.org/IIWS/GetStationResponse")]
        EventsConsoleClient.IWSReference.Station GetStation(string city, string station_name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStation", ReplyAction="http://tempuri.org/IIWS/GetStationResponse")]
        System.Threading.Tasks.Task<EventsConsoleClient.IWSReference.Station> GetStationAsync(string city, string station_name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/SubscribeStationInfo", ReplyAction="http://tempuri.org/IIWS/SubscribeStationInfoResponse")]
        void SubscribeStationInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/SubscribeStationInfo", ReplyAction="http://tempuri.org/IIWS/SubscribeStationInfoResponse")]
        System.Threading.Tasks.Task SubscribeStationInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStationForEvent", ReplyAction="http://tempuri.org/IIWS/GetStationForEventResponse")]
        void GetStationForEvent(string city, string station_name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIWS/GetStationForEvent", ReplyAction="http://tempuri.org/IIWS/GetStationForEventResponse")]
        System.Threading.Tasks.Task GetStationForEventAsync(string city, string station_name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIWSCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IIWS/StationInfo")]
        void StationInfo(string city, string station_name, EventsConsoleClient.IWSReference.Station res_station);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIWSChannel : EventsConsoleClient.IWSReference.IIWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IWSClient : System.ServiceModel.DuplexClientBase<EventsConsoleClient.IWSReference.IIWS>, EventsConsoleClient.IWSReference.IIWS {
        
        public IWSClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public IWSClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public IWSClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public IWSClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public IWSClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public EventsConsoleClient.IWSReference.City[] GetCitiesName() {
            return base.Channel.GetCitiesName();
        }
        
        public System.Threading.Tasks.Task<EventsConsoleClient.IWSReference.City[]> GetCitiesNameAsync() {
            return base.Channel.GetCitiesNameAsync();
        }
        
        public EventsConsoleClient.IWSReference.Station[] GetStations(string city) {
            return base.Channel.GetStations(city);
        }
        
        public System.Threading.Tasks.Task<EventsConsoleClient.IWSReference.Station[]> GetStationsAsync(string city) {
            return base.Channel.GetStationsAsync(city);
        }
        
        public EventsConsoleClient.IWSReference.Station GetStation(string city, string station_name) {
            return base.Channel.GetStation(city, station_name);
        }
        
        public System.Threading.Tasks.Task<EventsConsoleClient.IWSReference.Station> GetStationAsync(string city, string station_name) {
            return base.Channel.GetStationAsync(city, station_name);
        }
        
        public void SubscribeStationInfo() {
            base.Channel.SubscribeStationInfo();
        }
        
        public System.Threading.Tasks.Task SubscribeStationInfoAsync() {
            return base.Channel.SubscribeStationInfoAsync();
        }
        
        public void GetStationForEvent(string city, string station_name) {
            base.Channel.GetStationForEvent(city, station_name);
        }
        
        public System.Threading.Tasks.Task GetStationForEventAsync(string city, string station_name) {
            return base.Channel.GetStationForEventAsync(city, station_name);
        }
    }
}
