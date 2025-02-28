﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorClient.CalculatorReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorReference.ICalculatorService")]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Sub", ReplyAction="http://tempuri.org/ICalculatorService/SubResponse")]
        double Sub(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Sub", ReplyAction="http://tempuri.org/ICalculatorService/SubResponse")]
        System.Threading.Tasks.Task<double> SubAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Mul", ReplyAction="http://tempuri.org/ICalculatorService/MulResponse")]
        double Mul(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Mul", ReplyAction="http://tempuri.org/ICalculatorService/MulResponse")]
        System.Threading.Tasks.Task<double> MulAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Div", ReplyAction="http://tempuri.org/ICalculatorService/DivResponse")]
        double Div(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Div", ReplyAction="http://tempuri.org/ICalculatorService/DivResponse")]
        System.Threading.Tasks.Task<double> DivAsync(double n1, double n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : CalculatorClient.CalculatorReference.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<CalculatorClient.CalculatorReference.ICalculatorService>, CalculatorClient.CalculatorReference.ICalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2) {
            return base.Channel.AddAsync(n1, n2);
        }
        
        public double Sub(double n1, double n2) {
            return base.Channel.Sub(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SubAsync(double n1, double n2) {
            return base.Channel.SubAsync(n1, n2);
        }
        
        public double Mul(double n1, double n2) {
            return base.Channel.Mul(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MulAsync(double n1, double n2) {
            return base.Channel.MulAsync(n1, n2);
        }
        
        public double Div(double n1, double n2) {
            return base.Channel.Div(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DivAsync(double n1, double n2) {
            return base.Channel.DivAsync(n1, n2);
        }
    }
}
