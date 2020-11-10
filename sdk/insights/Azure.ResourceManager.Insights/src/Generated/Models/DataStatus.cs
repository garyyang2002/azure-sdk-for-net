// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> The status of VM Insights data from the resource. When reported as `present` the data array will contain information about the data containers to which data for the specified resource is being routed. </summary>
    public readonly partial struct DataStatus : IEquatable<DataStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DataStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PresentValue = "present";
        private const string NotPresentValue = "notPresent";

        /// <summary> present. </summary>
        public static DataStatus Present { get; } = new DataStatus(PresentValue);
        /// <summary> notPresent. </summary>
        public static DataStatus NotPresent { get; } = new DataStatus(NotPresentValue);
        /// <summary> Determines if two <see cref="DataStatus"/> values are the same. </summary>
        public static bool operator ==(DataStatus left, DataStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataStatus"/> values are not the same. </summary>
        public static bool operator !=(DataStatus left, DataStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataStatus"/>. </summary>
        public static implicit operator DataStatus(string value) => new DataStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
