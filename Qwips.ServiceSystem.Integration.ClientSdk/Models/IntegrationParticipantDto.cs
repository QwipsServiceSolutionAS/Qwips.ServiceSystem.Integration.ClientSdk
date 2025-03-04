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
    public partial class IntegrationParticipantDto : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The ParticipantStatus property</summary>
        public int? ParticipantStatus { get; set; }
        /// <summary>The User property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Models.UserDto? User { get; set; }
#nullable restore
#else
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Models.UserDto User { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationParticipantDto"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationParticipantDto CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Qwips.ServiceSystem.Integration.ClientSdk.Models.IntegrationParticipantDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Id", n => { Id = n.GetIntValue(); } },
                { "ParticipantStatus", n => { ParticipantStatus = n.GetIntValue(); } },
                { "User", n => { User = n.GetObjectValue<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.UserDto>(global::Qwips.ServiceSystem.Integration.ClientSdk.Models.UserDto.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("Id", Id);
            writer.WriteIntValue("ParticipantStatus", ParticipantStatus);
            writer.WriteObjectValue<global::Qwips.ServiceSystem.Integration.ClientSdk.Models.UserDto>("User", User);
        }
    }
}
#pragma warning restore CS0618
