// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A ranked action with its resulting probability.
    /// </summary>
    public partial class RankedAction
    {
        /// <summary>
        /// Initializes a new instance of the RankedAction class.
        /// </summary>
        public RankedAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RankedAction class.
        /// </summary>
        /// <param name="id">Id of the action</param>
        /// <param name="probability">Probability of the action</param>
        public RankedAction(string id = default(string), double? probability = default(double?))
        {
            Id = id;
            Probability = probability;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets id of the action
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets probability of the action
        /// </summary>
        [JsonProperty(PropertyName = "probability")]
        public double? Probability { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id != null)
            {
                if (Id.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Id", 256);
                }
                if (Id.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Id", 1);
                }
            }
            if (Probability > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Probability", 1);
            }
            if (Probability < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Probability", 0);
            }
        }
    }
}
