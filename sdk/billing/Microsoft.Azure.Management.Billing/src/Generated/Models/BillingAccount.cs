// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A billing account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BillingAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BillingAccount class.
        /// </summary>
        public BillingAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingAccount class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">The billing account name.</param>
        /// <param name="soldTo">The address of the individual or organization
        /// that is responsible for the billing account.</param>
        /// <param name="agreementType">The type of agreement. Possible values
        /// include: 'MicrosoftCustomerAgreement', 'EnterpriseAgreement',
        /// 'MicrosoftOnlineServicesProgram',
        /// 'MicrosoftPartnerAgreement'</param>
        /// <param name="accountType">The type of customer. Possible values
        /// include: 'Enterprise', 'Individual', 'Partner'</param>
        /// <param name="accountStatus">The current status of the billing
        /// account. Possible values include: 'Active', 'Deleted', 'Disabled',
        /// 'Expired', 'Transferred', 'Extended', 'Terminated'</param>
        /// <param name="billingProfiles">The billing profiles associated with
        /// the billing account. By default this is not populated, unless it's
        /// specified in $expand.</param>
        /// <param name="enrollmentDetails">The details about the associated
        /// legacy enrollment. By default this is not populated, unless it's
        /// specified in $expand.</param>
        /// <param name="departments">The departments associated to the
        /// enrollment.</param>
        /// <param name="enrollmentAccounts">The accounts associated to the
        /// enrollment.</param>
        /// <param name="hasReadAccess">Indicates whether user has read access
        /// to the billing account.</param>
        public BillingAccount(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), AddressDetails soldTo = default(AddressDetails), string agreementType = default(string), string accountType = default(string), string accountStatus = default(string), BillingProfilesOnExpand billingProfiles = default(BillingProfilesOnExpand), Enrollment enrollmentDetails = default(Enrollment), IList<Department> departments = default(IList<Department>), IList<EnrollmentAccount> enrollmentAccounts = default(IList<EnrollmentAccount>), bool? hasReadAccess = default(bool?))
            : base(id, name, type)
        {
            DisplayName = displayName;
            SoldTo = soldTo;
            AgreementType = agreementType;
            AccountType = accountType;
            AccountStatus = accountStatus;
            BillingProfiles = billingProfiles;
            EnrollmentDetails = enrollmentDetails;
            Departments = departments;
            EnrollmentAccounts = enrollmentAccounts;
            HasReadAccess = hasReadAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the billing account name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the address of the individual or organization that is
        /// responsible for the billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.soldTo")]
        public AddressDetails SoldTo { get; set; }

        /// <summary>
        /// Gets the type of agreement. Possible values include:
        /// 'MicrosoftCustomerAgreement', 'EnterpriseAgreement',
        /// 'MicrosoftOnlineServicesProgram', 'MicrosoftPartnerAgreement'
        /// </summary>
        [JsonProperty(PropertyName = "properties.agreementType")]
        public string AgreementType { get; private set; }

        /// <summary>
        /// Gets the type of customer. Possible values include: 'Enterprise',
        /// 'Individual', 'Partner'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountType")]
        public string AccountType { get; private set; }

        /// <summary>
        /// Gets the current status of the billing account. Possible values
        /// include: 'Active', 'Deleted', 'Disabled', 'Expired', 'Transferred',
        /// 'Extended', 'Terminated'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountStatus")]
        public string AccountStatus { get; private set; }

        /// <summary>
        /// Gets or sets the billing profiles associated with the billing
        /// account. By default this is not populated, unless it's specified in
        /// $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfiles")]
        public BillingProfilesOnExpand BillingProfiles { get; set; }

        /// <summary>
        /// Gets the details about the associated legacy enrollment. By default
        /// this is not populated, unless it's specified in $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enrollmentDetails")]
        public Enrollment EnrollmentDetails { get; private set; }

        /// <summary>
        /// Gets or sets the departments associated to the enrollment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.departments")]
        public IList<Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets the accounts associated to the enrollment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enrollmentAccounts")]
        public IList<EnrollmentAccount> EnrollmentAccounts { get; set; }

        /// <summary>
        /// Gets indicates whether user has read access to the billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasReadAccess")]
        public bool? HasReadAccess { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SoldTo != null)
            {
                SoldTo.Validate();
            }
        }
    }
}
