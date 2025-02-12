// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Triggered Web Job Run Information.
    /// </summary>
    public partial class TriggeredJobRun
    {
        /// <summary>
        /// Initializes a new instance of the TriggeredJobRun class.
        /// </summary>
        public TriggeredJobRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TriggeredJobRun class.
        /// </summary>
        /// <param name="webJobId">Job ID.</param>
        /// <param name="webJobName">Job name.</param>
        /// <param name="status">Job status. Possible values include:
        /// 'Success', 'Failed', 'Error'</param>
        /// <param name="startTime">Start time.</param>
        /// <param name="endTime">End time.</param>
        /// <param name="duration">Job duration.</param>
        /// <param name="outputUrl">Output URL.</param>
        /// <param name="errorUrl">Error URL.</param>
        /// <param name="url">Job URL.</param>
        /// <param name="jobName">Job name.</param>
        /// <param name="trigger">Job trigger.</param>
        public TriggeredJobRun(string webJobId = default(string), string webJobName = default(string), TriggeredWebJobStatus? status = default(TriggeredWebJobStatus?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string duration = default(string), string outputUrl = default(string), string errorUrl = default(string), string url = default(string), string jobName = default(string), string trigger = default(string))
        {
            WebJobId = webJobId;
            WebJobName = webJobName;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
            OutputUrl = outputUrl;
            ErrorUrl = errorUrl;
            Url = url;
            JobName = jobName;
            Trigger = trigger;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets job ID.
        /// </summary>
        [JsonProperty(PropertyName = "web_job_id")]
        public string WebJobId { get; set; }

        /// <summary>
        /// Gets or sets job name.
        /// </summary>
        [JsonProperty(PropertyName = "web_job_name")]
        public string WebJobName { get; set; }

        /// <summary>
        /// Gets or sets job status. Possible values include: 'Success',
        /// 'Failed', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public TriggeredWebJobStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets job duration.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets output URL.
        /// </summary>
        [JsonProperty(PropertyName = "output_url")]
        public string OutputUrl { get; set; }

        /// <summary>
        /// Gets or sets error URL.
        /// </summary>
        [JsonProperty(PropertyName = "error_url")]
        public string ErrorUrl { get; set; }

        /// <summary>
        /// Gets or sets job URL.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets job name.
        /// </summary>
        [JsonProperty(PropertyName = "job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or sets job trigger.
        /// </summary>
        [JsonProperty(PropertyName = "trigger")]
        public string Trigger { get; set; }

    }
}
