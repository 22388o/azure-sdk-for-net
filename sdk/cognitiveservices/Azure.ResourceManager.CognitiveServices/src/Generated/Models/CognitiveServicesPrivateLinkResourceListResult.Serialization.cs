// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class CognitiveServicesPrivateLinkResourceListResult
    {
        internal static CognitiveServicesPrivateLinkResourceListResult DeserializeCognitiveServicesPrivateLinkResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CognitiveServicesPrivateLinkResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CognitiveServicesPrivateLinkResource> array = new List<CognitiveServicesPrivateLinkResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CognitiveServicesPrivateLinkResource.DeserializeCognitiveServicesPrivateLinkResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CognitiveServicesPrivateLinkResourceListResult(Optional.ToList(value));
        }
    }
}
