// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkVirtualApplianceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(NvaSku))
            {
                writer.WritePropertyName("nvaSku");
                writer.WriteObjectValue(NvaSku);
            }
            if (Optional.IsCollectionDefined(BootStrapConfigurationBlobs))
            {
                writer.WritePropertyName("bootStrapConfigurationBlobs");
                writer.WriteStartArray();
                foreach (var item in BootStrapConfigurationBlobs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub");
                JsonSerializer.Serialize(writer, VirtualHub);
            }
            if (Optional.IsCollectionDefined(CloudInitConfigurationBlobs))
            {
                writer.WritePropertyName("cloudInitConfigurationBlobs");
                writer.WriteStartArray();
                foreach (var item in CloudInitConfigurationBlobs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CloudInitConfiguration))
            {
                writer.WritePropertyName("cloudInitConfiguration");
                writer.WriteStringValue(CloudInitConfiguration);
            }
            if (Optional.IsDefined(VirtualApplianceAsn))
            {
                writer.WritePropertyName("virtualApplianceAsn");
                writer.WriteNumberValue(VirtualApplianceAsn.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkVirtualApplianceData DeserializeNetworkVirtualApplianceData(JsonElement element)
        {
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<VirtualApplianceSkuProperties> nvaSku = default;
            Optional<string> addressPrefix = default;
            Optional<IList<string>> bootStrapConfigurationBlobs = default;
            Optional<WritableSubResource> virtualHub = default;
            Optional<IList<string>> cloudInitConfigurationBlobs = default;
            Optional<string> cloudInitConfiguration = default;
            Optional<long> virtualApplianceAsn = default;
            Optional<IReadOnlyList<VirtualApplianceNicProperties>> virtualApplianceNics = default;
            Optional<IReadOnlyList<WritableSubResource>> virtualApplianceSites = default;
            Optional<IReadOnlyList<WritableSubResource>> inboundSecurityRules = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("nvaSku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            nvaSku = VirtualApplianceSkuProperties.DeserializeVirtualApplianceSkuProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bootStrapConfigurationBlobs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            bootStrapConfigurationBlobs = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualHub"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualHub = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("cloudInitConfigurationBlobs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            cloudInitConfigurationBlobs = array;
                            continue;
                        }
                        if (property0.NameEquals("cloudInitConfiguration"))
                        {
                            cloudInitConfiguration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceAsn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualApplianceAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceNics"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VirtualApplianceNicProperties> array = new List<VirtualApplianceNicProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualApplianceNicProperties.DeserializeVirtualApplianceNicProperties(item));
                            }
                            virtualApplianceNics = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceSites"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            virtualApplianceSites = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundSecurityRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            inboundSecurityRules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkVirtualApplianceData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), identity, Optional.ToNullable(etag), nvaSku.Value, addressPrefix.Value, Optional.ToList(bootStrapConfigurationBlobs), virtualHub, Optional.ToList(cloudInitConfigurationBlobs), cloudInitConfiguration.Value, Optional.ToNullable(virtualApplianceAsn), Optional.ToList(virtualApplianceNics), Optional.ToList(virtualApplianceSites), Optional.ToList(inboundSecurityRules), Optional.ToNullable(provisioningState));
        }
    }
}
