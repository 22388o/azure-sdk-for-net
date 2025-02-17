// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class ServiceAccountApiProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QnaRuntimeEndpoint))
            {
                writer.WritePropertyName("qnaRuntimeEndpoint");
                writer.WriteStringValue(QnaRuntimeEndpoint);
            }
            if (Optional.IsDefined(QnaAzureSearchEndpointKey))
            {
                writer.WritePropertyName("qnaAzureSearchEndpointKey");
                writer.WriteStringValue(QnaAzureSearchEndpointKey);
            }
            if (Optional.IsDefined(QnaAzureSearchEndpointId))
            {
                writer.WritePropertyName("qnaAzureSearchEndpointId");
                writer.WriteStringValue(QnaAzureSearchEndpointId);
            }
            if (Optional.IsDefined(EnableStatistics))
            {
                writer.WritePropertyName("statisticsEnabled");
                writer.WriteBooleanValue(EnableStatistics.Value);
            }
            if (Optional.IsDefined(EventHubConnectionString))
            {
                writer.WritePropertyName("eventHubConnectionString");
                writer.WriteStringValue(EventHubConnectionString);
            }
            if (Optional.IsDefined(StorageAccountConnectionString))
            {
                writer.WritePropertyName("storageAccountConnectionString");
                writer.WriteStringValue(StorageAccountConnectionString);
            }
            if (Optional.IsDefined(AadClientId))
            {
                writer.WritePropertyName("aadClientId");
                writer.WriteStringValue(AadClientId.Value);
            }
            if (Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId");
                writer.WriteStringValue(AadTenantId.Value);
            }
            if (Optional.IsDefined(SuperUser))
            {
                writer.WritePropertyName("superUser");
                writer.WriteStringValue(SuperUser);
            }
            if (Optional.IsDefined(WebsiteName))
            {
                writer.WritePropertyName("websiteName");
                writer.WriteStringValue(WebsiteName);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ServiceAccountApiProperties DeserializeServiceAccountApiProperties(JsonElement element)
        {
            Optional<string> qnaRuntimeEndpoint = default;
            Optional<string> qnaAzureSearchEndpointKey = default;
            Optional<ResourceIdentifier> qnaAzureSearchEndpointId = default;
            Optional<bool> statisticsEnabled = default;
            Optional<string> eventHubConnectionString = default;
            Optional<string> storageAccountConnectionString = default;
            Optional<Guid> aadClientId = default;
            Optional<Guid> aadTenantId = default;
            Optional<string> superUser = default;
            Optional<string> websiteName = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("qnaRuntimeEndpoint"))
                {
                    qnaRuntimeEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qnaAzureSearchEndpointKey"))
                {
                    qnaAzureSearchEndpointKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qnaAzureSearchEndpointId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    qnaAzureSearchEndpointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statisticsEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statisticsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("eventHubConnectionString"))
                {
                    eventHubConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountConnectionString"))
                {
                    storageAccountConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadClientId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    aadClientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("aadTenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    aadTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("superUser"))
                {
                    superUser = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("websiteName"))
                {
                    websiteName = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ServiceAccountApiProperties(qnaRuntimeEndpoint.Value, qnaAzureSearchEndpointKey.Value, qnaAzureSearchEndpointId.Value, Optional.ToNullable(statisticsEnabled), eventHubConnectionString.Value, storageAccountConnectionString.Value, Optional.ToNullable(aadClientId), Optional.ToNullable(aadTenantId), superUser.Value, websiteName.Value, additionalProperties);
        }
    }
}
