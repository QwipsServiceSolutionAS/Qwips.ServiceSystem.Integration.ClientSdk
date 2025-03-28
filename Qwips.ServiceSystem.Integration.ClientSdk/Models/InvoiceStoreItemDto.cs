// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class InvoiceStoreItemDto : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Available property</summary>
        public double? Available { get; set; }
        /// <summary>The DisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; private set; }
#nullable restore
#else
        public string DisplayName { get; private set; }
#endif
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The StoreId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StoreId { get; set; }
#nullable restore
#else
        public string StoreId { get; set; }
#endif
        /// <summary>The StoreLocationName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StoreLocationName { get; set; }
#nullable restore
#else
        public string StoreLocationName { get; set; }
#endif
        /// <summary>The StoreName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StoreName { get; set; }
#nullable restore
#else
        public string StoreName { get; set; }
#endif
        /// <summary>The SupplierOrder property</summary>
        public double? SupplierOrder { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.InvoiceStoreItemDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Qwips.ServiceSystem.Integration.ClientSdk.Models.InvoiceStoreItemDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Models.InvoiceStoreItemDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Available", n => { Available = n.GetDoubleValue(); } },
                { "DisplayName", n => { DisplayName = n.GetStringValue(); } },
                { "Id", n => { Id = n.GetIntValue(); } },
                { "StoreId", n => { StoreId = n.GetStringValue(); } },
                { "StoreLocationName", n => { StoreLocationName = n.GetStringValue(); } },
                { "StoreName", n => { StoreName = n.GetStringValue(); } },
                { "SupplierOrder", n => { SupplierOrder = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Available", Available);
            writer.WriteIntValue("Id", Id);
            writer.WriteStringValue("StoreId", StoreId);
            writer.WriteStringValue("StoreLocationName", StoreLocationName);
            writer.WriteStringValue("StoreName", StoreName);
            writer.WriteDoubleValue("SupplierOrder", SupplierOrder);
        }
    }
}
#pragma warning restore CS0618
