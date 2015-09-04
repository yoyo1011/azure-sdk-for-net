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
    /// VNETInfo contract. This contract is public and is a stripped down
    /// version of VNETInfoInternal
    /// </summary>
    public partial class VnetInfo : Resource
    {
        /// <summary>
        /// The vnet resource id
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetResourceId")]
        public string VnetResourceId { get; set; }

        /// <summary>
        /// The client certificate thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "properties.certThumbprint")]
        public string CertThumbprint { get; set; }

        /// <summary>
        /// A certificate file (.cer) blob containing the public key of the
        /// private key used to authenticate a
        /// Point-To-Site VPN connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certBlob")]
        public string CertBlob { get; set; }

        /// <summary>
        /// The routes that this virtual network connection uses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routes")]
        public IList<VnetRoute> Routes { get; set; }

    }
}
