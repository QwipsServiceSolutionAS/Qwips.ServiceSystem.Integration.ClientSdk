// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ApiErrorResponse : ApiException, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The AdditionalParameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Models.AdditionalExceptionParameters? AdditionalParameters { get; set; }
#nullable restore
#else
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Models.AdditionalExceptionParameters AdditionalParameters { get; set; }
#endif
        /// <summary>The Errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Errors { get; set; }
#nullable restore
#else
        public List<string> Errors { get; set; }
#endif
        /// <summary>The ExceptionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExceptionId { get; set; }
#nullable restore
#else
        public string ExceptionId { get; set; }
#endif
        /// <summary>The InnerException property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InnerExceptionEscaped { get; set; }
#nullable restore
#else
        public string InnerExceptionEscaped { get; set; }
#endif
        /// <summary>The primary error message.</summary>
        public override string Message { get => MessageEscaped ?? string.Empty; }
        /// <summary>The Message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageEscaped { get; set; }
#nullable restore
#else
        public string MessageEscaped { get; set; }
#endif
        /// <summary>The ReasonCode property</summary>
        public int? ReasonCode { get; set; }
        /// <summary>The StatusCode property</summary>
        public int? StatusCode { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.ApiErrorResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Qwips.ServiceSystem.Integration.ClientSdk.Models.ApiErrorResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Models.ApiErrorResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AdditionalParameters", n => { AdditionalParameters = n.GetObjectValue<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.AdditionalExceptionParameters>(global::Qwips.ServiceSystem.Integration.ClientSdk.Models.AdditionalExceptionParameters.CreateFromDiscriminatorValue); } },
                { "Errors", n => { Errors = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "ExceptionId", n => { ExceptionId = n.GetStringValue(); } },
                { "InnerException", n => { InnerExceptionEscaped = n.GetStringValue(); } },
                { "Message", n => { MessageEscaped = n.GetStringValue(); } },
                { "ReasonCode", n => { ReasonCode = n.GetIntValue(); } },
                { "StatusCode", n => { StatusCode = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.AdditionalExceptionParameters>("AdditionalParameters", AdditionalParameters);
            writer.WriteCollectionOfPrimitiveValues<string>("Errors", Errors);
            writer.WriteStringValue("ExceptionId", ExceptionId);
            writer.WriteStringValue("InnerException", InnerExceptionEscaped);
            writer.WriteStringValue("Message", MessageEscaped);
            writer.WriteIntValue("ReasonCode", ReasonCode);
            writer.WriteIntValue("StatusCode", StatusCode);
        }
    }
}
#pragma warning restore CS0618
