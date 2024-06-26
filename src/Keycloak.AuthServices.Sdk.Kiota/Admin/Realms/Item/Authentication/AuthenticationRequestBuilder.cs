// <auto-generated/>
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.AuthenticatorProviders;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.ClientAuthenticatorProviders;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.Config;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.ConfigDescription;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.Executions;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.Flows;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.FormActionProviders;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.FormProviders;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.PerClientConfigDescription;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.RegisterRequiredAction;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.RequiredActions;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication.UnregisteredRequiredActions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication {
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\authentication
    /// </summary>
    public class AuthenticationRequestBuilder : BaseRequestBuilder {
        /// <summary>The authenticatorProviders property</summary>
        public AuthenticatorProvidersRequestBuilder AuthenticatorProviders { get =>
            new AuthenticatorProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientAuthenticatorProviders property</summary>
        public ClientAuthenticatorProvidersRequestBuilder ClientAuthenticatorProviders { get =>
            new ClientAuthenticatorProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The config property</summary>
        public ConfigRequestBuilder Config { get =>
            new ConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The configDescription property</summary>
        public ConfigDescriptionRequestBuilder ConfigDescription { get =>
            new ConfigDescriptionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The executions property</summary>
        public ExecutionsRequestBuilder Executions { get =>
            new ExecutionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The flows property</summary>
        public FlowsRequestBuilder Flows { get =>
            new FlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The formActionProviders property</summary>
        public FormActionProvidersRequestBuilder FormActionProviders { get =>
            new FormActionProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The formProviders property</summary>
        public FormProvidersRequestBuilder FormProviders { get =>
            new FormProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The perClientConfigDescription property</summary>
        public PerClientConfigDescriptionRequestBuilder PerClientConfigDescription { get =>
            new PerClientConfigDescriptionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The registerRequiredAction property</summary>
        public RegisterRequiredActionRequestBuilder RegisterRequiredAction { get =>
            new RegisterRequiredActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The requiredActions property</summary>
        public RequiredActionsRequestBuilder RequiredActions { get =>
            new RequiredActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The unregisteredRequiredActions property</summary>
        public UnregisteredRequiredActionsRequestBuilder UnregisteredRequiredActions { get =>
            new UnregisteredRequiredActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="AuthenticationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/authentication", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="AuthenticationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/authentication", rawUrl) {
        }
    }
}
