// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The query result type. </summary>
    public readonly partial struct QueryResultType : IEquatable<QueryResultType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="QueryResultType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryResultType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string TwinValue = "twin";
        private const string DeviceJobValue = "deviceJob";
        private const string JobResponseValue = "jobResponse";
        private const string RawValue = "raw";
        private const string EnrollmentValue = "enrollment";
        private const string EnrollmentGroupValue = "enrollmentGroup";
        private const string DeviceRegistrationValue = "deviceRegistration";

        /// <summary> unknown. </summary>
        public static QueryResultType Unknown { get; } = new QueryResultType(UnknownValue);
        /// <summary> twin. </summary>
        public static QueryResultType Twin { get; } = new QueryResultType(TwinValue);
        /// <summary> deviceJob. </summary>
        public static QueryResultType DeviceJob { get; } = new QueryResultType(DeviceJobValue);
        /// <summary> jobResponse. </summary>
        public static QueryResultType JobResponse { get; } = new QueryResultType(JobResponseValue);
        /// <summary> raw. </summary>
        public static QueryResultType Raw { get; } = new QueryResultType(RawValue);
        /// <summary> enrollment. </summary>
        public static QueryResultType Enrollment { get; } = new QueryResultType(EnrollmentValue);
        /// <summary> enrollmentGroup. </summary>
        public static QueryResultType EnrollmentGroup { get; } = new QueryResultType(EnrollmentGroupValue);
        /// <summary> deviceRegistration. </summary>
        public static QueryResultType DeviceRegistration { get; } = new QueryResultType(DeviceRegistrationValue);
        /// <summary> Determines if two <see cref="QueryResultType"/> values are the same. </summary>
        public static bool operator ==(QueryResultType left, QueryResultType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryResultType"/> values are not the same. </summary>
        public static bool operator !=(QueryResultType left, QueryResultType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueryResultType"/>. </summary>
        public static implicit operator QueryResultType(string value) => new QueryResultType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryResultType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryResultType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
