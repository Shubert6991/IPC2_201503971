﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.NintyIPC2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://PaqueteDePrueba/", ConfigurationName="NintyIPC2.ServicioPrueba")]
    public interface ServicioPrueba {
        
        // CODEGEN: Generating message contract since element name nombre from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://PaqueteDePrueba/ServicioPrueba/AgregarAdminRequest", ReplyAction="http://PaqueteDePrueba/ServicioPrueba/AgregarAdminResponse")]
        WebApplication2.NintyIPC2.AgregarAdminResponse AgregarAdmin(WebApplication2.NintyIPC2.AgregarAdminRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PaqueteDePrueba/ServicioPrueba/AgregarAdminRequest", ReplyAction="http://PaqueteDePrueba/ServicioPrueba/AgregarAdminResponse")]
        System.Threading.Tasks.Task<WebApplication2.NintyIPC2.AgregarAdminResponse> AgregarAdminAsync(WebApplication2.NintyIPC2.AgregarAdminRequest request);
        
        // CODEGEN: Generating message contract since element name hello from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://PaqueteDePrueba/ServicioPrueba/helloRequest", ReplyAction="http://PaqueteDePrueba/ServicioPrueba/helloResponse")]
        WebApplication2.NintyIPC2.helloResponse hello(WebApplication2.NintyIPC2.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PaqueteDePrueba/ServicioPrueba/helloRequest", ReplyAction="http://PaqueteDePrueba/ServicioPrueba/helloResponse")]
        System.Threading.Tasks.Task<WebApplication2.NintyIPC2.helloResponse> helloAsync(WebApplication2.NintyIPC2.helloRequest request);
        
        // CODEGEN: Generating message contract since element name nombre from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://PaqueteDePrueba/ServicioPrueba/Prueba2Request", ReplyAction="http://PaqueteDePrueba/ServicioPrueba/Prueba2Response")]
        WebApplication2.NintyIPC2.Prueba2Response Prueba2(WebApplication2.NintyIPC2.Prueba2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PaqueteDePrueba/ServicioPrueba/Prueba2Request", ReplyAction="http://PaqueteDePrueba/ServicioPrueba/Prueba2Response")]
        System.Threading.Tasks.Task<WebApplication2.NintyIPC2.Prueba2Response> Prueba2Async(WebApplication2.NintyIPC2.Prueba2Request request);
        
        // CODEGEN: Generating message contract since element name correo from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://PaqueteDePrueba/ServicioPrueba/ConsultarUsuarioRequest", ReplyAction="http://PaqueteDePrueba/ServicioPrueba/ConsultarUsuarioResponse")]
        WebApplication2.NintyIPC2.ConsultarUsuarioResponse ConsultarUsuario(WebApplication2.NintyIPC2.ConsultarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PaqueteDePrueba/ServicioPrueba/ConsultarUsuarioRequest", ReplyAction="http://PaqueteDePrueba/ServicioPrueba/ConsultarUsuarioResponse")]
        System.Threading.Tasks.Task<WebApplication2.NintyIPC2.ConsultarUsuarioResponse> ConsultarUsuarioAsync(WebApplication2.NintyIPC2.ConsultarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarAdminRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarAdmin", Namespace="http://PaqueteDePrueba/", Order=0)]
        public WebApplication2.NintyIPC2.AgregarAdminRequestBody Body;
        
        public AgregarAdminRequest() {
        }
        
        public AgregarAdminRequest(WebApplication2.NintyIPC2.AgregarAdminRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class AgregarAdminRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string notarjeta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string rol;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string suscription;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string nusuarios;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string contrasena;
        
        public AgregarAdminRequestBody() {
        }
        
        public AgregarAdminRequestBody(string nombre, string apellido, string correo, string notarjeta, string rol, string suscription, string nusuarios, string contrasena) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.notarjeta = notarjeta;
            this.rol = rol;
            this.suscription = suscription;
            this.nusuarios = nusuarios;
            this.contrasena = contrasena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarAdminResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarAdminResponse", Namespace="http://PaqueteDePrueba/", Order=0)]
        public WebApplication2.NintyIPC2.AgregarAdminResponseBody Body;
        
        public AgregarAdminResponse() {
        }
        
        public AgregarAdminResponse(WebApplication2.NintyIPC2.AgregarAdminResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AgregarAdminResponseBody {
        
        public AgregarAdminResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hello", Namespace="http://PaqueteDePrueba/", Order=0)]
        public WebApplication2.NintyIPC2.helloRequestBody Body;
        
        public helloRequest() {
        }
        
        public helloRequest(WebApplication2.NintyIPC2.helloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string hello;
        
        public helloRequestBody() {
        }
        
        public helloRequestBody(string hello) {
            this.hello = hello;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="helloResponse", Namespace="http://PaqueteDePrueba/", Order=0)]
        public WebApplication2.NintyIPC2.helloResponseBody Body;
        
        public helloResponse() {
        }
        
        public helloResponse(WebApplication2.NintyIPC2.helloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public helloResponseBody() {
        }
        
        public helloResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Prueba2Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Prueba2", Namespace="http://PaqueteDePrueba/", Order=0)]
        public WebApplication2.NintyIPC2.Prueba2RequestBody Body;
        
        public Prueba2Request() {
        }
        
        public Prueba2Request(WebApplication2.NintyIPC2.Prueba2RequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class Prueba2RequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string notarjeta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string rol;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string suscription;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string nusuarios;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string contrasena;
        
        public Prueba2RequestBody() {
        }
        
        public Prueba2RequestBody(string nombre, string apellido, string correo, string notarjeta, string rol, string suscription, string nusuarios, string contrasena) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.notarjeta = notarjeta;
            this.rol = rol;
            this.suscription = suscription;
            this.nusuarios = nusuarios;
            this.contrasena = contrasena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Prueba2Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Prueba2Response", Namespace="http://PaqueteDePrueba/", Order=0)]
        public WebApplication2.NintyIPC2.Prueba2ResponseBody Body;
        
        public Prueba2Response() {
        }
        
        public Prueba2Response(WebApplication2.NintyIPC2.Prueba2ResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class Prueba2ResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public Prueba2ResponseBody() {
        }
        
        public Prueba2ResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultarUsuario", Namespace="http://PaqueteDePrueba/", Order=0)]
        public WebApplication2.NintyIPC2.ConsultarUsuarioRequestBody Body;
        
        public ConsultarUsuarioRequest() {
        }
        
        public ConsultarUsuarioRequest(WebApplication2.NintyIPC2.ConsultarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class ConsultarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string correo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string contrasena;
        
        public ConsultarUsuarioRequestBody() {
        }
        
        public ConsultarUsuarioRequestBody(string correo, string contrasena) {
            this.correo = correo;
            this.contrasena = contrasena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultarUsuarioResponse", Namespace="http://PaqueteDePrueba/", Order=0)]
        public WebApplication2.NintyIPC2.ConsultarUsuarioResponseBody Body;
        
        public ConsultarUsuarioResponse() {
        }
        
        public ConsultarUsuarioResponse(WebApplication2.NintyIPC2.ConsultarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class ConsultarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public ConsultarUsuarioResponseBody() {
        }
        
        public ConsultarUsuarioResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioPruebaChannel : WebApplication2.NintyIPC2.ServicioPrueba, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPruebaClient : System.ServiceModel.ClientBase<WebApplication2.NintyIPC2.ServicioPrueba>, WebApplication2.NintyIPC2.ServicioPrueba {
        
        public ServicioPruebaClient() {
        }
        
        public ServicioPruebaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioPruebaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPruebaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPruebaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.NintyIPC2.AgregarAdminResponse WebApplication2.NintyIPC2.ServicioPrueba.AgregarAdmin(WebApplication2.NintyIPC2.AgregarAdminRequest request) {
            return base.Channel.AgregarAdmin(request);
        }
        
        public void AgregarAdmin(string nombre, string apellido, string correo, string notarjeta, string rol, string suscription, string nusuarios, string contrasena) {
            WebApplication2.NintyIPC2.AgregarAdminRequest inValue = new WebApplication2.NintyIPC2.AgregarAdminRequest();
            inValue.Body = new WebApplication2.NintyIPC2.AgregarAdminRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.correo = correo;
            inValue.Body.notarjeta = notarjeta;
            inValue.Body.rol = rol;
            inValue.Body.suscription = suscription;
            inValue.Body.nusuarios = nusuarios;
            inValue.Body.contrasena = contrasena;
            WebApplication2.NintyIPC2.AgregarAdminResponse retVal = ((WebApplication2.NintyIPC2.ServicioPrueba)(this)).AgregarAdmin(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.NintyIPC2.AgregarAdminResponse> WebApplication2.NintyIPC2.ServicioPrueba.AgregarAdminAsync(WebApplication2.NintyIPC2.AgregarAdminRequest request) {
            return base.Channel.AgregarAdminAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.NintyIPC2.AgregarAdminResponse> AgregarAdminAsync(string nombre, string apellido, string correo, string notarjeta, string rol, string suscription, string nusuarios, string contrasena) {
            WebApplication2.NintyIPC2.AgregarAdminRequest inValue = new WebApplication2.NintyIPC2.AgregarAdminRequest();
            inValue.Body = new WebApplication2.NintyIPC2.AgregarAdminRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.correo = correo;
            inValue.Body.notarjeta = notarjeta;
            inValue.Body.rol = rol;
            inValue.Body.suscription = suscription;
            inValue.Body.nusuarios = nusuarios;
            inValue.Body.contrasena = contrasena;
            return ((WebApplication2.NintyIPC2.ServicioPrueba)(this)).AgregarAdminAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.NintyIPC2.helloResponse WebApplication2.NintyIPC2.ServicioPrueba.hello(WebApplication2.NintyIPC2.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string hello1) {
            WebApplication2.NintyIPC2.helloRequest inValue = new WebApplication2.NintyIPC2.helloRequest();
            inValue.Body = new WebApplication2.NintyIPC2.helloRequestBody();
            inValue.Body.hello = hello1;
            WebApplication2.NintyIPC2.helloResponse retVal = ((WebApplication2.NintyIPC2.ServicioPrueba)(this)).hello(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.NintyIPC2.helloResponse> WebApplication2.NintyIPC2.ServicioPrueba.helloAsync(WebApplication2.NintyIPC2.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.NintyIPC2.helloResponse> helloAsync(string hello) {
            WebApplication2.NintyIPC2.helloRequest inValue = new WebApplication2.NintyIPC2.helloRequest();
            inValue.Body = new WebApplication2.NintyIPC2.helloRequestBody();
            inValue.Body.hello = hello;
            return ((WebApplication2.NintyIPC2.ServicioPrueba)(this)).helloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.NintyIPC2.Prueba2Response WebApplication2.NintyIPC2.ServicioPrueba.Prueba2(WebApplication2.NintyIPC2.Prueba2Request request) {
            return base.Channel.Prueba2(request);
        }
        
        public string Prueba2(string nombre, string apellido, string correo, string notarjeta, string rol, string suscription, string nusuarios, string contrasena) {
            WebApplication2.NintyIPC2.Prueba2Request inValue = new WebApplication2.NintyIPC2.Prueba2Request();
            inValue.Body = new WebApplication2.NintyIPC2.Prueba2RequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.correo = correo;
            inValue.Body.notarjeta = notarjeta;
            inValue.Body.rol = rol;
            inValue.Body.suscription = suscription;
            inValue.Body.nusuarios = nusuarios;
            inValue.Body.contrasena = contrasena;
            WebApplication2.NintyIPC2.Prueba2Response retVal = ((WebApplication2.NintyIPC2.ServicioPrueba)(this)).Prueba2(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.NintyIPC2.Prueba2Response> WebApplication2.NintyIPC2.ServicioPrueba.Prueba2Async(WebApplication2.NintyIPC2.Prueba2Request request) {
            return base.Channel.Prueba2Async(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.NintyIPC2.Prueba2Response> Prueba2Async(string nombre, string apellido, string correo, string notarjeta, string rol, string suscription, string nusuarios, string contrasena) {
            WebApplication2.NintyIPC2.Prueba2Request inValue = new WebApplication2.NintyIPC2.Prueba2Request();
            inValue.Body = new WebApplication2.NintyIPC2.Prueba2RequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.correo = correo;
            inValue.Body.notarjeta = notarjeta;
            inValue.Body.rol = rol;
            inValue.Body.suscription = suscription;
            inValue.Body.nusuarios = nusuarios;
            inValue.Body.contrasena = contrasena;
            return ((WebApplication2.NintyIPC2.ServicioPrueba)(this)).Prueba2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.NintyIPC2.ConsultarUsuarioResponse WebApplication2.NintyIPC2.ServicioPrueba.ConsultarUsuario(WebApplication2.NintyIPC2.ConsultarUsuarioRequest request) {
            return base.Channel.ConsultarUsuario(request);
        }
        
        public string ConsultarUsuario(string correo, string contrasena) {
            WebApplication2.NintyIPC2.ConsultarUsuarioRequest inValue = new WebApplication2.NintyIPC2.ConsultarUsuarioRequest();
            inValue.Body = new WebApplication2.NintyIPC2.ConsultarUsuarioRequestBody();
            inValue.Body.correo = correo;
            inValue.Body.contrasena = contrasena;
            WebApplication2.NintyIPC2.ConsultarUsuarioResponse retVal = ((WebApplication2.NintyIPC2.ServicioPrueba)(this)).ConsultarUsuario(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.NintyIPC2.ConsultarUsuarioResponse> WebApplication2.NintyIPC2.ServicioPrueba.ConsultarUsuarioAsync(WebApplication2.NintyIPC2.ConsultarUsuarioRequest request) {
            return base.Channel.ConsultarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.NintyIPC2.ConsultarUsuarioResponse> ConsultarUsuarioAsync(string correo, string contrasena) {
            WebApplication2.NintyIPC2.ConsultarUsuarioRequest inValue = new WebApplication2.NintyIPC2.ConsultarUsuarioRequest();
            inValue.Body = new WebApplication2.NintyIPC2.ConsultarUsuarioRequestBody();
            inValue.Body.correo = correo;
            inValue.Body.contrasena = contrasena;
            return ((WebApplication2.NintyIPC2.ServicioPrueba)(this)).ConsultarUsuarioAsync(inValue);
        }
    }
}
