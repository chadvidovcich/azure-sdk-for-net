// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class ClusterIdentityResponse
    {
        internal static ClusterIdentityResponse DeserializeClusterIdentityResponse(JsonElement element)
        {
            Optional<string> aadClientId = default;
            Optional<string> aadTenantId = default;
            Optional<string> aadServicePrincipalObjectId = default;
            Optional<string> aadApplicationObjectId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("aadClientId"))
                        {
                            aadClientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"))
                        {
                            aadTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadServicePrincipalObjectId"))
                        {
                            aadServicePrincipalObjectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadApplicationObjectId"))
                        {
                            aadApplicationObjectId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ClusterIdentityResponse(aadClientId.Value, aadTenantId.Value, aadServicePrincipalObjectId.Value, aadApplicationObjectId.Value);
        }
    }
}
