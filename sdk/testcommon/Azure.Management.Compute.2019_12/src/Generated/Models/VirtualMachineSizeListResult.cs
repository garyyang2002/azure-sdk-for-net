// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> The List Virtual Machine operation response. </summary>
    public partial class VirtualMachineSizeListResult
    {
        /// <summary> Initializes a new instance of VirtualMachineSizeListResult. </summary>
        internal VirtualMachineSizeListResult()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineSizeListResult. </summary>
        /// <param name="value"> The list of virtual machine sizes. </param>
        internal VirtualMachineSizeListResult(IReadOnlyList<VirtualMachineSize> value)
        {
            Value = value;
        }

        /// <summary> The list of virtual machine sizes. </summary>
        public IReadOnlyList<VirtualMachineSize> Value { get; }
    }
}
