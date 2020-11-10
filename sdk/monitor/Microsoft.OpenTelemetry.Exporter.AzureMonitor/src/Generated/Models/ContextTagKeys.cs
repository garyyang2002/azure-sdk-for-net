// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> The context tag keys. </summary>
    internal readonly partial struct ContextTagKeys : IEquatable<ContextTagKeys>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ContextTagKeys"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContextTagKeys(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AiApplicationVerValue = "ai.application.ver";
        private const string AiDeviceIdValue = "ai.device.id";
        private const string AiDeviceLocaleValue = "ai.device.locale";
        private const string AiDeviceModelValue = "ai.device.model";
        private const string AiDeviceOemNameValue = "ai.device.oemName";
        private const string AiDeviceOsVersionValue = "ai.device.osVersion";
        private const string AiDeviceTypeValue = "ai.device.type";
        private const string AiLocationIpValue = "ai.location.ip";
        private const string AiLocationCountryValue = "ai.location.country";
        private const string AiLocationProvinceValue = "ai.location.province";
        private const string AiLocationCityValue = "ai.location.city";
        private const string AiOperationIdValue = "ai.operation.id";
        private const string AiOperationNameValue = "ai.operation.name";
        private const string AiOperationParentIdValue = "ai.operation.parentId";
        private const string AiOperationSyntheticSourceValue = "ai.operation.syntheticSource";
        private const string AiOperationCorrelationVectorValue = "ai.operation.correlationVector";
        private const string AiSessionIdValue = "ai.session.id";
        private const string AiSessionIsFirstValue = "ai.session.isFirst";
        private const string AiUserAccountIdValue = "ai.user.accountId";
        private const string AiUserIdValue = "ai.user.id";
        private const string AiUserAuthUserIdValue = "ai.user.authUserId";
        private const string AiCloudRoleValue = "ai.cloud.role";
        private const string AiCloudRoleVerValue = "ai.cloud.roleVer";
        private const string AiCloudRoleInstanceValue = "ai.cloud.roleInstance";
        private const string AiCloudLocationValue = "ai.cloud.location";
        private const string AiInternalSdkVersionValue = "ai.internal.sdkVersion";
        private const string AiInternalAgentVersionValue = "ai.internal.agentVersion";
        private const string AiInternalNodeNameValue = "ai.internal.nodeName";

        /// <summary> ai.application.ver. </summary>
        public static ContextTagKeys AiApplicationVer { get; } = new ContextTagKeys(AiApplicationVerValue);
        /// <summary> ai.device.id. </summary>
        public static ContextTagKeys AiDeviceId { get; } = new ContextTagKeys(AiDeviceIdValue);
        /// <summary> ai.device.locale. </summary>
        public static ContextTagKeys AiDeviceLocale { get; } = new ContextTagKeys(AiDeviceLocaleValue);
        /// <summary> ai.device.model. </summary>
        public static ContextTagKeys AiDeviceModel { get; } = new ContextTagKeys(AiDeviceModelValue);
        /// <summary> ai.device.oemName. </summary>
        public static ContextTagKeys AiDeviceOemName { get; } = new ContextTagKeys(AiDeviceOemNameValue);
        /// <summary> ai.device.osVersion. </summary>
        public static ContextTagKeys AiDeviceOsVersion { get; } = new ContextTagKeys(AiDeviceOsVersionValue);
        /// <summary> ai.device.type. </summary>
        public static ContextTagKeys AiDeviceType { get; } = new ContextTagKeys(AiDeviceTypeValue);
        /// <summary> ai.location.ip. </summary>
        public static ContextTagKeys AiLocationIp { get; } = new ContextTagKeys(AiLocationIpValue);
        /// <summary> ai.location.country. </summary>
        public static ContextTagKeys AiLocationCountry { get; } = new ContextTagKeys(AiLocationCountryValue);
        /// <summary> ai.location.province. </summary>
        public static ContextTagKeys AiLocationProvince { get; } = new ContextTagKeys(AiLocationProvinceValue);
        /// <summary> ai.location.city. </summary>
        public static ContextTagKeys AiLocationCity { get; } = new ContextTagKeys(AiLocationCityValue);
        /// <summary> ai.operation.id. </summary>
        public static ContextTagKeys AiOperationId { get; } = new ContextTagKeys(AiOperationIdValue);
        /// <summary> ai.operation.name. </summary>
        public static ContextTagKeys AiOperationName { get; } = new ContextTagKeys(AiOperationNameValue);
        /// <summary> ai.operation.parentId. </summary>
        public static ContextTagKeys AiOperationParentId { get; } = new ContextTagKeys(AiOperationParentIdValue);
        /// <summary> ai.operation.syntheticSource. </summary>
        public static ContextTagKeys AiOperationSyntheticSource { get; } = new ContextTagKeys(AiOperationSyntheticSourceValue);
        /// <summary> ai.operation.correlationVector. </summary>
        public static ContextTagKeys AiOperationCorrelationVector { get; } = new ContextTagKeys(AiOperationCorrelationVectorValue);
        /// <summary> ai.session.id. </summary>
        public static ContextTagKeys AiSessionId { get; } = new ContextTagKeys(AiSessionIdValue);
        /// <summary> ai.session.isFirst. </summary>
        public static ContextTagKeys AiSessionIsFirst { get; } = new ContextTagKeys(AiSessionIsFirstValue);
        /// <summary> ai.user.accountId. </summary>
        public static ContextTagKeys AiUserAccountId { get; } = new ContextTagKeys(AiUserAccountIdValue);
        /// <summary> ai.user.id. </summary>
        public static ContextTagKeys AiUserId { get; } = new ContextTagKeys(AiUserIdValue);
        /// <summary> ai.user.authUserId. </summary>
        public static ContextTagKeys AiUserAuthUserId { get; } = new ContextTagKeys(AiUserAuthUserIdValue);
        /// <summary> ai.cloud.role. </summary>
        public static ContextTagKeys AiCloudRole { get; } = new ContextTagKeys(AiCloudRoleValue);
        /// <summary> ai.cloud.roleVer. </summary>
        public static ContextTagKeys AiCloudRoleVer { get; } = new ContextTagKeys(AiCloudRoleVerValue);
        /// <summary> ai.cloud.roleInstance. </summary>
        public static ContextTagKeys AiCloudRoleInstance { get; } = new ContextTagKeys(AiCloudRoleInstanceValue);
        /// <summary> ai.cloud.location. </summary>
        public static ContextTagKeys AiCloudLocation { get; } = new ContextTagKeys(AiCloudLocationValue);
        /// <summary> ai.internal.sdkVersion. </summary>
        public static ContextTagKeys AiInternalSdkVersion { get; } = new ContextTagKeys(AiInternalSdkVersionValue);
        /// <summary> ai.internal.agentVersion. </summary>
        public static ContextTagKeys AiInternalAgentVersion { get; } = new ContextTagKeys(AiInternalAgentVersionValue);
        /// <summary> ai.internal.nodeName. </summary>
        public static ContextTagKeys AiInternalNodeName { get; } = new ContextTagKeys(AiInternalNodeNameValue);
        /// <summary> Determines if two <see cref="ContextTagKeys"/> values are the same. </summary>
        public static bool operator ==(ContextTagKeys left, ContextTagKeys right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContextTagKeys"/> values are not the same. </summary>
        public static bool operator !=(ContextTagKeys left, ContextTagKeys right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContextTagKeys"/>. </summary>
        public static implicit operator ContextTagKeys(string value) => new ContextTagKeys(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContextTagKeys other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContextTagKeys other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
