// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class BackendCredentialsContract : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CertificateIds))
            {
                writer.WritePropertyName("certificateIds");
                writer.WriteStartArray();
                foreach (var item in CertificateIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Certificate))
            {
                writer.WritePropertyName("certificate");
                writer.WriteStartArray();
                foreach (var item in Certificate)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Query))
            {
                writer.WritePropertyName("query");
                writer.WriteStartObject();
                foreach (var item in Query)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Header))
            {
                writer.WritePropertyName("header");
                writer.WriteStartObject();
                foreach (var item in Header)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Authorization))
            {
                writer.WritePropertyName("authorization");
                writer.WriteObjectValue(Authorization);
            }
            writer.WriteEndObject();
        }

        internal static BackendCredentialsContract DeserializeBackendCredentialsContract(JsonElement element)
        {
            Optional<IList<string>> certificateIds = default;
            Optional<IList<string>> certificate = default;
            Optional<IDictionary<string, IList<string>>> query = default;
            Optional<IDictionary<string, IList<string>>> header = default;
            Optional<BackendAuthorizationHeaderCredentials> authorization = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    certificateIds = array;
                    continue;
                }
                if (property.NameEquals("certificate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    certificate = array;
                    continue;
                }
                if (property.NameEquals("query"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        List<string> array = new List<string>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            array.Add(item.GetString());
                        }
                        dictionary.Add(property0.Name, array);
                    }
                    query = dictionary;
                    continue;
                }
                if (property.NameEquals("header"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        List<string> array = new List<string>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            array.Add(item.GetString());
                        }
                        dictionary.Add(property0.Name, array);
                    }
                    header = dictionary;
                    continue;
                }
                if (property.NameEquals("authorization"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authorization = BackendAuthorizationHeaderCredentials.DeserializeBackendAuthorizationHeaderCredentials(property.Value);
                    continue;
                }
            }
            return new BackendCredentialsContract(Optional.ToList(certificateIds), Optional.ToList(certificate), Optional.ToDictionary(query), Optional.ToDictionary(header), authorization.Value);
        }
    }
}
