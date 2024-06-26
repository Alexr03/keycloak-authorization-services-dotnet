// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models {
    public class UserRepresentation : IAdditionalDataHolder, IParsable {
        /// <summary>The access property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserRepresentation_access? Access { get; set; }
#nullable restore
#else
        public UserRepresentation_access Access { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The applicationRoles property</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserRepresentation_applicationRoles? ApplicationRoles { get; set; }
#nullable restore
#else
        public UserRepresentation_applicationRoles ApplicationRoles { get; set; }
#endif
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserRepresentation_attributes? Attributes { get; set; }
#nullable restore
#else
        public UserRepresentation_attributes Attributes { get; set; }
#endif
        /// <summary>The clientConsents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserConsentRepresentation>? ClientConsents { get; set; }
#nullable restore
#else
        public List<UserConsentRepresentation> ClientConsents { get; set; }
#endif
        /// <summary>The clientRoles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserRepresentation_clientRoles? ClientRoles { get; set; }
#nullable restore
#else
        public UserRepresentation_clientRoles ClientRoles { get; set; }
#endif
        /// <summary>The createdTimestamp property</summary>
        public long? CreatedTimestamp { get; set; }
        /// <summary>The credentials property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CredentialRepresentation>? Credentials { get; set; }
#nullable restore
#else
        public List<CredentialRepresentation> Credentials { get; set; }
#endif
        /// <summary>The disableableCredentialTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisableableCredentialTypes { get; set; }
#nullable restore
#else
        public List<string> DisableableCredentialTypes { get; set; }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The emailVerified property</summary>
        public bool? EmailVerified { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The federatedIdentities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FederatedIdentityRepresentation>? FederatedIdentities { get; set; }
#nullable restore
#else
        public List<FederatedIdentityRepresentation> FederatedIdentities { get; set; }
#endif
        /// <summary>The federationLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FederationLink { get; set; }
#nullable restore
#else
        public string FederationLink { get; set; }
#endif
        /// <summary>The firstName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The groups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Groups { get; set; }
#nullable restore
#else
        public List<string> Groups { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The lastName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>The notBefore property</summary>
        public int? NotBefore { get; set; }
        /// <summary>The origin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Origin { get; set; }
#nullable restore
#else
        public string Origin { get; set; }
#endif
        /// <summary>The realmRoles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RealmRoles { get; set; }
#nullable restore
#else
        public List<string> RealmRoles { get; set; }
#endif
        /// <summary>The requiredActions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RequiredActions { get; set; }
#nullable restore
#else
        public List<string> RequiredActions { get; set; }
#endif
        /// <summary>The self property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; set; }
#nullable restore
#else
        public string Self { get; set; }
#endif
        /// <summary>The serviceAccountClientId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceAccountClientId { get; set; }
#nullable restore
#else
        public string ServiceAccountClientId { get; set; }
#endif
        /// <summary>The socialLinks property</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SocialLinkRepresentation>? SocialLinks { get; set; }
#nullable restore
#else
        public List<SocialLinkRepresentation> SocialLinks { get; set; }
#endif
        /// <summary>The totp property</summary>
        public bool? Totp { get; set; }
        /// <summary>The username property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>The userProfileMetadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UserProfileMetadata? UserProfileMetadata { get; set; }
#nullable restore
#else
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UserProfileMetadata UserProfileMetadata { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="UserRepresentation"/> and sets the default values.
        /// </summary>
        public UserRepresentation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserRepresentation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserRepresentation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRepresentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"access", n => { Access = n.GetObjectValue<UserRepresentation_access>(UserRepresentation_access.CreateFromDiscriminatorValue); } },
                {"applicationRoles", n => { ApplicationRoles = n.GetObjectValue<UserRepresentation_applicationRoles>(UserRepresentation_applicationRoles.CreateFromDiscriminatorValue); } },
                {"attributes", n => { Attributes = n.GetObjectValue<UserRepresentation_attributes>(UserRepresentation_attributes.CreateFromDiscriminatorValue); } },
                {"clientConsents", n => { ClientConsents = n.GetCollectionOfObjectValues<UserConsentRepresentation>(UserConsentRepresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"clientRoles", n => { ClientRoles = n.GetObjectValue<UserRepresentation_clientRoles>(UserRepresentation_clientRoles.CreateFromDiscriminatorValue); } },
                {"createdTimestamp", n => { CreatedTimestamp = n.GetLongValue(); } },
                {"credentials", n => { Credentials = n.GetCollectionOfObjectValues<CredentialRepresentation>(CredentialRepresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"disableableCredentialTypes", n => { DisableableCredentialTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"emailVerified", n => { EmailVerified = n.GetBoolValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"federatedIdentities", n => { FederatedIdentities = n.GetCollectionOfObjectValues<FederatedIdentityRepresentation>(FederatedIdentityRepresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"federationLink", n => { FederationLink = n.GetStringValue(); } },
                {"firstName", n => { FirstName = n.GetStringValue(); } },
                {"groups", n => { Groups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"lastName", n => { LastName = n.GetStringValue(); } },
                {"notBefore", n => { NotBefore = n.GetIntValue(); } },
                {"origin", n => { Origin = n.GetStringValue(); } },
                {"realmRoles", n => { RealmRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"requiredActions", n => { RequiredActions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"serviceAccountClientId", n => { ServiceAccountClientId = n.GetStringValue(); } },
                {"socialLinks", n => { SocialLinks = n.GetCollectionOfObjectValues<SocialLinkRepresentation>(SocialLinkRepresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totp", n => { Totp = n.GetBoolValue(); } },
                {"userProfileMetadata", n => { UserProfileMetadata = n.GetObjectValue<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UserProfileMetadata>(Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UserProfileMetadata.CreateFromDiscriminatorValue); } },
                {"username", n => { Username = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UserRepresentation_access>("access", Access);
            writer.WriteObjectValue<UserRepresentation_applicationRoles>("applicationRoles", ApplicationRoles);
            writer.WriteObjectValue<UserRepresentation_attributes>("attributes", Attributes);
            writer.WriteCollectionOfObjectValues<UserConsentRepresentation>("clientConsents", ClientConsents);
            writer.WriteObjectValue<UserRepresentation_clientRoles>("clientRoles", ClientRoles);
            writer.WriteLongValue("createdTimestamp", CreatedTimestamp);
            writer.WriteCollectionOfObjectValues<CredentialRepresentation>("credentials", Credentials);
            writer.WriteCollectionOfPrimitiveValues<string>("disableableCredentialTypes", DisableableCredentialTypes);
            writer.WriteStringValue("email", Email);
            writer.WriteBoolValue("emailVerified", EmailVerified);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteCollectionOfObjectValues<FederatedIdentityRepresentation>("federatedIdentities", FederatedIdentities);
            writer.WriteStringValue("federationLink", FederationLink);
            writer.WriteStringValue("firstName", FirstName);
            writer.WriteCollectionOfPrimitiveValues<string>("groups", Groups);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("lastName", LastName);
            writer.WriteIntValue("notBefore", NotBefore);
            writer.WriteStringValue("origin", Origin);
            writer.WriteCollectionOfPrimitiveValues<string>("realmRoles", RealmRoles);
            writer.WriteCollectionOfPrimitiveValues<string>("requiredActions", RequiredActions);
            writer.WriteStringValue("self", Self);
            writer.WriteStringValue("serviceAccountClientId", ServiceAccountClientId);
            writer.WriteCollectionOfObjectValues<SocialLinkRepresentation>("socialLinks", SocialLinks);
            writer.WriteBoolValue("totp", Totp);
            writer.WriteStringValue("username", Username);
            writer.WriteObjectValue<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UserProfileMetadata>("userProfileMetadata", UserProfileMetadata);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
