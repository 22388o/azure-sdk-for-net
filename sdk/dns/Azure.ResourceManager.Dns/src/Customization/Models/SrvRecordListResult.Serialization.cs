// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Dns;

namespace Azure.ResourceManager.Dns.Models
{
    internal partial class SrvRecordListResult
    {
        internal static SrvRecordListResult DeserializeSrvRecordSetListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SrvRecordData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SrvRecordData> array = new List<SrvRecordData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SrvRecordData.DeserializeSrvRecordData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SrvRecordListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
