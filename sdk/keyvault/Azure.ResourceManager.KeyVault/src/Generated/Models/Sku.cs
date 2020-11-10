// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> SKU details. </summary>
    public partial class Sku
    {
        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="family"> SKU family name. </param>
        /// <param name="name"> SKU name to specify whether the key vault is a standard vault or a premium vault. </param>
        public Sku(SkuFamily family, SkuName name)
        {
            Family = family;
            Name = name;
        }

        /// <summary> SKU family name. </summary>
        public SkuFamily Family { get; set; }
        /// <summary> SKU name to specify whether the key vault is a standard vault or a premium vault. </summary>
        public SkuName Name { get; set; }
    }
}
