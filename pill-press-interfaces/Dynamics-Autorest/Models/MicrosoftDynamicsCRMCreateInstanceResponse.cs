// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CreateInstanceResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMCreateInstanceResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCreateInstanceResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCreateInstanceResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCreateInstanceResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCreateInstanceResponse(bool? seriesCanBeExpanded = default(bool?))
        {
            SeriesCanBeExpanded = seriesCanBeExpanded;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SeriesCanBeExpanded")]
        public bool? SeriesCanBeExpanded { get; set; }

    }
}