// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// AutoHealRules - describes the rules which can be defined for auto-heal
    /// </summary>
    public partial class AutoHealRules
    {
        /// <summary>
        /// Triggers - Conditions that describe when to execute the auto-heal
        /// actions
        /// </summary>
        [JsonProperty(PropertyName = "triggers")]
        public AutoHealTriggers Triggers { get; set; }

        /// <summary>
        /// Actions - Actions to be executed when a rule is triggered
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public AutoHealActions Actions { get; set; }

    }
}
