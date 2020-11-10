// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SparkJobLog
    {
        /// <summary>
        /// Initializes a new instance of the SparkJobLog class.
        /// </summary>
        public SparkJobLog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SparkJobLog class.
        /// </summary>
        /// <param name="id">The livy id of the spark job.</param>
        /// <param name="fromProperty">Offset from start of log.</param>
        /// <param name="size">Max number of log lines.</param>
        /// <param name="total">Total number of log lines.</param>
        /// <param name="logLines">The log lines.</param>
        public SparkJobLog(int? id = default(int?), int? fromProperty = default(int?), int? size = default(int?), long? total = default(long?), IList<string> logLines = default(IList<string>))
        {
            Id = id;
            FromProperty = fromProperty;
            Size = size;
            Total = total;
            LogLines = logLines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the livy id of the spark job.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets offset from start of log.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public int? FromProperty { get; set; }

        /// <summary>
        /// Gets or sets max number of log lines.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or sets total number of log lines.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// Gets or sets the log lines.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public IList<string> LogLines { get; set; }

    }
}
