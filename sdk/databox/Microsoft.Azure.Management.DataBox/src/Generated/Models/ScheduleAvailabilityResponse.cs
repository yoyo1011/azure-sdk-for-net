// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Schedule availability response for given sku in a region.
    /// </summary>
    public partial class ScheduleAvailabilityResponse
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleAvailabilityResponse
        /// class.
        /// </summary>
        public ScheduleAvailabilityResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleAvailabilityResponse
        /// class.
        /// </summary>
        /// <param name="availableDates">List of dates available to
        /// schedule</param>
        public ScheduleAvailabilityResponse(IList<System.DateTime?> availableDates = default(IList<System.DateTime?>))
        {
            AvailableDates = availableDates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of dates available to schedule
        /// </summary>
        [JsonProperty(PropertyName = "availableDates")]
        public IList<System.DateTime?> AvailableDates { get; private set; }

    }
}