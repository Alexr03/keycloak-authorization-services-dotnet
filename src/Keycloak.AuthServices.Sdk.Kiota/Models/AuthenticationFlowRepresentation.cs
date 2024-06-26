// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models {
    public class AuthenticationFlowRepresentation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The alias property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Alias { get; set; }
#nullable restore
#else
        public string Alias { get; set; }
#endif
        /// <summary>The authenticationExecutions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationExecutionExportRepresentation>? AuthenticationExecutions { get; set; }
#nullable restore
#else
        public List<AuthenticationExecutionExportRepresentation> AuthenticationExecutions { get; set; }
#endif
        /// <summary>The builtIn property</summary>
        public bool? BuiltIn { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The providerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderId { get; set; }
#nullable restore
#else
        public string ProviderId { get; set; }
#endif
        /// <summary>The topLevel property</summary>
        public bool? TopLevel { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AuthenticationFlowRepresentation"/> and sets the default values.
        /// </summary>
        public AuthenticationFlowRepresentation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AuthenticationFlowRepresentation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationFlowRepresentation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationFlowRepresentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alias", n => { Alias = n.GetStringValue(); } },
                {"authenticationExecutions", n => { AuthenticationExecutions = n.GetCollectionOfObjectValues<AuthenticationExecutionExportRepresentation>(AuthenticationExecutionExportRepresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"builtIn", n => { BuiltIn = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"providerId", n => { ProviderId = n.GetStringValue(); } },
                {"topLevel", n => { TopLevel = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alias", Alias);
            writer.WriteCollectionOfObjectValues<AuthenticationExecutionExportRepresentation>("authenticationExecutions", AuthenticationExecutions);
            writer.WriteBoolValue("builtIn", BuiltIn);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("providerId", ProviderId);
            writer.WriteBoolValue("topLevel", TopLevel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
