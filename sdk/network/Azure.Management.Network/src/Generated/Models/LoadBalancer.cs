// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> LoadBalancer resource. </summary>
    public partial class LoadBalancer : Resource
    {
        /// <summary> Initializes a new instance of LoadBalancer. </summary>
        public LoadBalancer()
        {
        }

        /// <summary> Initializes a new instance of LoadBalancer. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The load balancer SKU. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="frontendIPConfigurations"> Object representing the frontend IPs to be used for the load balancer. </param>
        /// <param name="backendAddressPools"> Collection of backend address pools used by a load balancer. </param>
        /// <param name="loadBalancingRules"> Object collection representing the load balancing rules Gets the provisioning. </param>
        /// <param name="probes"> Collection of probe objects used in the load balancer. </param>
        /// <param name="inboundNatRules"> Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to reference individual inbound NAT rules. </param>
        /// <param name="inboundNatPools"> Defines an external port range for inbound NAT to a single backend port on NICs associated with a load balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules. </param>
        /// <param name="outboundRules"> The outbound rules. </param>
        /// <param name="resourceGuid"> The resource GUID property of the load balancer resource. </param>
        /// <param name="provisioningState"> The provisioning state of the load balancer resource. </param>
        internal LoadBalancer(string id, string name, string type, string location, IDictionary<string, string> tags, LoadBalancerSku sku, string etag, IList<FrontendIPConfiguration> frontendIPConfigurations, IList<BackendAddressPool> backendAddressPools, IList<LoadBalancingRule> loadBalancingRules, IList<Probe> probes, IList<InboundNatRule> inboundNatRules, IList<InboundNatPool> inboundNatPools, IList<OutboundRule> outboundRules, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Sku = sku;
            Etag = etag;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPools = backendAddressPools;
            LoadBalancingRules = loadBalancingRules;
            Probes = probes;
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundRules = outboundRules;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> The load balancer SKU. </summary>
        public LoadBalancerSku Sku { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Object representing the frontend IPs to be used for the load balancer. </summary>
        public IList<FrontendIPConfiguration> FrontendIPConfigurations { get; set; }
        /// <summary> Collection of backend address pools used by a load balancer. </summary>
        public IList<BackendAddressPool> BackendAddressPools { get; set; }
        /// <summary> Object collection representing the load balancing rules Gets the provisioning. </summary>
        public IList<LoadBalancingRule> LoadBalancingRules { get; set; }
        /// <summary> Collection of probe objects used in the load balancer. </summary>
        public IList<Probe> Probes { get; set; }
        /// <summary> Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to reference individual inbound NAT rules. </summary>
        public IList<InboundNatRule> InboundNatRules { get; set; }
        /// <summary> Defines an external port range for inbound NAT to a single backend port on NICs associated with a load balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules. </summary>
        public IList<InboundNatPool> InboundNatPools { get; set; }
        /// <summary> The outbound rules. </summary>
        public IList<OutboundRule> OutboundRules { get; set; }
        /// <summary> The resource GUID property of the load balancer resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the load balancer resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
