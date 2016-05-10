// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SkuName.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkuName
    {
        [EnumMember(Value = "F0")]
        F0,
        [EnumMember(Value = "S0")]
        S0,
        [EnumMember(Value = "S1")]
        S1,
        [EnumMember(Value = "S2")]
        S2,
        [EnumMember(Value = "S3")]
        S3,
        [EnumMember(Value = "S4")]
        S4
    }
}
