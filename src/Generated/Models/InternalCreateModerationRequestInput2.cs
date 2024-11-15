// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Moderations
{
    internal partial class InternalCreateModerationRequestInput2
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        public InternalCreateModerationRequestInput2(InternalCreateModerationRequestInputImageUrl imageUrl)
        {
            Argument.AssertNotNull(imageUrl, nameof(imageUrl));

            ImageUrl = imageUrl;
        }

        internal InternalCreateModerationRequestInput2(InternalCreateModerationRequestInput2Type type, InternalCreateModerationRequestInputImageUrl imageUrl, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            ImageUrl = imageUrl;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCreateModerationRequestInput2()
        {
        }

        public InternalCreateModerationRequestInput2Type Type { get; } = InternalCreateModerationRequestInput2Type.ImageUrl;

        public InternalCreateModerationRequestInputImageUrl ImageUrl { get; }
    }
}
