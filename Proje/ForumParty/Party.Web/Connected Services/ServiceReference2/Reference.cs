﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Party.Web.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.ASMXTestSoap")]
    public interface ASMXTestSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Party.Web.ServiceReference2.HelloWorldResponse HelloWorld(Party.Web.ServiceReference2.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Party.Web.ServiceReference2.HelloWorldResponse> HelloWorldAsync(Party.Web.ServiceReference2.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name AdlariListeleResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AdlariListele", ReplyAction="*")]
        Party.Web.ServiceReference2.AdlariListeleResponse AdlariListele(Party.Web.ServiceReference2.AdlariListeleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AdlariListele", ReplyAction="*")]
        System.Threading.Tasks.Task<Party.Web.ServiceReference2.AdlariListeleResponse> AdlariListeleAsync(Party.Web.ServiceReference2.AdlariListeleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPostsFromService", ReplyAction="*")]
        void GetPostsFromService(int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPostsFromService", ReplyAction="*")]
        System.Threading.Tasks.Task GetPostsFromServiceAsync(int pageNumber, int pageSize);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Party.Web.ServiceReference2.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Party.Web.ServiceReference2.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Party.Web.ServiceReference2.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Party.Web.ServiceReference2.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AdlariListeleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AdlariListele", Namespace="http://tempuri.org/", Order=0)]
        public Party.Web.ServiceReference2.AdlariListeleRequestBody Body;
        
        public AdlariListeleRequest() {
        }
        
        public AdlariListeleRequest(Party.Web.ServiceReference2.AdlariListeleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AdlariListeleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int numb;
        
        public AdlariListeleRequestBody() {
        }
        
        public AdlariListeleRequestBody(int numb) {
            this.numb = numb;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AdlariListeleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AdlariListeleResponse", Namespace="http://tempuri.org/", Order=0)]
        public Party.Web.ServiceReference2.AdlariListeleResponseBody Body;
        
        public AdlariListeleResponse() {
        }
        
        public AdlariListeleResponse(Party.Web.ServiceReference2.AdlariListeleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AdlariListeleResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Party.Web.ServiceReference2.ArrayOfString AdlariListeleResult;
        
        public AdlariListeleResponseBody() {
        }
        
        public AdlariListeleResponseBody(Party.Web.ServiceReference2.ArrayOfString AdlariListeleResult) {
            this.AdlariListeleResult = AdlariListeleResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ASMXTestSoapChannel : Party.Web.ServiceReference2.ASMXTestSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ASMXTestSoapClient : System.ServiceModel.ClientBase<Party.Web.ServiceReference2.ASMXTestSoap>, Party.Web.ServiceReference2.ASMXTestSoap {
        
        public ASMXTestSoapClient() {
        }
        
        public ASMXTestSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ASMXTestSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ASMXTestSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ASMXTestSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Party.Web.ServiceReference2.HelloWorldResponse Party.Web.ServiceReference2.ASMXTestSoap.HelloWorld(Party.Web.ServiceReference2.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Party.Web.ServiceReference2.HelloWorldRequest inValue = new Party.Web.ServiceReference2.HelloWorldRequest();
            inValue.Body = new Party.Web.ServiceReference2.HelloWorldRequestBody();
            Party.Web.ServiceReference2.HelloWorldResponse retVal = ((Party.Web.ServiceReference2.ASMXTestSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Party.Web.ServiceReference2.HelloWorldResponse> Party.Web.ServiceReference2.ASMXTestSoap.HelloWorldAsync(Party.Web.ServiceReference2.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Party.Web.ServiceReference2.HelloWorldResponse> HelloWorldAsync() {
            Party.Web.ServiceReference2.HelloWorldRequest inValue = new Party.Web.ServiceReference2.HelloWorldRequest();
            inValue.Body = new Party.Web.ServiceReference2.HelloWorldRequestBody();
            return ((Party.Web.ServiceReference2.ASMXTestSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Party.Web.ServiceReference2.AdlariListeleResponse Party.Web.ServiceReference2.ASMXTestSoap.AdlariListele(Party.Web.ServiceReference2.AdlariListeleRequest request) {
            return base.Channel.AdlariListele(request);
        }
        
        public Party.Web.ServiceReference2.ArrayOfString AdlariListele(int numb) {
            Party.Web.ServiceReference2.AdlariListeleRequest inValue = new Party.Web.ServiceReference2.AdlariListeleRequest();
            inValue.Body = new Party.Web.ServiceReference2.AdlariListeleRequestBody();
            inValue.Body.numb = numb;
            Party.Web.ServiceReference2.AdlariListeleResponse retVal = ((Party.Web.ServiceReference2.ASMXTestSoap)(this)).AdlariListele(inValue);
            return retVal.Body.AdlariListeleResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Party.Web.ServiceReference2.AdlariListeleResponse> Party.Web.ServiceReference2.ASMXTestSoap.AdlariListeleAsync(Party.Web.ServiceReference2.AdlariListeleRequest request) {
            return base.Channel.AdlariListeleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Party.Web.ServiceReference2.AdlariListeleResponse> AdlariListeleAsync(int numb) {
            Party.Web.ServiceReference2.AdlariListeleRequest inValue = new Party.Web.ServiceReference2.AdlariListeleRequest();
            inValue.Body = new Party.Web.ServiceReference2.AdlariListeleRequestBody();
            inValue.Body.numb = numb;
            return ((Party.Web.ServiceReference2.ASMXTestSoap)(this)).AdlariListeleAsync(inValue);
        }
        
        public void GetPostsFromService(int pageNumber, int pageSize) {
            base.Channel.GetPostsFromService(pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task GetPostsFromServiceAsync(int pageNumber, int pageSize) {
            return base.Channel.GetPostsFromServiceAsync(pageNumber, pageSize);
        }
    }
}