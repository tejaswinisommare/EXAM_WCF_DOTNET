﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Hello", ReplyAction="http://tempuri.org/IService/HelloResponse")]
        string Hello();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/Hello", ReplyAction="http://tempuri.org/IService/HelloResponse")]
        System.IAsyncResult BeginHello(System.AsyncCallback callback, object asyncState);
        
        string EndHello(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/abc", ReplyAction="http://tempuri.org/IService/abcResponse")]
        string abc(int a);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/abc", ReplyAction="http://tempuri.org/IService/abcResponse")]
        System.IAsyncResult Beginabc(int a, System.AsyncCallback callback, object asyncState);
        
        string Endabc(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/Hello2")]
        void Hello2();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/IService/Hello2")]
        System.IAsyncResult BeginHello2(System.AsyncCallback callback, object asyncState);
        
        void EndHello2(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ConsoleAppClient.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public HelloCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class abcCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public abcCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ConsoleAppClient.ServiceReference1.IService>, ConsoleAppClient.ServiceReference1.IService {
        
        private BeginOperationDelegate onBeginHelloDelegate;
        
        private EndOperationDelegate onEndHelloDelegate;
        
        private System.Threading.SendOrPostCallback onHelloCompletedDelegate;
        
        private BeginOperationDelegate onBeginabcDelegate;
        
        private EndOperationDelegate onEndabcDelegate;
        
        private System.Threading.SendOrPostCallback onabcCompletedDelegate;
        
        private BeginOperationDelegate onBeginHello2Delegate;
        
        private EndOperationDelegate onEndHello2Delegate;
        
        private System.Threading.SendOrPostCallback onHello2CompletedDelegate;
        
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
        
        public event System.EventHandler<HelloCompletedEventArgs> HelloCompleted;
        
        public event System.EventHandler<abcCompletedEventArgs> abcCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> Hello2Completed;
        
        public string Hello() {
            return base.Channel.Hello();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginHello(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginHello(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndHello(System.IAsyncResult result) {
            return base.Channel.EndHello(result);
        }
        
        private System.IAsyncResult OnBeginHello(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginHello(callback, asyncState);
        }
        
        private object[] OnEndHello(System.IAsyncResult result) {
            string retVal = this.EndHello(result);
            return new object[] {
                    retVal};
        }
        
        private void OnHelloCompleted(object state) {
            if ((this.HelloCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.HelloCompleted(this, new HelloCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void HelloAsync() {
            this.HelloAsync(null);
        }
        
        public void HelloAsync(object userState) {
            if ((this.onBeginHelloDelegate == null)) {
                this.onBeginHelloDelegate = new BeginOperationDelegate(this.OnBeginHello);
            }
            if ((this.onEndHelloDelegate == null)) {
                this.onEndHelloDelegate = new EndOperationDelegate(this.OnEndHello);
            }
            if ((this.onHelloCompletedDelegate == null)) {
                this.onHelloCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnHelloCompleted);
            }
            base.InvokeAsync(this.onBeginHelloDelegate, null, this.onEndHelloDelegate, this.onHelloCompletedDelegate, userState);
        }
        
        public string abc(int a) {
            return base.Channel.abc(a);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult Beginabc(int a, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginabc(a, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string Endabc(System.IAsyncResult result) {
            return base.Channel.Endabc(result);
        }
        
        private System.IAsyncResult OnBeginabc(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int a = ((int)(inValues[0]));
            return this.Beginabc(a, callback, asyncState);
        }
        
        private object[] OnEndabc(System.IAsyncResult result) {
            string retVal = this.Endabc(result);
            return new object[] {
                    retVal};
        }
        
        private void OnabcCompleted(object state) {
            if ((this.abcCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.abcCompleted(this, new abcCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void abcAsync(int a) {
            this.abcAsync(a, null);
        }
        
        public void abcAsync(int a, object userState) {
            if ((this.onBeginabcDelegate == null)) {
                this.onBeginabcDelegate = new BeginOperationDelegate(this.OnBeginabc);
            }
            if ((this.onEndabcDelegate == null)) {
                this.onEndabcDelegate = new EndOperationDelegate(this.OnEndabc);
            }
            if ((this.onabcCompletedDelegate == null)) {
                this.onabcCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnabcCompleted);
            }
            base.InvokeAsync(this.onBeginabcDelegate, new object[] {
                        a}, this.onEndabcDelegate, this.onabcCompletedDelegate, userState);
        }
        
        public void Hello2() {
            base.Channel.Hello2();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginHello2(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginHello2(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndHello2(System.IAsyncResult result) {
            base.Channel.EndHello2(result);
        }
        
        private System.IAsyncResult OnBeginHello2(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginHello2(callback, asyncState);
        }
        
        private object[] OnEndHello2(System.IAsyncResult result) {
            this.EndHello2(result);
            return null;
        }
        
        private void OnHello2Completed(object state) {
            if ((this.Hello2Completed != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.Hello2Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void Hello2Async() {
            this.Hello2Async(null);
        }
        
        public void Hello2Async(object userState) {
            if ((this.onBeginHello2Delegate == null)) {
                this.onBeginHello2Delegate = new BeginOperationDelegate(this.OnBeginHello2);
            }
            if ((this.onEndHello2Delegate == null)) {
                this.onEndHello2Delegate = new EndOperationDelegate(this.OnEndHello2);
            }
            if ((this.onHello2CompletedDelegate == null)) {
                this.onHello2CompletedDelegate = new System.Threading.SendOrPostCallback(this.OnHello2Completed);
            }
            base.InvokeAsync(this.onBeginHello2Delegate, null, this.onEndHello2Delegate, this.onHello2CompletedDelegate, userState);
        }
    }
}
