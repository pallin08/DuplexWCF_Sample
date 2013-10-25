﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsServiceHostWcf.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMessage", CallbackContract=typeof(WindowsServiceHostWcf.ServiceReference1.IMessageCallback))]
    public interface IMessage {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessage/SendMessage", ReplyAction="http://tempuri.org/IMessage/SendMessageResponse")]
        void SendMessage(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessage/SendMessage", ReplyAction="http://tempuri.org/IMessage/SendMessageResponse")]
        System.Threading.Tasks.Task SendMessageAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessage/Subscribe", ReplyAction="http://tempuri.org/IMessage/SubscribeResponse")]
        bool Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessage/Subscribe", ReplyAction="http://tempuri.org/IMessage/SubscribeResponse")]
        System.Threading.Tasks.Task<bool> SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessage/Unsubscribe", ReplyAction="http://tempuri.org/IMessage/UnsubscribeResponse")]
        bool Unsubscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessage/Unsubscribe", ReplyAction="http://tempuri.org/IMessage/UnsubscribeResponse")]
        System.Threading.Tasks.Task<bool> UnsubscribeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessage/OnMessageSended")]
        void OnMessageSended(string message, System.DateTime timestamp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageChannel : WindowsServiceHostWcf.ServiceReference1.IMessage, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessageClient : System.ServiceModel.DuplexClientBase<WindowsServiceHostWcf.ServiceReference1.IMessage>, WindowsServiceHostWcf.ServiceReference1.IMessage {
        
        public MessageClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MessageClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MessageClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessageClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessageClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SendMessage(string message) {
            base.Channel.SendMessage(message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string message) {
            return base.Channel.SendMessageAsync(message);
        }
        
        public bool Subscribe() {
            return base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task<bool> SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public bool Unsubscribe() {
            return base.Channel.Unsubscribe();
        }
        
        public System.Threading.Tasks.Task<bool> UnsubscribeAsync() {
            return base.Channel.UnsubscribeAsync();
        }
    }
}
