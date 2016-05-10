// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The access keys for the cognitive services account.
    /// </summary>
    public partial class CognitiveServicesAccountKeys
    {
        /// <summary>
        /// Initializes a new instance of the CognitiveServicesAccountKeys
        /// class.
        /// </summary>
        public CognitiveServicesAccountKeys() { }

        /// <summary>
        /// Initializes a new instance of the CognitiveServicesAccountKeys
        /// class.
        /// </summary>
        public CognitiveServicesAccountKeys(string key1 = default(string), string key2 = default(string))
        {
            Key1 = key1;
            Key2 = key2;
        }

        /// <summary>
        /// Gets the value of key 1.
        /// </summary>
        [JsonProperty(PropertyName = "key1")]
        public string Key1 { get; set; }

        /// <summary>
        /// Gets the value of key 2.
        /// </summary>
        [JsonProperty(PropertyName = "key2")]
        public string Key2 { get; set; }

    }
}
