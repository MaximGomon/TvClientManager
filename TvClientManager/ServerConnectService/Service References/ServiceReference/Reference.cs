﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerConnectService.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ITvManagerClientService")]
    public interface ITvManagerClientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITvManagerClientService/GetServerData", ReplyAction="http://tempuri.org/ITvManagerClientService/GetServerDataResponse")]
        string GetServerData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITvManagerClientService/GetServerData", ReplyAction="http://tempuri.org/ITvManagerClientService/GetServerDataResponse")]
        System.Threading.Tasks.Task<string> GetServerDataAsync(int value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITvManagerClientServiceChannel : ServerConnectService.ServiceReference.ITvManagerClientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TvManagerClientServiceClient : System.ServiceModel.ClientBase<ServerConnectService.ServiceReference.ITvManagerClientService>, ServerConnectService.ServiceReference.ITvManagerClientService {
        
        public TvManagerClientServiceClient() {
        }
        
        public TvManagerClientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TvManagerClientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TvManagerClientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TvManagerClientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetServerData(int value) {
            return base.Channel.GetServerData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetServerDataAsync(int value) {
            return base.Channel.GetServerDataAsync(value);
        }
    }
}
