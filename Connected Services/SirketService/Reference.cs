﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankAppWeb.Soap.SirketService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sirket", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Sirket : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int sirketIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sirketAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sehirField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string adresField;
        
        private ushort aracSayisiField;
        
        private System.Nullable<int> sirketPuaniField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int sirketId {
            get {
                return this.sirketIdField;
            }
            set {
                if ((this.sirketIdField.Equals(value) != true)) {
                    this.sirketIdField = value;
                    this.RaisePropertyChanged("sirketId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sirketAdi {
            get {
                return this.sirketAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.sirketAdiField, value) != true)) {
                    this.sirketAdiField = value;
                    this.RaisePropertyChanged("sirketAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sehir {
            get {
                return this.sehirField;
            }
            set {
                if ((object.ReferenceEquals(this.sehirField, value) != true)) {
                    this.sehirField = value;
                    this.RaisePropertyChanged("sehir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string adres {
            get {
                return this.adresField;
            }
            set {
                if ((object.ReferenceEquals(this.adresField, value) != true)) {
                    this.adresField = value;
                    this.RaisePropertyChanged("adres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public ushort aracSayisi {
            get {
                return this.aracSayisiField;
            }
            set {
                if ((this.aracSayisiField.Equals(value) != true)) {
                    this.aracSayisiField = value;
                    this.RaisePropertyChanged("aracSayisi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<int> sirketPuani {
            get {
                return this.sirketPuaniField;
            }
            set {
                if ((this.sirketPuaniField.Equals(value) != true)) {
                    this.sirketPuaniField = value;
                    this.RaisePropertyChanged("sirketPuani");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SirketService.SirketWebServiceSoap")]
    public interface SirketWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name entity from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertSirket", ReplyAction="*")]
        BankAppWeb.Soap.SirketService.InsertSirketResponse InsertSirket(BankAppWeb.Soap.SirketService.InsertSirketRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertSirket", ReplyAction="*")]
        System.Threading.Tasks.Task<BankAppWeb.Soap.SirketService.InsertSirketResponse> InsertSirketAsync(BankAppWeb.Soap.SirketService.InsertSirketRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteSirket", ReplyAction="*")]
        bool DeleteSirket(int sirketId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteSirket", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteSirketAsync(int sirketId);
        
        // CODEGEN: Generating message contract since element name SelectAllSirketsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectAllSirkets", ReplyAction="*")]
        BankAppWeb.Soap.SirketService.SelectAllSirketsResponse SelectAllSirkets(BankAppWeb.Soap.SirketService.SelectAllSirketsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectAllSirkets", ReplyAction="*")]
        System.Threading.Tasks.Task<BankAppWeb.Soap.SirketService.SelectAllSirketsResponse> SelectAllSirketsAsync(BankAppWeb.Soap.SirketService.SelectAllSirketsRequest request);
        
        // CODEGEN: Generating message contract since element name SelectSirketByIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectSirketById", ReplyAction="*")]
        BankAppWeb.Soap.SirketService.SelectSirketByIdResponse SelectSirketById(BankAppWeb.Soap.SirketService.SelectSirketByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectSirketById", ReplyAction="*")]
        System.Threading.Tasks.Task<BankAppWeb.Soap.SirketService.SelectSirketByIdResponse> SelectSirketByIdAsync(BankAppWeb.Soap.SirketService.SelectSirketByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertSirketRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertSirket", Namespace="http://tempuri.org/", Order=0)]
        public BankAppWeb.Soap.SirketService.InsertSirketRequestBody Body;
        
        public InsertSirketRequest() {
        }
        
        public InsertSirketRequest(BankAppWeb.Soap.SirketService.InsertSirketRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertSirketRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BankAppWeb.Soap.SirketService.Sirket entity;
        
        public InsertSirketRequestBody() {
        }
        
        public InsertSirketRequestBody(BankAppWeb.Soap.SirketService.Sirket entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertSirketResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertSirketResponse", Namespace="http://tempuri.org/", Order=0)]
        public BankAppWeb.Soap.SirketService.InsertSirketResponseBody Body;
        
        public InsertSirketResponse() {
        }
        
        public InsertSirketResponse(BankAppWeb.Soap.SirketService.InsertSirketResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertSirketResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InsertSirketResult;
        
        public InsertSirketResponseBody() {
        }
        
        public InsertSirketResponseBody(bool InsertSirketResult) {
            this.InsertSirketResult = InsertSirketResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectAllSirketsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectAllSirkets", Namespace="http://tempuri.org/", Order=0)]
        public BankAppWeb.Soap.SirketService.SelectAllSirketsRequestBody Body;
        
        public SelectAllSirketsRequest() {
        }
        
        public SelectAllSirketsRequest(BankAppWeb.Soap.SirketService.SelectAllSirketsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SelectAllSirketsRequestBody {
        
        public SelectAllSirketsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectAllSirketsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectAllSirketsResponse", Namespace="http://tempuri.org/", Order=0)]
        public BankAppWeb.Soap.SirketService.SelectAllSirketsResponseBody Body;
        
        public SelectAllSirketsResponse() {
        }
        
        public SelectAllSirketsResponse(BankAppWeb.Soap.SirketService.SelectAllSirketsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelectAllSirketsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BankAppWeb.Soap.SirketService.Sirket[] SelectAllSirketsResult;
        
        public SelectAllSirketsResponseBody() {
        }
        
        public SelectAllSirketsResponseBody(BankAppWeb.Soap.SirketService.Sirket[] SelectAllSirketsResult) {
            this.SelectAllSirketsResult = SelectAllSirketsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectSirketByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectSirketById", Namespace="http://tempuri.org/", Order=0)]
        public BankAppWeb.Soap.SirketService.SelectSirketByIdRequestBody Body;
        
        public SelectSirketByIdRequest() {
        }
        
        public SelectSirketByIdRequest(BankAppWeb.Soap.SirketService.SelectSirketByIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelectSirketByIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int sirketId;
        
        public SelectSirketByIdRequestBody() {
        }
        
        public SelectSirketByIdRequestBody(int sirketId) {
            this.sirketId = sirketId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectSirketByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectSirketByIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public BankAppWeb.Soap.SirketService.SelectSirketByIdResponseBody Body;
        
        public SelectSirketByIdResponse() {
        }
        
        public SelectSirketByIdResponse(BankAppWeb.Soap.SirketService.SelectSirketByIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelectSirketByIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BankAppWeb.Soap.SirketService.Sirket SelectSirketByIdResult;
        
        public SelectSirketByIdResponseBody() {
        }
        
        public SelectSirketByIdResponseBody(BankAppWeb.Soap.SirketService.Sirket SelectSirketByIdResult) {
            this.SelectSirketByIdResult = SelectSirketByIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SirketWebServiceSoapChannel : BankAppWeb.Soap.SirketService.SirketWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SirketWebServiceSoapClient : System.ServiceModel.ClientBase<BankAppWeb.Soap.SirketService.SirketWebServiceSoap>, BankAppWeb.Soap.SirketService.SirketWebServiceSoap {
        
        public SirketWebServiceSoapClient() {
        }
        
        public SirketWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SirketWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SirketWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SirketWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BankAppWeb.Soap.SirketService.InsertSirketResponse BankAppWeb.Soap.SirketService.SirketWebServiceSoap.InsertSirket(BankAppWeb.Soap.SirketService.InsertSirketRequest request) {
            return base.Channel.InsertSirket(request);
        }
        
        public bool InsertSirket(BankAppWeb.Soap.SirketService.Sirket entity) {
            BankAppWeb.Soap.SirketService.InsertSirketRequest inValue = new BankAppWeb.Soap.SirketService.InsertSirketRequest();
            inValue.Body = new BankAppWeb.Soap.SirketService.InsertSirketRequestBody();
            inValue.Body.entity = entity;
            BankAppWeb.Soap.SirketService.InsertSirketResponse retVal = ((BankAppWeb.Soap.SirketService.SirketWebServiceSoap)(this)).InsertSirket(inValue);
            return retVal.Body.InsertSirketResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BankAppWeb.Soap.SirketService.InsertSirketResponse> BankAppWeb.Soap.SirketService.SirketWebServiceSoap.InsertSirketAsync(BankAppWeb.Soap.SirketService.InsertSirketRequest request) {
            return base.Channel.InsertSirketAsync(request);
        }
        
        public System.Threading.Tasks.Task<BankAppWeb.Soap.SirketService.InsertSirketResponse> InsertSirketAsync(BankAppWeb.Soap.SirketService.Sirket entity) {
            BankAppWeb.Soap.SirketService.InsertSirketRequest inValue = new BankAppWeb.Soap.SirketService.InsertSirketRequest();
            inValue.Body = new BankAppWeb.Soap.SirketService.InsertSirketRequestBody();
            inValue.Body.entity = entity;
            return ((BankAppWeb.Soap.SirketService.SirketWebServiceSoap)(this)).InsertSirketAsync(inValue);
        }
        
        public bool DeleteSirket(int sirketId) {
            return base.Channel.DeleteSirket(sirketId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteSirketAsync(int sirketId) {
            return base.Channel.DeleteSirketAsync(sirketId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BankAppWeb.Soap.SirketService.SelectAllSirketsResponse BankAppWeb.Soap.SirketService.SirketWebServiceSoap.SelectAllSirkets(BankAppWeb.Soap.SirketService.SelectAllSirketsRequest request) {
            return base.Channel.SelectAllSirkets(request);
        }
        
        public BankAppWeb.Soap.SirketService.Sirket[] SelectAllSirkets() {
            BankAppWeb.Soap.SirketService.SelectAllSirketsRequest inValue = new BankAppWeb.Soap.SirketService.SelectAllSirketsRequest();
            inValue.Body = new BankAppWeb.Soap.SirketService.SelectAllSirketsRequestBody();
            BankAppWeb.Soap.SirketService.SelectAllSirketsResponse retVal = ((BankAppWeb.Soap.SirketService.SirketWebServiceSoap)(this)).SelectAllSirkets(inValue);
            return retVal.Body.SelectAllSirketsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BankAppWeb.Soap.SirketService.SelectAllSirketsResponse> BankAppWeb.Soap.SirketService.SirketWebServiceSoap.SelectAllSirketsAsync(BankAppWeb.Soap.SirketService.SelectAllSirketsRequest request) {
            return base.Channel.SelectAllSirketsAsync(request);
        }
        
        public System.Threading.Tasks.Task<BankAppWeb.Soap.SirketService.SelectAllSirketsResponse> SelectAllSirketsAsync() {
            BankAppWeb.Soap.SirketService.SelectAllSirketsRequest inValue = new BankAppWeb.Soap.SirketService.SelectAllSirketsRequest();
            inValue.Body = new BankAppWeb.Soap.SirketService.SelectAllSirketsRequestBody();
            return ((BankAppWeb.Soap.SirketService.SirketWebServiceSoap)(this)).SelectAllSirketsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BankAppWeb.Soap.SirketService.SelectSirketByIdResponse BankAppWeb.Soap.SirketService.SirketWebServiceSoap.SelectSirketById(BankAppWeb.Soap.SirketService.SelectSirketByIdRequest request) {
            return base.Channel.SelectSirketById(request);
        }
        
        public BankAppWeb.Soap.SirketService.Sirket SelectSirketById(int sirketId) {
            BankAppWeb.Soap.SirketService.SelectSirketByIdRequest inValue = new BankAppWeb.Soap.SirketService.SelectSirketByIdRequest();
            inValue.Body = new BankAppWeb.Soap.SirketService.SelectSirketByIdRequestBody();
            inValue.Body.sirketId = sirketId;
            BankAppWeb.Soap.SirketService.SelectSirketByIdResponse retVal = ((BankAppWeb.Soap.SirketService.SirketWebServiceSoap)(this)).SelectSirketById(inValue);
            return retVal.Body.SelectSirketByIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BankAppWeb.Soap.SirketService.SelectSirketByIdResponse> BankAppWeb.Soap.SirketService.SirketWebServiceSoap.SelectSirketByIdAsync(BankAppWeb.Soap.SirketService.SelectSirketByIdRequest request) {
            return base.Channel.SelectSirketByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<BankAppWeb.Soap.SirketService.SelectSirketByIdResponse> SelectSirketByIdAsync(int sirketId) {
            BankAppWeb.Soap.SirketService.SelectSirketByIdRequest inValue = new BankAppWeb.Soap.SirketService.SelectSirketByIdRequest();
            inValue.Body = new BankAppWeb.Soap.SirketService.SelectSirketByIdRequestBody();
            inValue.Body.sirketId = sirketId;
            return ((BankAppWeb.Soap.SirketService.SirketWebServiceSoap)(this)).SelectSirketByIdAsync(inValue);
        }
    }
}
