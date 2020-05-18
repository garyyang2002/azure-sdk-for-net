// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> VPN client authentication method. </summary>
    public readonly partial struct AuthenticationMethod : IEquatable<AuthenticationMethod>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AuthenticationMethod"/> values are the same. </summary>
        public AuthenticationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EaptlsValue = "EAPTLS";
        private const string EapmschaPv2Value = "EAPMSCHAPv2";

        /// <summary> EAPTLS. </summary>
        public static AuthenticationMethod Eaptls { get; } = new AuthenticationMethod(EaptlsValue);
        /// <summary> EAPMSCHAPv2. </summary>
        public static AuthenticationMethod EapmschaPv2 { get; } = new AuthenticationMethod(EapmschaPv2Value);
        /// <summary> Determines if two <see cref="AuthenticationMethod"/> values are the same. </summary>
        public static bool operator ==(AuthenticationMethod left, AuthenticationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AuthenticationMethod"/> values are not the same. </summary>
        public static bool operator !=(AuthenticationMethod left, AuthenticationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AuthenticationMethod"/>. </summary>
        public static implicit operator AuthenticationMethod(string value) => new AuthenticationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AuthenticationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AuthenticationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
