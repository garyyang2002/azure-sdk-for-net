// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Network.Models
{
    /// <summary> Parameters that define the VM to check security groups for. </summary>
    public partial class SecurityGroupViewParameters
    {
        /// <summary> Initializes a new instance of SecurityGroupViewParameters. </summary>
        /// <param name="targetResourceId"> ID of the target VM. </param>
        public SecurityGroupViewParameters(string targetResourceId)
        {
            if (targetResourceId == null)
            {
                throw new ArgumentNullException(nameof(targetResourceId));
            }

            TargetResourceId = targetResourceId;
        }

        /// <summary> ID of the target VM. </summary>
        public string TargetResourceId { get; }
    }
}
