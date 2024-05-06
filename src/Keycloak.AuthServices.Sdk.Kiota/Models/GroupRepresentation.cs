// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models {
    public class GroupRepresentation : IAdditionalDataHolder, IParsable {
        /// <summary>The access property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GroupRepresentation_access? Access { get; set; }
#nullable restore
#else
        public GroupRepresentation_access Access { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GroupRepresentation_attributes? Attributes { get; set; }
#nullable restore
#else
        public GroupRepresentation_attributes Attributes { get; set; }
#endif
        /// <summary>The clientRoles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GroupRepresentation_clientRoles? ClientRoles { get; set; }
#nullable restore
#else
        public GroupRepresentation_clientRoles ClientRoles { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The parentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentId { get; set; }
#nullable restore
#else
        public string ParentId { get; set; }
#endif
        /// <summary>The path property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The realmRoles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RealmRoles { get; set; }
#nullable restore
#else
        public List<string> RealmRoles { get; set; }
#endif
        /// <summary>The subGroupCount property</summary>
        public long? SubGroupCount { get; set; }
        /// <summary>The subGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupRepresentation>? SubGroups { get; set; }
#nullable restore
#else
        public List<GroupRepresentation> SubGroups { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GroupRepresentation"/> and sets the default values.
        /// </summary>
        public GroupRepresentation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GroupRepresentation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GroupRepresentation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupRepresentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"access", n => { Access = n.GetObjectValue<GroupRepresentation_access>(GroupRepresentation_access.CreateFromDiscriminatorValue); } },
                {"attributes", n => { Attributes = n.GetObjectValue<GroupRepresentation_attributes>(GroupRepresentation_attributes.CreateFromDiscriminatorValue); } },
                {"clientRoles", n => { ClientRoles = n.GetObjectValue<GroupRepresentation_clientRoles>(GroupRepresentation_clientRoles.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"parentId", n => { ParentId = n.GetStringValue(); } },
                {"path", n => { Path = n.GetStringValue(); } },
                {"realmRoles", n => { RealmRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"subGroupCount", n => { SubGroupCount = n.GetLongValue(); } },
                {"subGroups", n => { SubGroups = n.GetCollectionOfObjectValues<GroupRepresentation>(GroupRepresentation.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<GroupRepresentation_access>("access", Access);
            writer.WriteObjectValue<GroupRepresentation_attributes>("attributes", Attributes);
            writer.WriteObjectValue<GroupRepresentation_clientRoles>("clientRoles", ClientRoles);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteStringValue("path", Path);
            writer.WriteCollectionOfPrimitiveValues<string>("realmRoles", RealmRoles);
            writer.WriteLongValue("subGroupCount", SubGroupCount);
            writer.WriteCollectionOfObjectValues<GroupRepresentation>("subGroups", SubGroups);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}