// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary>
    /// Minimum request requirement of any validation category.
    /// Please note <see cref="DataBoxValidationContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CreateJobValidationContent"/>.
    /// </summary>
    public abstract partial class DataBoxValidationContent
    {
        /// <summary> Initializes a new instance of DataBoxValidationContent. </summary>
        /// <param name="individualRequestDetails">
        /// List of request details contain validationType and its request as key and value respectively.
        /// Please note <see cref="DataBoxValidationInputContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CreateOrderLimitForSubscriptionValidationContent"/>, <see cref="DataTransferDetailsValidationContent"/>, <see cref="PreferencesValidationContent"/>, <see cref="SkuAvailabilityValidationContent"/>, <see cref="SubscriptionIsAllowedToCreateJobValidationContent"/> and <see cref="DataBoxValidateAddressContent"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="individualRequestDetails"/> is null. </exception>
        protected DataBoxValidationContent(IEnumerable<DataBoxValidationInputContent> individualRequestDetails)
        {
            if (individualRequestDetails == null)
            {
                throw new ArgumentNullException(nameof(individualRequestDetails));
            }

            IndividualRequestDetails = individualRequestDetails.ToList();
        }

        /// <summary> Identify the nature of validation. </summary>
        internal DataBoxValidationCategory ValidationCategory { get; set; }
        /// <summary>
        /// List of request details contain validationType and its request as key and value respectively.
        /// Please note <see cref="DataBoxValidationInputContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CreateOrderLimitForSubscriptionValidationContent"/>, <see cref="DataTransferDetailsValidationContent"/>, <see cref="PreferencesValidationContent"/>, <see cref="SkuAvailabilityValidationContent"/>, <see cref="SubscriptionIsAllowedToCreateJobValidationContent"/> and <see cref="DataBoxValidateAddressContent"/>.
        /// </summary>
        public IList<DataBoxValidationInputContent> IndividualRequestDetails { get; }
    }
}
