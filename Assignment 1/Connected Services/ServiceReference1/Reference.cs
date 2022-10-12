﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment_1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckPrime", ReplyAction="http://tempuri.org/IService/CheckPrimeResponse")]
        bool CheckPrime(int val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckPrime", ReplyAction="http://tempuri.org/IService/CheckPrimeResponse")]
        System.Threading.Tasks.Task<bool> CheckPrimeAsync(int val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SumOfDigits", ReplyAction="http://tempuri.org/IService/SumOfDigitsResponse")]
        int SumOfDigits(int val1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SumOfDigits", ReplyAction="http://tempuri.org/IService/SumOfDigitsResponse")]
        System.Threading.Tasks.Task<int> SumOfDigitsAsync(int val1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReverseString", ReplyAction="http://tempuri.org/IService/ReverseStringResponse")]
        string ReverseString(string val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReverseString", ReplyAction="http://tempuri.org/IService/ReverseStringResponse")]
        System.Threading.Tasks.Task<string> ReverseStringAsync(string val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PrintHtml", ReplyAction="http://tempuri.org/IService/PrintHtmlResponse")]
        string PrintHtml(string tag, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PrintHtml", ReplyAction="http://tempuri.org/IService/PrintHtmlResponse")]
        System.Threading.Tasks.Task<string> PrintHtmlAsync(string tag, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SortNumbers", ReplyAction="http://tempuri.org/IService/SortNumbersResponse")]
        int[] SortNumbers(int[] numbers, bool ascending);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SortNumbers", ReplyAction="http://tempuri.org/IService/SortNumbersResponse")]
        System.Threading.Tasks.Task<int[]> SortNumbersAsync(int[] numbers, bool ascending);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Assignment_1.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Assignment_1.ServiceReference1.IService>, Assignment_1.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckPrime(int val) {
            return base.Channel.CheckPrime(val);
        }
        
        public System.Threading.Tasks.Task<bool> CheckPrimeAsync(int val) {
            return base.Channel.CheckPrimeAsync(val);
        }
        
        public int SumOfDigits(int val1) {
            return base.Channel.SumOfDigits(val1);
        }
        
        public System.Threading.Tasks.Task<int> SumOfDigitsAsync(int val1) {
            return base.Channel.SumOfDigitsAsync(val1);
        }
        
        public string ReverseString(string val) {
            return base.Channel.ReverseString(val);
        }
        
        public System.Threading.Tasks.Task<string> ReverseStringAsync(string val) {
            return base.Channel.ReverseStringAsync(val);
        }
        
        public string PrintHtml(string tag, string content) {
            return base.Channel.PrintHtml(tag, content);
        }
        
        public System.Threading.Tasks.Task<string> PrintHtmlAsync(string tag, string content) {
            return base.Channel.PrintHtmlAsync(tag, content);
        }
        
        public int[] SortNumbers(int[] numbers, bool ascending) {
            return base.Channel.SortNumbers(numbers, ascending);
        }
        
        public System.Threading.Tasks.Task<int[]> SortNumbersAsync(int[] numbers, bool ascending) {
            return base.Channel.SortNumbersAsync(numbers, ascending);
        }
    }
}