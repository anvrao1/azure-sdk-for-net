// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class TerminateNotificationProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (NotBeforeTimeout != null)
            {
                writer.WritePropertyName("notBeforeTimeout");
                writer.WriteStringValue(NotBeforeTimeout);
            }
            if (Enable != null)
            {
                writer.WritePropertyName("enable");
                writer.WriteBooleanValue(Enable.Value);
            }
            writer.WriteEndObject();
        }

        internal static TerminateNotificationProfile DeserializeTerminateNotificationProfile(JsonElement element)
        {
            string notBeforeTimeout = default;
            bool? enable = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notBeforeTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notBeforeTimeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
            }
            return new TerminateNotificationProfile(notBeforeTimeout, enable);
        }
    }
}
