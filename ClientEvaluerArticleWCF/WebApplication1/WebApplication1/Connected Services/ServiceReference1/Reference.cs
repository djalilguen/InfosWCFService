//------------------------------------------------------------------------------
// <généré automatiquement>
//     Ce code a été généré par un outil.
//     //
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </généré automatiquement>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.djalil.com/", ConfigurationName="ServiceReference1.ArticlesWS")]
    public interface ArticlesWS
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.djalil.com/ArticlesWS/getArticleRequest", ReplyAction="http://ws.djalil.com/ArticlesWS/getArticleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.getArticleResponse> getArticleAsync(ServiceReference1.getArticleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.djalil.com/ArticlesWS/getListArticlesRequest", ReplyAction="http://ws.djalil.com/ArticlesWS/getListArticlesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.getListArticlesResponse> getListArticlesAsync(ServiceReference1.getListArticlesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.djalil.com/ArticlesWS/likeRequest", ReplyAction="http://ws.djalil.com/ArticlesWS/likeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.likeResponse> likeAsync(ServiceReference1.likeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.djalil.com/ArticlesWS/dislikeRequest", ReplyAction="http://ws.djalil.com/ArticlesWS/dislikeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.dislikeResponse> dislikeAsync(ServiceReference1.dislikeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.djalil.com/ArticlesWS/searchArticlesRequest", ReplyAction="http://ws.djalil.com/ArticlesWS/searchArticlesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.searchArticlesResponse> searchArticlesAsync(ServiceReference1.searchArticlesRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.djalil.com/")]
    public partial class article
    {
        
        private int dislikesField;
        
        private int likesField;
        
        private int numField;
        
        private string textField;
        
        private string titleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int dislikes
        {
            get
            {
                return this.dislikesField;
            }
            set
            {
                this.dislikesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int likes
        {
            get
            {
                return this.likesField;
            }
            set
            {
                this.likesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int num
        {
            get
            {
                return this.numField;
            }
            set
            {
                this.numField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getArticle", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class getArticleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.djalil.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int num;
        
        public getArticleRequest()
        {
        }
        
        public getArticleRequest(int num)
        {
            this.num = num;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getArticleResponse", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class getArticleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.djalil.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.article @return;
        
        public getArticleResponse()
        {
        }
        
        public getArticleResponse(ServiceReference1.article @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getListArticles", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class getListArticlesRequest
    {
        
        public getListArticlesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getListArticlesResponse", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class getListArticlesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.djalil.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.article[] @return;
        
        public getListArticlesResponse()
        {
        }
        
        public getListArticlesResponse(ServiceReference1.article[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="like", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class likeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.djalil.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numArticle;
        
        public likeRequest()
        {
        }
        
        public likeRequest(int numArticle)
        {
            this.numArticle = numArticle;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="likeResponse", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class likeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.djalil.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public likeResponse()
        {
        }
        
        public likeResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="dislike", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class dislikeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.djalil.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numArticle;
        
        public dislikeRequest()
        {
        }
        
        public dislikeRequest(int numArticle)
        {
            this.numArticle = numArticle;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="dislikeResponse", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class dislikeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.djalil.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public dislikeResponse()
        {
        }
        
        public dislikeResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchArticles", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class searchArticlesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.djalil.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string keywords;
        
        public searchArticlesRequest()
        {
        }
        
        public searchArticlesRequest(string keywords)
        {
            this.keywords = keywords;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchArticlesResponse", WrapperNamespace="http://ws.djalil.com/", IsWrapped=true)]
    public partial class searchArticlesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.djalil.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.article[] @return;
        
        public searchArticlesResponse()
        {
        }
        
        public searchArticlesResponse(ServiceReference1.article[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ArticlesWSChannel : ServiceReference1.ArticlesWS, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ArticlesWSClient : System.ServiceModel.ClientBase<ServiceReference1.ArticlesWS>, ServiceReference1.ArticlesWS
    {
        
    /// <summary>
    /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
    /// </summary>
    /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
    /// <param name="clientCredentials">Informations d'identification du client</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ArticlesWSClient() : 
                base(ArticlesWSClient.GetDefaultBinding(), ArticlesWSClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ArticlesWSPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ArticlesWSClient(EndpointConfiguration endpointConfiguration) : 
                base(ArticlesWSClient.GetBindingForEndpoint(endpointConfiguration), ArticlesWSClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ArticlesWSClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ArticlesWSClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ArticlesWSClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ArticlesWSClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ArticlesWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.getArticleResponse> ServiceReference1.ArticlesWS.getArticleAsync(ServiceReference1.getArticleRequest request)
        {
            return base.Channel.getArticleAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.getArticleResponse> getArticleAsync(int num)
        {
            ServiceReference1.getArticleRequest inValue = new ServiceReference1.getArticleRequest();
            inValue.num = num;
            return ((ServiceReference1.ArticlesWS)(this)).getArticleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.getListArticlesResponse> ServiceReference1.ArticlesWS.getListArticlesAsync(ServiceReference1.getListArticlesRequest request)
        {
            return base.Channel.getListArticlesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.getListArticlesResponse> getListArticlesAsync()
        {
            ServiceReference1.getListArticlesRequest inValue = new ServiceReference1.getListArticlesRequest();
            return ((ServiceReference1.ArticlesWS)(this)).getListArticlesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.likeResponse> ServiceReference1.ArticlesWS.likeAsync(ServiceReference1.likeRequest request)
        {
            return base.Channel.likeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.likeResponse> likeAsync(int numArticle)
        {
            ServiceReference1.likeRequest inValue = new ServiceReference1.likeRequest();
            inValue.numArticle = numArticle;
            return ((ServiceReference1.ArticlesWS)(this)).likeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.dislikeResponse> ServiceReference1.ArticlesWS.dislikeAsync(ServiceReference1.dislikeRequest request)
        {
            return base.Channel.dislikeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.dislikeResponse> dislikeAsync(int numArticle)
        {
            ServiceReference1.dislikeRequest inValue = new ServiceReference1.dislikeRequest();
            inValue.numArticle = numArticle;
            return ((ServiceReference1.ArticlesWS)(this)).dislikeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.searchArticlesResponse> ServiceReference1.ArticlesWS.searchArticlesAsync(ServiceReference1.searchArticlesRequest request)
        {
            return base.Channel.searchArticlesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.searchArticlesResponse> searchArticlesAsync(string keywords)
        {
            ServiceReference1.searchArticlesRequest inValue = new ServiceReference1.searchArticlesRequest();
            inValue.keywords = keywords;
            return ((ServiceReference1.ArticlesWS)(this)).searchArticlesAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ArticlesWSPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ArticlesWSPort))
            {
                return new System.ServiceModel.EndpointAddress("http://user-pc:47030/EvaluerArticlesSOAPService/ArticlesWS");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ArticlesWSClient.GetBindingForEndpoint(EndpointConfiguration.ArticlesWSPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ArticlesWSClient.GetEndpointAddress(EndpointConfiguration.ArticlesWSPort);
        }
        
        public enum EndpointConfiguration
        {
            
            ArticlesWSPort,
        }
    }
}
