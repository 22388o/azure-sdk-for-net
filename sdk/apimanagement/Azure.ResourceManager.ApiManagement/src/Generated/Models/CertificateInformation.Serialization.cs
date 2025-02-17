// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class CertificateInformation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("expiry");
            writer.WriteStringValue(ExpiresOn, "O");
            writer.WritePropertyName("thumbprint");
            writer.WriteStringValue(Thumbprint);
            writer.WritePropertyName("subject");
            writer.WriteStringValue(Subject);
            writer.WriteEndObject();
        }

        internal static CertificateInformation DeserializeCertificateInformation(JsonElement element)
        {
            DateTimeOffset expiry = default;
            string thumbprint = default;
            string subject = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiry"))
                {
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("thumbprint"))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subject"))
                {
                    subject = property.Value.GetString();
                    continue;
                }
            }
            return new CertificateInformation(expiry, thumbprint, subject);
        }
    }
}
