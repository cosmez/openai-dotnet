// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeServerEventResponseTextDelta : ConversationUpdate
    {
        internal InternalRealtimeServerEventResponseTextDelta(string eventId, string responseId, string itemId, int outputIndex, int contentIndex, string delta) : base(eventId)
        {
            Argument.AssertNotNull(eventId, nameof(eventId));
            Argument.AssertNotNull(responseId, nameof(responseId));
            Argument.AssertNotNull(itemId, nameof(itemId));
            Argument.AssertNotNull(delta, nameof(delta));

            Kind = ConversationUpdateKind.ItemStreamingPartTextDelta;
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            ContentIndex = contentIndex;
            Delta = delta;
        }

        internal InternalRealtimeServerEventResponseTextDelta(ConversationUpdateKind kind, string eventId, IDictionary<string, BinaryData> serializedAdditionalRawData, string responseId, string itemId, int outputIndex, int contentIndex, string delta) : base(kind, eventId, serializedAdditionalRawData)
        {
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            ContentIndex = contentIndex;
            Delta = delta;
        }

        internal InternalRealtimeServerEventResponseTextDelta()
        {
        }

        public string ResponseId { get; }
        public string ItemId { get; }
        public int OutputIndex { get; }
        public int ContentIndex { get; }
        public string Delta { get; }
    }
}