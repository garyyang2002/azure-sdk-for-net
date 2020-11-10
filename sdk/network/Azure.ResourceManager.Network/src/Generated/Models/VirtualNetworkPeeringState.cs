// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The status of the virtual network peering. </summary>
    public readonly partial struct VirtualNetworkPeeringState : IEquatable<VirtualNetworkPeeringState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VirtualNetworkPeeringState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualNetworkPeeringState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitiatedValue = "Initiated";
        private const string ConnectedValue = "Connected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Initiated. </summary>
        public static VirtualNetworkPeeringState Initiated { get; } = new VirtualNetworkPeeringState(InitiatedValue);
        /// <summary> Connected. </summary>
        public static VirtualNetworkPeeringState Connected { get; } = new VirtualNetworkPeeringState(ConnectedValue);
        /// <summary> Disconnected. </summary>
        public static VirtualNetworkPeeringState Disconnected { get; } = new VirtualNetworkPeeringState(DisconnectedValue);
        /// <summary> Determines if two <see cref="VirtualNetworkPeeringState"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkPeeringState left, VirtualNetworkPeeringState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkPeeringState"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkPeeringState left, VirtualNetworkPeeringState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualNetworkPeeringState"/>. </summary>
        public static implicit operator VirtualNetworkPeeringState(string value) => new VirtualNetworkPeeringState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkPeeringState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkPeeringState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
