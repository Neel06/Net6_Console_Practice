﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HDFCERGO.PIP.Adapters.HEPGService.PaymentStatusServiceSoap
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HDFCERGO.PIP.Adapters.HEPGService.PaymentStatusServiceSoap.PaymentStatusSoap")]
    public interface PaymentStatusSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetpaymentStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetpaymentStatus(string PgtransNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetpaymentStatus", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetpaymentStatusAsync(string PgtransNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetpaymentStatus_RequestDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetpaymentStatus_RequestDate(string PgtransNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetpaymentStatus_RequestDate", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetpaymentStatus_RequestDateAsync(string PgtransNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetpaymentStatus_Final", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetpaymentStatus_Final(string PgtransNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetpaymentStatus_Final", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetpaymentStatus_FinalAsync(string PgtransNo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface PaymentStatusSoapChannel : HDFCERGO.PIP.Adapters.HEPGService.PaymentStatusServiceSoap.PaymentStatusSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class PaymentStatusSoapClient : System.ServiceModel.ClientBase<HDFCERGO.PIP.Adapters.HEPGService.PaymentStatusServiceSoap.PaymentStatusSoap>, HDFCERGO.PIP.Adapters.HEPGService.PaymentStatusServiceSoap.PaymentStatusSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PaymentStatusSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(PaymentStatusSoapClient.GetBindingForEndpoint(endpointConfiguration), PaymentStatusSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentStatusSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PaymentStatusSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentStatusSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PaymentStatusSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentStatusSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string GetpaymentStatus(string PgtransNo)
        {
            return base.Channel.GetpaymentStatus(PgtransNo);
        }
        
        public System.Threading.Tasks.Task<string> GetpaymentStatusAsync(string PgtransNo)
        {
            return base.Channel.GetpaymentStatusAsync(PgtransNo);
        }
        
        public string GetpaymentStatus_RequestDate(string PgtransNo)
        {
            return base.Channel.GetpaymentStatus_RequestDate(PgtransNo);
        }
        
        public System.Threading.Tasks.Task<string> GetpaymentStatus_RequestDateAsync(string PgtransNo)
        {
            return base.Channel.GetpaymentStatus_RequestDateAsync(PgtransNo);
        }
        
        public string GetpaymentStatus_Final(string PgtransNo)
        {
            return base.Channel.GetpaymentStatus_Final(PgtransNo);
        }
        
        public System.Threading.Tasks.Task<string> GetpaymentStatus_FinalAsync(string PgtransNo)
        {
            return base.Channel.GetpaymentStatus_FinalAsync(PgtransNo);
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
            if ((endpointConfiguration == EndpointConfiguration.PaymentStatusSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.PaymentStatusSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PaymentStatusSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://115.113.35.240/UAT/PaymentStatus/PaymentStatusservice.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.PaymentStatusSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://115.113.35.240/UAT/PaymentStatus/PaymentStatusservice.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            PaymentStatusSoap,
            
            PaymentStatusSoap12,
        }
    }
}
