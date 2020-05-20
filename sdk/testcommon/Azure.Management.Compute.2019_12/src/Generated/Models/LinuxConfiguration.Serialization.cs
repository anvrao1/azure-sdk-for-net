// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class LinuxConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DisablePasswordAuthentication != null)
            {
                writer.WritePropertyName("disablePasswordAuthentication");
                writer.WriteBooleanValue(DisablePasswordAuthentication.Value);
            }
            if (Ssh != null)
            {
                writer.WritePropertyName("ssh");
                writer.WriteObjectValue(Ssh);
            }
            if (ProvisionVMAgent != null)
            {
                writer.WritePropertyName("provisionVMAgent");
                writer.WriteBooleanValue(ProvisionVMAgent.Value);
            }
            writer.WriteEndObject();
        }

        internal static LinuxConfiguration DeserializeLinuxConfiguration(JsonElement element)
        {
            bool? disablePasswordAuthentication = default;
            SshConfiguration ssh = default;
            bool? provisionVMAgent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disablePasswordAuthentication"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disablePasswordAuthentication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ssh"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssh = SshConfiguration.DeserializeSshConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("provisionVMAgent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisionVMAgent = property.Value.GetBoolean();
                    continue;
                }
            }
            return new LinuxConfiguration(disablePasswordAuthentication, ssh, provisionVMAgent);
        }
    }
}
