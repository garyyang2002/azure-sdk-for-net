// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.EventHub.Models
{
    /// <summary> The response from the List namespace operation. </summary>
    public partial class NWRuleSetVirtualNetworkRules
    {
        /// <summary> Initializes a new instance of NWRuleSetVirtualNetworkRules. </summary>
        public NWRuleSetVirtualNetworkRules()
        {
        }

        /// <summary> Initializes a new instance of NWRuleSetVirtualNetworkRules. </summary>
        /// <param name="subnet"> Subnet properties. </param>
        /// <param name="ignoreMissingVnetServiceEndpoint"> Value that indicates whether to ignore missing Vnet Service Endpoint. </param>
        internal NWRuleSetVirtualNetworkRules(Subnet subnet, bool? ignoreMissingVnetServiceEndpoint)
        {
            Subnet = subnet;
            IgnoreMissingVnetServiceEndpoint = ignoreMissingVnetServiceEndpoint;
        }

        /// <summary> Subnet properties. </summary>
        public Subnet Subnet { get; set; }
        /// <summary> Value that indicates whether to ignore missing Vnet Service Endpoint. </summary>
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
    }
}
