// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure Databricks linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDatabricks")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureDatabricksLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AzureDatabricksLinkedService
        /// class.
        /// </summary>
        public AzureDatabricksLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureDatabricksLinkedService
        /// class.
        /// </summary>
        /// <param name="domain">&lt;REGION&gt;.azuredatabricks.net, domain
        /// name of your Databricks deployment. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="accessToken">Access token for databricks REST API.
        /// Refer to
        /// https://docs.azuredatabricks.net/api/latest/authentication.html.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="existingClusterId">The id of an existing interactive
        /// cluster that will be used for all runs of this activity. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="instancePoolId">The id of an existing instance pool
        /// that will be used for all runs of this activity. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="newClusterVersion">If not using an existing
        /// interactive cluster, this specifies the Spark version of a new job
        /// cluster or instance pool nodes created for each run of this
        /// activity. Required if instancePoolId is specified. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="newClusterNumOfWorker">If not using an existing
        /// interactive cluster, this specifies the number of worker nodes to
        /// use for the new job cluster or instance pool. For new job clusters,
        /// this a string-formatted Int32, like '1' means numOfWorker is 1 or
        /// '1:10' means auto-scale from 1 (min) to 10 (max). For instance
        /// pools, this is a string-formatted Int32, and can only specify a
        /// fixed number of worker nodes, such as '2'. Required if
        /// newClusterVersion is specified. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="newClusterNodeType">The node type of the new job
        /// cluster. This property is required if newClusterVersion is
        /// specified and instancePoolId is not specified. If instancePoolId is
        /// specified, this property is ignored. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="newClusterSparkConf">A set of optional, user-specified
        /// Spark configuration key-value pairs.</param>
        /// <param name="newClusterSparkEnvVars">A set of optional,
        /// user-specified Spark environment variables key-value pairs.</param>
        /// <param name="newClusterCustomTags">Additional tags for cluster
        /// resources. This property is ignored in instance pool
        /// configurations.</param>
        /// <param name="newClusterLogDestination">Specify a location to
        /// deliver Spark driver, worker, and event logs. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="newClusterDriverNodeType">The driver node type for the
        /// new job cluster. This property is ignored in instance pool
        /// configurations. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="newClusterInitScripts">User-defined initialization
        /// scripts for the new cluster. Type: array of strings (or Expression
        /// with resultType array of strings).</param>
        /// <param name="newClusterEnableElasticDisk">Enable the elastic disk
        /// on the new cluster. This property is now ignored, and takes the
        /// default elastic disk behavior in Databricks (elastic disks are
        /// always enabled). Type: boolean (or Expression with resultType
        /// boolean).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AzureDatabricksLinkedService(object domain, SecretBase accessToken, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object existingClusterId = default(object), object instancePoolId = default(object), object newClusterVersion = default(object), object newClusterNumOfWorker = default(object), object newClusterNodeType = default(object), IDictionary<string, object> newClusterSparkConf = default(IDictionary<string, object>), IDictionary<string, object> newClusterSparkEnvVars = default(IDictionary<string, object>), IDictionary<string, object> newClusterCustomTags = default(IDictionary<string, object>), object newClusterLogDestination = default(object), object newClusterDriverNodeType = default(object), object newClusterInitScripts = default(object), object newClusterEnableElasticDisk = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            Domain = domain;
            AccessToken = accessToken;
            ExistingClusterId = existingClusterId;
            InstancePoolId = instancePoolId;
            NewClusterVersion = newClusterVersion;
            NewClusterNumOfWorker = newClusterNumOfWorker;
            NewClusterNodeType = newClusterNodeType;
            NewClusterSparkConf = newClusterSparkConf;
            NewClusterSparkEnvVars = newClusterSparkEnvVars;
            NewClusterCustomTags = newClusterCustomTags;
            NewClusterLogDestination = newClusterLogDestination;
            NewClusterDriverNodeType = newClusterDriverNodeType;
            NewClusterInitScripts = newClusterInitScripts;
            NewClusterEnableElasticDisk = newClusterEnableElasticDisk;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;REGION&amp;gt;.azuredatabricks.net, domain
        /// name of your Databricks deployment. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.domain")]
        public object Domain { get; set; }

        /// <summary>
        /// Gets or sets access token for databricks REST API. Refer to
        /// https://docs.azuredatabricks.net/api/latest/authentication.html.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessToken")]
        public SecretBase AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the id of an existing interactive cluster that will be
        /// used for all runs of this activity. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.existingClusterId")]
        public object ExistingClusterId { get; set; }

        /// <summary>
        /// Gets or sets the id of an existing instance pool that will be used
        /// for all runs of this activity. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.instancePoolId")]
        public object InstancePoolId { get; set; }

        /// <summary>
        /// Gets or sets if not using an existing interactive cluster, this
        /// specifies the Spark version of a new job cluster or instance pool
        /// nodes created for each run of this activity. Required if
        /// instancePoolId is specified. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterVersion")]
        public object NewClusterVersion { get; set; }

        /// <summary>
        /// Gets or sets if not using an existing interactive cluster, this
        /// specifies the number of worker nodes to use for the new job cluster
        /// or instance pool. For new job clusters, this a string-formatted
        /// Int32, like '1' means numOfWorker is 1 or '1:10' means auto-scale
        /// from 1 (min) to 10 (max). For instance pools, this is a
        /// string-formatted Int32, and can only specify a fixed number of
        /// worker nodes, such as '2'. Required if newClusterVersion is
        /// specified. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterNumOfWorker")]
        public object NewClusterNumOfWorker { get; set; }

        /// <summary>
        /// Gets or sets the node type of the new job cluster. This property is
        /// required if newClusterVersion is specified and instancePoolId is
        /// not specified. If instancePoolId is specified, this property is
        /// ignored. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterNodeType")]
        public object NewClusterNodeType { get; set; }

        /// <summary>
        /// Gets or sets a set of optional, user-specified Spark configuration
        /// key-value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterSparkConf")]
        public IDictionary<string, object> NewClusterSparkConf { get; set; }

        /// <summary>
        /// Gets or sets a set of optional, user-specified Spark environment
        /// variables key-value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterSparkEnvVars")]
        public IDictionary<string, object> NewClusterSparkEnvVars { get; set; }

        /// <summary>
        /// Gets or sets additional tags for cluster resources. This property
        /// is ignored in instance pool configurations.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterCustomTags")]
        public IDictionary<string, object> NewClusterCustomTags { get; set; }

        /// <summary>
        /// Gets or sets specify a location to deliver Spark driver, worker,
        /// and event logs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterLogDestination")]
        public object NewClusterLogDestination { get; set; }

        /// <summary>
        /// Gets or sets the driver node type for the new job cluster. This
        /// property is ignored in instance pool configurations. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterDriverNodeType")]
        public object NewClusterDriverNodeType { get; set; }

        /// <summary>
        /// Gets or sets user-defined initialization scripts for the new
        /// cluster. Type: array of strings (or Expression with resultType
        /// array of strings).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterInitScripts")]
        public object NewClusterInitScripts { get; set; }

        /// <summary>
        /// Gets or sets enable the elastic disk on the new cluster. This
        /// property is now ignored, and takes the default elastic disk
        /// behavior in Databricks (elastic disks are always enabled). Type:
        /// boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterEnableElasticDisk")]
        public object NewClusterEnableElasticDisk { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Domain == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Domain");
            }
            if (AccessToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessToken");
            }
        }
    }
}
