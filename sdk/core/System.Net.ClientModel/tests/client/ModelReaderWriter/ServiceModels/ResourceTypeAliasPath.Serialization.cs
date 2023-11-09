// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using System.Text.Json;

namespace System.Net.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    public partial class ResourceTypeAliasPath : IJsonModel<ResourceTypeAliasPath>
    {
        internal static ResourceTypeAliasPath DeserializeResourceTypeAliasPath(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> path = default;
            OptionalProperty<IReadOnlyList<string>> apiVersions = default;
            OptionalProperty<ResourceTypeAliasPattern> pattern = default;
            OptionalProperty<ResourceTypeAliasPathMetadata> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("pattern"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pattern = ResourceTypeAliasPattern.DeserializeResourceTypeAliasPattern(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = ResourceTypeAliasPathMetadata.DeserializeResourceTypeAliasPathMetadata(property.Value, options);
                    continue;
                }
            }
            return new ResourceTypeAliasPath(path.Value, OptionalProperty.ToList(apiVersions), pattern.Value, metadata.Value);
        }

        void IJsonModel<ResourceTypeAliasPath>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (OptionalProperty.IsCollectionDefined(ApiVersions))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteObjectValue(Pattern);
            }
            if (OptionalProperty.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata);
            }
            writer.WriteEndObject();
        }

        private struct ResourceTypeAliasPathProperties
        {
            public OptionalProperty<string> Path { get; set; }
            public OptionalProperty<IReadOnlyList<string>> ApiVersions { get; set; }
            public OptionalProperty<ResourceTypeAliasPattern> Pattern { get; set; }
            public OptionalProperty<ResourceTypeAliasPathMetadata> Metadata { get; set; }
        }

        ResourceTypeAliasPath IJsonModel<ResourceTypeAliasPath>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeAliasPath(doc.RootElement, options);
        }

        ResourceTypeAliasPath IModel<ResourceTypeAliasPath>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceTypeAliasPath(doc.RootElement, options);
        }

        BinaryData IModel<ResourceTypeAliasPath>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IModel<ResourceTypeAliasPath>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
