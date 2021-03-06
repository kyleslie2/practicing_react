﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TripService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TripItinerary", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class TripItinerary : object
    {
        
        private string ArrivingCityField;
        
        private string DateField;
        
        private string DepartureCityField;
        
        private string PassengerNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArrivingCity
        {
            get
            {
                return this.ArrivingCityField;
            }
            set
            {
                this.ArrivingCityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartureCity
        {
            get
            {
                return this.DepartureCityField;
            }
            set
            {
                this.DepartureCityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PassengerName
        {
            get
            {
                return this.PassengerNameField;
            }
            set
            {
                this.PassengerNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TripService.ITripService")]
    public interface ITripService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITripService/GetAllDestinations", ReplyAction="http://tempuri.org/ITripService/GetAllDestinationsResponse")]
        string[] GetAllDestinations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITripService/GetAllDestinations", ReplyAction="http://tempuri.org/ITripService/GetAllDestinationsResponse")]
        System.Threading.Tasks.Task<string[]> GetAllDestinationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITripService/GetAllTripItineraries", ReplyAction="http://tempuri.org/ITripService/GetAllTripItinerariesResponse")]
        TripService.TripItinerary[] GetAllTripItineraries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITripService/GetAllTripItineraries", ReplyAction="http://tempuri.org/ITripService/GetAllTripItinerariesResponse")]
        System.Threading.Tasks.Task<TripService.TripItinerary[]> GetAllTripItinerariesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITripService/SaveTripItinerary", ReplyAction="http://tempuri.org/ITripService/SaveTripItineraryResponse")]
        string SaveTripItinerary(TripService.TripItinerary ti);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITripService/SaveTripItinerary", ReplyAction="http://tempuri.org/ITripService/SaveTripItineraryResponse")]
        System.Threading.Tasks.Task<string> SaveTripItineraryAsync(TripService.TripItinerary ti);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ITripServiceChannel : TripService.ITripService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class TripServiceClient : System.ServiceModel.ClientBase<TripService.ITripService>, TripService.ITripService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public TripServiceClient() : 
                base(TripServiceClient.GetDefaultBinding(), TripServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ITripService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TripServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(TripServiceClient.GetBindingForEndpoint(endpointConfiguration), TripServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TripServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(TripServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TripServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(TripServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TripServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string[] GetAllDestinations()
        {
            return base.Channel.GetAllDestinations();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllDestinationsAsync()
        {
            return base.Channel.GetAllDestinationsAsync();
        }
        
        public TripService.TripItinerary[] GetAllTripItineraries()
        {
            return base.Channel.GetAllTripItineraries();
        }
        
        public System.Threading.Tasks.Task<TripService.TripItinerary[]> GetAllTripItinerariesAsync()
        {
            return base.Channel.GetAllTripItinerariesAsync();
        }
        
        public string SaveTripItinerary(TripService.TripItinerary ti)
        {
            return base.Channel.SaveTripItinerary(ti);
        }
        
        public System.Threading.Tasks.Task<string> SaveTripItineraryAsync(TripService.TripItinerary ti)
        {
            return base.Channel.SaveTripItineraryAsync(ti);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ITripService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ITripService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/OnlineTripService/TripService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return TripServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ITripService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return TripServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ITripService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ITripService,
        }
    }
}
