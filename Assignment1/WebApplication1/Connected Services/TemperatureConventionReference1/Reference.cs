﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.TemperatureConventionReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TemperatureConventionReference1.ITemperatureConvention1")]
    public interface ITemperatureConvention1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemperatureConvention1/c2f", ReplyAction="http://tempuri.org/ITemperatureConvention1/c2fResponse")]
        float c2f(float c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemperatureConvention1/c2f", ReplyAction="http://tempuri.org/ITemperatureConvention1/c2fResponse")]
        System.Threading.Tasks.Task<float> c2fAsync(float c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemperatureConvention1/f2c", ReplyAction="http://tempuri.org/ITemperatureConvention1/f2cResponse")]
        float f2c(float f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITemperatureConvention1/f2c", ReplyAction="http://tempuri.org/ITemperatureConvention1/f2cResponse")]
        System.Threading.Tasks.Task<float> f2cAsync(float f);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITemperatureConvention1Channel : WebApplication1.TemperatureConventionReference1.ITemperatureConvention1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TemperatureConvention1Client : System.ServiceModel.ClientBase<WebApplication1.TemperatureConventionReference1.ITemperatureConvention1>, WebApplication1.TemperatureConventionReference1.ITemperatureConvention1 {
        
        public TemperatureConvention1Client() {
        }
        
        public TemperatureConvention1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TemperatureConvention1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TemperatureConvention1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TemperatureConvention1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float c2f(float c) {
            return base.Channel.c2f(c);
        }
        
        public System.Threading.Tasks.Task<float> c2fAsync(float c) {
            return base.Channel.c2fAsync(c);
        }
        
        public float f2c(float f) {
            return base.Channel.f2c(f);
        }
        
        public System.Threading.Tasks.Task<float> f2cAsync(float f) {
            return base.Channel.f2cAsync(f);
        }
    }
}
