// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchServiceCounters
    {
        internal static SearchServiceCounters DeserializeSearchServiceCounters(JsonElement element)
        {
            SearchResourceCounter documentCount = default;
            SearchResourceCounter indexesCount = default;
            SearchResourceCounter indexersCount = default;
            SearchResourceCounter dataSourcesCount = default;
            SearchResourceCounter storageSize = default;
            SearchResourceCounter synonymMaps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentCount"))
                {
                    documentCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("indexesCount"))
                {
                    indexesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("indexersCount"))
                {
                    indexersCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourcesCount"))
                {
                    dataSourcesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("storageSize"))
                {
                    storageSize = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("synonymMaps"))
                {
                    synonymMaps = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
            }
            return new SearchServiceCounters(documentCount, indexesCount, indexersCount, dataSourcesCount, storageSize, synonymMaps);
        }
    }
}
