//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Adexchangebuyer.V1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Accounts : Google.Apis.Requests.IDirectResponseSchema {
        
        private string accountId;
        
        private IList<Accounts.BidderLocationData> bidderLocation;
        
        private string cookieMatchingNid;
        
        private string cookieMatchingUrl;
        
        private string kind;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId {
            get {
                return this.accountId;
            }
            set {
                this.accountId = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("bidderLocation")]
        public virtual IList<Accounts.BidderLocationData> BidderLocation {
            get {
                return this.bidderLocation;
            }
            set {
                this.bidderLocation = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatchingNid")]
        public virtual string CookieMatchingNid {
            get {
                return this.cookieMatchingNid;
            }
            set {
                this.cookieMatchingNid = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatchingUrl")]
        public virtual string CookieMatchingUrl {
            get {
                return this.cookieMatchingUrl;
            }
            set {
                this.cookieMatchingUrl = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
        
        public class BidderLocationData {
            
            private long maximumQps;
            
            private string url;
            
            [Newtonsoft.Json.JsonPropertyAttribute("maximumQps")]
            public virtual long MaximumQps {
                get {
                    return this.maximumQps;
                }
                set {
                    this.maximumQps = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url {
                get {
                    return this.url;
                }
                set {
                    this.url = value;
                }
            }
        }
    }
    
    public class AccountsList : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<Accounts> items;
        
        private string kind;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Accounts> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
}
namespace Google.Apis.Adexchangebuyer.V1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class AdexchangebuyerService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1";
        
        private const string Name = "adexchangebuyer";
        
        private const string BaseUri = "https://www.googleapis.com/adexchangebuyer/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private AccountsResource accounts;
        
        public AdexchangebuyerService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.accounts = new AccountsResource(this);
        }
        
        public AdexchangebuyerService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.CachedWebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", AdexchangebuyerService.Name, AdexchangebuyerService.Version)))).GetService(AdexchangebuyerService.Version, AdexchangebuyerService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(AdexchangebuyerService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
        }
        
        /// <summary>Sets the DeveloperKey which this service uses for all requests</summary>
        public virtual string DeveloperKey {
            get {
                return this.developerKey;
            }
            set {
                this.developerKey = value;
            }
        }
        
        public virtual AccountsResource Accounts {
            get {
                return this.accounts;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(DeveloperKey)) {
                request = request.WithDeveloperKey(this.DeveloperKey);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
    }
    
    public class AccountsResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "accounts";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(AccountsResource));
        
        public AccountsResource(AdexchangebuyerService service) {
            this.service = service;
        }
        
        /// <summary>Gets one account by id.</summary>
        /// <param name="id">Required - The account id</param>
        public virtual GetRequest Get(string id) {
            return new GetRequest(service, id);
        }
        
        /// <summary>Retrieves a list of accounts.</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>Updates an existing account. This method supports patch semantics.</summary>
        /// <param name="id">Required - The account id</param>
        public virtual PatchRequest Patch(Google.Apis.Adexchangebuyer.V1.Data.Accounts body, string id) {
            return new PatchRequest(service, body, id);
        }
        
        /// <summary>Updates an existing account.</summary>
        /// <param name="id">Required - The account id</param>
        public virtual UpdateRequest Update(Google.Apis.Adexchangebuyer.V1.Data.Accounts body, string id) {
            return new UpdateRequest(service, body, id);
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Adexchangebuyer.V1.Data.Accounts> {
            
            private string id;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string id) : 
                    base(service) {
                this.id = id;
            }
            
            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id")]
            public virtual string Id {
                get {
                    return this.id;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "accounts";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Adexchangebuyer.V1.Data.AccountsList> {
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            protected override string ResourceName {
                get {
                    return "accounts";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
        
        public class PatchRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Adexchangebuyer.V1.Data.Accounts> {
            
            private string id;
            
            private Google.Apis.Adexchangebuyer.V1.Data.Accounts bodyValue;
            
            public PatchRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Adexchangebuyer.V1.Data.Accounts body, string id) : 
                    base(service) {
                this.Body = body;
                this.id = id;
            }
            
            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id")]
            public virtual string Id {
                get {
                    return this.id;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Adexchangebuyer.V1.Data.Accounts Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "accounts";
                }
            }
            
            protected override string MethodName {
                get {
                    return "patch";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
        
        public class UpdateRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Adexchangebuyer.V1.Data.Accounts> {
            
            private string id;
            
            private Google.Apis.Adexchangebuyer.V1.Data.Accounts bodyValue;
            
            public UpdateRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Adexchangebuyer.V1.Data.Accounts body, string id) : 
                    base(service) {
                this.Body = body;
                this.id = id;
            }
            
            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id")]
            public virtual string Id {
                get {
                    return this.id;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Adexchangebuyer.V1.Data.Accounts Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "accounts";
                }
            }
            
            protected override string MethodName {
                get {
                    return "update";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
    }
}