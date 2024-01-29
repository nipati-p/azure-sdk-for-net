// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DiscoveryConfiguration : IUtf8JsonSerializable, IJsonModel<DiscoveryConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiscoveryConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiscoveryConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CentralServerVmId))
            {
                writer.WritePropertyName("centralServerVmId"u8);
                writer.WriteStringValue(CentralServerVmId);
            }
            if (Optional.IsDefined(ManagedRgStorageAccountName))
            {
                writer.WritePropertyName("managedRgStorageAccountName"u8);
                writer.WriteStringValue(ManagedRgStorageAccountName);
            }
            if (options.Format != "W" && Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation"u8);
                writer.WriteStringValue(AppLocation.Value);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DiscoveryConfiguration IJsonModel<DiscoveryConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiscoveryConfiguration(document.RootElement, options);
        }

        internal static DiscoveryConfiguration DeserializeDiscoveryConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> centralServerVmId = default;
            Optional<string> managedRgStorageAccountName = default;
            Optional<AzureLocation> appLocation = default;
            SapConfigurationType configurationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("centralServerVmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    centralServerVmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedRgStorageAccountName"u8))
                {
                    managedRgStorageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new SapConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiscoveryConfiguration(configurationType, serializedAdditionalRawData, centralServerVmId.Value, managedRgStorageAccountName.Value, Optional.ToNullable(appLocation));
        }

        BinaryData IPersistableModel<DiscoveryConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiscoveryConfiguration)} does not support '{options.Format}' format.");
            }
        }

        DiscoveryConfiguration IPersistableModel<DiscoveryConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiscoveryConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiscoveryConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiscoveryConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
