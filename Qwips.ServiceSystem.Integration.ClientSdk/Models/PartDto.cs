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
    public partial class PartDto : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ArticleDescription property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleDescription { get; set; }
#nullable restore
#else
        public string ArticleDescription { get; set; }
#endif
        /// <summary>The ArticleDescriptionLong property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleDescriptionLong { get; set; }
#nullable restore
#else
        public string ArticleDescriptionLong { get; set; }
#endif
        /// <summary>The ArticleImage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleImage { get; set; }
#nullable restore
#else
        public string ArticleImage { get; set; }
#endif
        /// <summary>The ArticleNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleNumber { get; set; }
#nullable restore
#else
        public string ArticleNumber { get; set; }
#endif
        /// <summary>The ArticlePrice property</summary>
        public double? ArticlePrice { get; set; }
        /// <summary>The ArticlePriceIn property</summary>
        public double? ArticlePriceIn { get; set; }
        /// <summary>The CentralSystemId property</summary>
        public int? CentralSystemId { get; set; }
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The Internal property</summary>
        public bool? Internal { get; set; }
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>The IsStoreArticle property</summary>
        public bool? IsStoreArticle { get; set; }
        /// <summary>The Modified property</summary>
        public DateTimeOffset? Modified { get; set; }
        /// <summary>The SalesText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SalesText { get; set; }
#nullable restore
#else
        public string SalesText { get; set; }
#endif
        /// <summary>The StoreItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.GenericStoreItemDataModel>? StoreItems { get; set; }
#nullable restore
#else
        public List<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.GenericStoreItemDataModel> StoreItems { get; set; }
#endif
        /// <summary>The SupplierId property</summary>
        public int? SupplierId { get; set; }
        /// <summary>The TechnicianSparePart property</summary>
        public bool? TechnicianSparePart { get; set; }
        /// <summary>The VatRate property</summary>
        public double? VatRate { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.PartDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Qwips.ServiceSystem.Integration.ClientSdk.Models.PartDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Models.PartDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ArticleDescription", n => { ArticleDescription = n.GetStringValue(); } },
                { "ArticleDescriptionLong", n => { ArticleDescriptionLong = n.GetStringValue(); } },
                { "ArticleImage", n => { ArticleImage = n.GetStringValue(); } },
                { "ArticleNumber", n => { ArticleNumber = n.GetStringValue(); } },
                { "ArticlePrice", n => { ArticlePrice = n.GetDoubleValue(); } },
                { "ArticlePriceIn", n => { ArticlePriceIn = n.GetDoubleValue(); } },
                { "CentralSystemId", n => { CentralSystemId = n.GetIntValue(); } },
                { "Id", n => { Id = n.GetIntValue(); } },
                { "Internal", n => { Internal = n.GetBoolValue(); } },
                { "IsActive", n => { IsActive = n.GetBoolValue(); } },
                { "IsStoreArticle", n => { IsStoreArticle = n.GetBoolValue(); } },
                { "Modified", n => { Modified = n.GetDateTimeOffsetValue(); } },
                { "SalesText", n => { SalesText = n.GetStringValue(); } },
                { "StoreItems", n => { StoreItems = n.GetCollectionOfObjectValues<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.GenericStoreItemDataModel>(global::Qwips.ServiceSystem.Integration.ClientSdk.Models.GenericStoreItemDataModel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "SupplierId", n => { SupplierId = n.GetIntValue(); } },
                { "TechnicianSparePart", n => { TechnicianSparePart = n.GetBoolValue(); } },
                { "VatRate", n => { VatRate = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ArticleDescription", ArticleDescription);
            writer.WriteStringValue("ArticleDescriptionLong", ArticleDescriptionLong);
            writer.WriteStringValue("ArticleImage", ArticleImage);
            writer.WriteStringValue("ArticleNumber", ArticleNumber);
            writer.WriteDoubleValue("ArticlePrice", ArticlePrice);
            writer.WriteDoubleValue("ArticlePriceIn", ArticlePriceIn);
            writer.WriteIntValue("CentralSystemId", CentralSystemId);
            writer.WriteIntValue("Id", Id);
            writer.WriteBoolValue("Internal", Internal);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteBoolValue("IsStoreArticle", IsStoreArticle);
            writer.WriteDateTimeOffsetValue("Modified", Modified);
            writer.WriteStringValue("SalesText", SalesText);
            writer.WriteCollectionOfObjectValues<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.GenericStoreItemDataModel>("StoreItems", StoreItems);
            writer.WriteIntValue("SupplierId", SupplierId);
            writer.WriteBoolValue("TechnicianSparePart", TechnicianSparePart);
            writer.WriteDoubleValue("VatRate", VatRate);
        }
    }
}
#pragma warning restore CS0618