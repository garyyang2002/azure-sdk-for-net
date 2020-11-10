// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class Disk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(OsType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OsType.Value.ToSerialString());
            }
            if (Optional.IsDefined(HyperVGeneration))
            {
                writer.WritePropertyName("hyperVGeneration");
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            if (Optional.IsDefined(CreationData))
            {
                writer.WritePropertyName("creationData");
                writer.WriteObjectValue(CreationData);
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(EncryptionSettingsCollection))
            {
                writer.WritePropertyName("encryptionSettingsCollection");
                writer.WriteObjectValue(EncryptionSettingsCollection);
            }
            if (Optional.IsDefined(DiskIopsReadWrite))
            {
                writer.WritePropertyName("diskIOPSReadWrite");
                writer.WriteNumberValue(DiskIopsReadWrite.Value);
            }
            if (Optional.IsDefined(DiskMBpsReadWrite))
            {
                writer.WritePropertyName("diskMBpsReadWrite");
                writer.WriteNumberValue(DiskMBpsReadWrite.Value);
            }
            if (Optional.IsDefined(DiskIopsReadOnly))
            {
                writer.WritePropertyName("diskIOPSReadOnly");
                writer.WriteNumberValue(DiskIopsReadOnly.Value);
            }
            if (Optional.IsDefined(DiskMBpsReadOnly))
            {
                writer.WritePropertyName("diskMBpsReadOnly");
                writer.WriteNumberValue(DiskMBpsReadOnly.Value);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(MaxShares))
            {
                writer.WritePropertyName("maxShares");
                writer.WriteNumberValue(MaxShares.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Disk DeserializeDisk(JsonElement element)
        {
            Optional<string> managedBy = default;
            Optional<IReadOnlyList<string>> managedByExtended = default;
            Optional<DiskSku> sku = default;
            Optional<IList<string>> zones = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<DateTimeOffset> timeCreated = default;
            Optional<OperatingSystemTypes> osType = default;
            Optional<HyperVGeneration> hyperVGeneration = default;
            Optional<CreationData> creationData = default;
            Optional<int> diskSizeGB = default;
            Optional<long> diskSizeBytes = default;
            Optional<string> uniqueId = default;
            Optional<EncryptionSettingsCollection> encryptionSettingsCollection = default;
            Optional<string> provisioningState = default;
            Optional<long> diskIOPSReadWrite = default;
            Optional<long> diskMBpsReadWrite = default;
            Optional<long> diskIOPSReadOnly = default;
            Optional<long> diskMBpsReadOnly = default;
            Optional<DiskState> diskState = default;
            Optional<Encryption> encryption = default;
            Optional<int> maxShares = default;
            Optional<IReadOnlyList<ShareInfoElement>> shareInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByExtended"))
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
                    managedByExtended = array;
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = DiskSku.DeserializeDiskSku(property.Value);
                    continue;
                }
                if (property.NameEquals("zones"))
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
                    zones = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                        if (property0.NameEquals("timeCreated"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("osType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osType = property0.Value.GetString().ToOperatingSystemTypes();
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hyperVGeneration = new HyperVGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationData = CreationData.DeserializeCreationData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("diskSizeGB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskSizeGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("diskSizeBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionSettingsCollection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptionSettingsCollection = EncryptionSettingsCollection.DeserializeEncryptionSettingsCollection(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("diskIOPSReadWrite"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskIOPSReadWrite = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskMBpsReadWrite"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskMBpsReadWrite = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskIOPSReadOnly"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskIOPSReadOnly = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskMBpsReadOnly"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskMBpsReadOnly = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskState = new DiskState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryption = Encryption.DeserializeEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maxShares"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxShares = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("shareInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ShareInfoElement> array = new List<ShareInfoElement>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ShareInfoElement.DeserializeShareInfoElement(item));
                            }
                            shareInfo = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Disk(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), managedBy.Value, Optional.ToList(managedByExtended), sku.Value, Optional.ToList(zones), Optional.ToNullable(timeCreated), Optional.ToNullable(osType), Optional.ToNullable(hyperVGeneration), creationData.Value, Optional.ToNullable(diskSizeGB), Optional.ToNullable(diskSizeBytes), uniqueId.Value, encryptionSettingsCollection.Value, provisioningState.Value, Optional.ToNullable(diskIOPSReadWrite), Optional.ToNullable(diskMBpsReadWrite), Optional.ToNullable(diskIOPSReadOnly), Optional.ToNullable(diskMBpsReadOnly), Optional.ToNullable(diskState), encryption.Value, Optional.ToNullable(maxShares), Optional.ToList(shareInfo));
        }
    }
}
