﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beep.Chat.Client.UI.ChatService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChatService.IChatContract", CallbackContract=typeof(Beep.Chat.Client.UI.ChatService.IChatContractCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IChatContract {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/Connect")]
        void Connect(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/Disconnect")]
        void Disconnect(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/SendBroadcastMessage")]
        void SendBroadcastMessage(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/SendPrivateMessage")]
        void SendPrivateMessage(string targetUserName, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/KickAllUsers")]
        void KickAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/ShutDownUser")]
        void ShutDownUser(string targetUserName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/ShutDownAnotherUsers")]
        void ShutDownAnotherUsers(string senderUserName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/ToogleCdChase")]
        void ToogleCdChase(string targetUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatContract/UserIsConnected", ReplyAction="http://tempuri.org/IChatContract/UserIsConnectedResponse")]
        bool UserIsConnected(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatContractCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/NotifyConnection")]
        void NotifyConnection(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/NotifyDisconnection")]
        void NotifyDisconnection(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/NotifyMessage")]
        void NotifyMessage(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/ExecuteShutDown")]
        void ExecuteShutDown();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/ExceptionThrown")]
        void ExceptionThrown(string exceptionMessage);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatContract/ExecuteToogleCdChase")]
        void ExecuteToogleCdChase();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatContractChannel : Beep.Chat.Client.UI.ChatService.IChatContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatContractClient : System.ServiceModel.DuplexClientBase<Beep.Chat.Client.UI.ChatService.IChatContract>, Beep.Chat.Client.UI.ChatService.IChatContract {
        
        public ChatContractClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatContractClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Connect(string userName) {
            base.Channel.Connect(userName);
        }
        
        public void Disconnect(string userName) {
            base.Channel.Disconnect(userName);
        }
        
        public void SendBroadcastMessage(string message) {
            base.Channel.SendBroadcastMessage(message);
        }
        
        public void SendPrivateMessage(string targetUserName, string message) {
            base.Channel.SendPrivateMessage(targetUserName, message);
        }
        
        public void KickAllUsers() {
            base.Channel.KickAllUsers();
        }
        
        public void ShutDownUser(string targetUserName) {
            base.Channel.ShutDownUser(targetUserName);
        }
        
        public void ShutDownAnotherUsers(string senderUserName) {
            base.Channel.ShutDownAnotherUsers(senderUserName);
        }
        
        public void ToogleCdChase(string targetUserName) {
            base.Channel.ToogleCdChase(targetUserName);
        }
        
        public bool UserIsConnected(string userName) {
            return base.Channel.UserIsConnected(userName);
        }
    }
}
