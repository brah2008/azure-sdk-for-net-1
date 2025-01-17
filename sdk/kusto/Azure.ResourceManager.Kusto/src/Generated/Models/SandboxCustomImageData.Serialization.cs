// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto
{
    public partial class SandboxCustomImageData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language.Value.ToString());
            }
            if (Optional.IsDefined(LanguageVersion))
            {
                writer.WritePropertyName("languageVersion"u8);
                writer.WriteStringValue(LanguageVersion);
            }
            if (Optional.IsDefined(RequirementsFileContent))
            {
                writer.WritePropertyName("requirementsFileContent"u8);
                writer.WriteStringValue(RequirementsFileContent);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SandboxCustomImageData DeserializeSandboxCustomImageData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SandboxCustomImageLanguage> language = default;
            Optional<string> languageVersion = default;
            Optional<string> requirementsFileContent = default;
            Optional<KustoProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("language"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            language = new SandboxCustomImageLanguage(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("languageVersion"u8))
                        {
                            languageVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requirementsFileContent"u8))
                        {
                            requirementsFileContent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new KustoProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SandboxCustomImageData(id, name, type, systemData.Value, Optional.ToNullable(language), languageVersion.Value, requirementsFileContent.Value, Optional.ToNullable(provisioningState));
        }
    }
}
