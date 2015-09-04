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
    /// Describes the source control configuration for web app
    /// </summary>
    public partial class SiteSourceControl : Resource
    {
        /// <summary>
        /// Repository or source control url
        /// </summary>
        [JsonProperty(PropertyName = "properties.repoUrl")]
        public string RepoUrl { get; set; }

        /// <summary>
        /// Name of branch to use for deployment
        /// </summary>
        [JsonProperty(PropertyName = "properties.branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Whether to manual or continuous integration
        /// </summary>
        [JsonProperty(PropertyName = "properties.isManualIntegration")]
        public bool? IsManualIntegration { get; set; }

        /// <summary>
        /// Whether to manual or continuous integration
        /// </summary>
        [JsonProperty(PropertyName = "properties.deploymentRollbackEnabled")]
        public bool? DeploymentRollbackEnabled { get; set; }

        /// <summary>
        /// Mercurial or Git repository type
        /// </summary>
        [JsonProperty(PropertyName = "properties.isMercurial")]
        public bool? IsMercurial { get; set; }

    }
}
