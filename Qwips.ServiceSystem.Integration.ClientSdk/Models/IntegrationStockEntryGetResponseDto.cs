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
    public partial class IntegrationStockEntryGetResponseDto : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ArticleId property</summary>
        public int? ArticleId { get; set; }
        /// <summary>The ArticleNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleNumber { get; set; }
#nullable restore
#else
        public string ArticleNumber { get; set; }
#endif
        /// <summary>The Available property</summary>
        public double? Available { get; set; }
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
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
        /// <summary>The WarehouseId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WarehouseId { get; set; }
#nullable restore
#else
        public string WarehouseId { get; set; }
#endif
        /// <summary>The WarehouseLocationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WarehouseLocationId { get; set; }
#nullable restore
#else
        public string WarehouseLocationId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationStockEntryGetResponseDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationStockEntryGetResponseDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationStockEntryGetResponseDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ArticleId", n => { ArticleId = n.GetIntValue(); } },
                { "ArticleNumber", n => { ArticleNumber = n.GetStringValue(); } },
                { "Available", n => { Available = n.GetDoubleValue(); } },
                { "Id", n => { Id = n.GetIntValue(); } },
                { "StoreLocationName", n => { StoreLocationName = n.GetStringValue(); } },
                { "StoreName", n => { StoreName = n.GetStringValue(); } },
                { "WarehouseId", n => { WarehouseId = n.GetStringValue(); } },
                { "WarehouseLocationId", n => { WarehouseLocationId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("ArticleId", ArticleId);
            writer.WriteStringValue("ArticleNumber", ArticleNumber);
            writer.WriteDoubleValue("Available", Available);
            writer.WriteIntValue("Id", Id);
            writer.WriteStringValue("StoreLocationName", StoreLocationName);
            writer.WriteStringValue("StoreName", StoreName);
            writer.WriteStringValue("WarehouseId", WarehouseId);
            writer.WriteStringValue("WarehouseLocationId", WarehouseLocationId);
        }
    }
}
#pragma warning restore CS0618