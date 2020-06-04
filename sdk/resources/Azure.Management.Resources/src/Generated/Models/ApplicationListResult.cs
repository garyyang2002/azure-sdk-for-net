// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Resources.Models
{
    /// <summary> List of managed applications. </summary>
    public partial class ApplicationListResult
    {
        /// <summary> Initializes a new instance of ApplicationListResult. </summary>
        internal ApplicationListResult()
        {
        }

        /// <summary> Initializes a new instance of ApplicationListResult. </summary>
        /// <param name="value"> The array of managed applications. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ApplicationListResult(IReadOnlyList<Application> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The array of managed applications. </summary>
        public IReadOnlyList<Application> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
