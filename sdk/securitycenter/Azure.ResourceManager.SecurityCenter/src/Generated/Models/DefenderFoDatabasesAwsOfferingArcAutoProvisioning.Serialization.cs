// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderFoDatabasesAwsOfferingArcAutoProvisioning : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(CloudRoleArn))
            {
                writer.WritePropertyName("cloudRoleArn");
                writer.WriteStringValue(CloudRoleArn);
            }
            if (Optional.IsDefined(ServicePrincipalSecretMetadata))
            {
                writer.WritePropertyName("servicePrincipalSecretMetadata");
                writer.WriteObjectValue(ServicePrincipalSecretMetadata);
            }
            writer.WriteEndObject();
        }

        internal static DefenderFoDatabasesAwsOfferingArcAutoProvisioning DeserializeDefenderFoDatabasesAwsOfferingArcAutoProvisioning(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<string> cloudRoleArn = default;
            Optional<DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata> servicePrincipalSecretMetadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloudRoleArn"))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalSecretMetadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    servicePrincipalSecretMetadata = DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata.DeserializeDefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata(property.Value);
                    continue;
                }
            }
            return new DefenderFoDatabasesAwsOfferingArcAutoProvisioning(Optional.ToNullable(enabled), cloudRoleArn.Value, servicePrincipalSecretMetadata.Value);
        }
    }
}
