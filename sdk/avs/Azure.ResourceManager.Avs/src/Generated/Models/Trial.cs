// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Subscription trial availability. </summary>
    public partial class Trial
    {
        /// <summary> Initializes a new instance of Trial. </summary>
        internal Trial()
        {
        }

        /// <summary> Initializes a new instance of Trial. </summary>
        /// <param name="status"> Trial status. </param>
        /// <param name="availableHosts"> Number of trial hosts available. </param>
        internal Trial(TrialStatus? status, int? availableHosts)
        {
            Status = status;
            AvailableHosts = availableHosts;
        }

        /// <summary> Trial status. </summary>
        public TrialStatus? Status { get; }
        /// <summary> Number of trial hosts available. </summary>
        public int? AvailableHosts { get; }
    }
}
