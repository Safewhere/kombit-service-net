﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kombit.Samples.Consumer.Sts {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://kombit.sample.dk/fault")]
    public partial class StsFaultMessage : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string eventIdField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string EventId {
            get {
                return this.eventIdField;
            }
            set {
                this.eventIdField = value;
                this.RaisePropertyChanged("EventId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512")]
    public partial class RequestSecurityTokenResponseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.XmlElement[] itemsField;
        
        private string contextField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.XmlElement[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Context {
            get {
                return this.contextField;
            }
            set {
                this.contextField = value;
                this.RaisePropertyChanged("Context");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512")]
    public partial class RequestSecurityTokenResponseCollectionType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RequestSecurityTokenResponseType[] requestSecurityTokenResponseField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestSecurityTokenResponse", Order=0)]
        public RequestSecurityTokenResponseType[] RequestSecurityTokenResponse {
            get {
                return this.requestSecurityTokenResponseField;
            }
            set {
                this.requestSecurityTokenResponseField = value;
                this.RaisePropertyChanged("RequestSecurityTokenResponse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512")]
    public partial class RequestSecurityTokenType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.XmlElement[] itemsField;
        
        private string contextField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.XmlElement[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Context {
            get {
                return this.contextField;
            }
            set {
                this.contextField = value;
                this.RaisePropertyChanged("Context");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/ws/2008/06/identity/securitytokenservice", ConfigurationName="Sts.IWSTrust13Sync")]
    public interface IWSTrust13Sync {
        
        // CODEGEN: Generating message contract since the operation Trust13Issue is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Issue", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTRC/IssueFinal")]
        [System.ServiceModel.FaultContractAttribute(typeof(Kombit.Samples.Consumer.Sts.StsFaultMessage), Action="Trust13Issue", ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Name="StsFaultMessage", Namespace="http://kombit.sample.dk/fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Kombit.Samples.Consumer.Sts.Trust13IssueResponse Trust13Issue(Kombit.Samples.Consumer.Sts.Trust13IssueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Issue", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTRC/IssueFinal")]
        System.Threading.Tasks.Task<Kombit.Samples.Consumer.Sts.Trust13IssueResponse> Trust13IssueAsync(Kombit.Samples.Consumer.Sts.Trust13IssueRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13IssueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public Kombit.Samples.Consumer.Sts.RequestSecurityTokenType RequestSecurityToken;
        
        public Trust13IssueRequest() {
        }
        
        public Trust13IssueRequest(Kombit.Samples.Consumer.Sts.RequestSecurityTokenType RequestSecurityToken) {
            this.RequestSecurityToken = RequestSecurityToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13IssueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public Kombit.Samples.Consumer.Sts.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection;
        
        public Trust13IssueResponse() {
        }
        
        public Trust13IssueResponse(Kombit.Samples.Consumer.Sts.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection) {
            this.RequestSecurityTokenResponseCollection = RequestSecurityTokenResponseCollection;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSTrust13SyncChannel : Kombit.Samples.Consumer.Sts.IWSTrust13Sync, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSTrust13SyncClient : System.ServiceModel.ClientBase<Kombit.Samples.Consumer.Sts.IWSTrust13Sync>, Kombit.Samples.Consumer.Sts.IWSTrust13Sync {
        
        public WSTrust13SyncClient() {
        }
        
        public WSTrust13SyncClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSTrust13SyncClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSTrust13SyncClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSTrust13SyncClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Kombit.Samples.Consumer.Sts.Trust13IssueResponse Kombit.Samples.Consumer.Sts.IWSTrust13Sync.Trust13Issue(Kombit.Samples.Consumer.Sts.Trust13IssueRequest request) {
            return base.Channel.Trust13Issue(request);
        }
        
        public Kombit.Samples.Consumer.Sts.RequestSecurityTokenResponseCollectionType Trust13Issue(Kombit.Samples.Consumer.Sts.RequestSecurityTokenType RequestSecurityToken) {
            Kombit.Samples.Consumer.Sts.Trust13IssueRequest inValue = new Kombit.Samples.Consumer.Sts.Trust13IssueRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            Kombit.Samples.Consumer.Sts.Trust13IssueResponse retVal = ((Kombit.Samples.Consumer.Sts.IWSTrust13Sync)(this)).Trust13Issue(inValue);
            return retVal.RequestSecurityTokenResponseCollection;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Kombit.Samples.Consumer.Sts.Trust13IssueResponse> Kombit.Samples.Consumer.Sts.IWSTrust13Sync.Trust13IssueAsync(Kombit.Samples.Consumer.Sts.Trust13IssueRequest request) {
            return base.Channel.Trust13IssueAsync(request);
        }
        
        public System.Threading.Tasks.Task<Kombit.Samples.Consumer.Sts.Trust13IssueResponse> Trust13IssueAsync(Kombit.Samples.Consumer.Sts.RequestSecurityTokenType RequestSecurityToken) {
            Kombit.Samples.Consumer.Sts.Trust13IssueRequest inValue = new Kombit.Samples.Consumer.Sts.Trust13IssueRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            return ((Kombit.Samples.Consumer.Sts.IWSTrust13Sync)(this)).Trust13IssueAsync(inValue);
        }
    }
}
