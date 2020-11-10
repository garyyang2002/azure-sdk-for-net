// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The response to a list partition level usage request. </summary>
    public partial class PartitionUsagesResult
    {
        /// <summary> Initializes a new instance of PartitionUsagesResult. </summary>
        internal PartitionUsagesResult()
        {
            Value = new ChangeTrackingList<PartitionUsage>();
        }

        /// <summary> Initializes a new instance of PartitionUsagesResult. </summary>
        /// <param name="value"> The list of partition-level usages for the database. A usage is a point in time metric. </param>
        internal PartitionUsagesResult(IReadOnlyList<PartitionUsage> value)
        {
            Value = value;
        }

        /// <summary> The list of partition-level usages for the database. A usage is a point in time metric. </summary>
        public IReadOnlyList<PartitionUsage> Value { get; }
    }
}
