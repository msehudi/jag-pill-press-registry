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
    /// CloneAsPatchResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMCloneAsPatchResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCloneAsPatchResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCloneAsPatchResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCloneAsPatchResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCloneAsPatchResponse(string solutionId = default(string))
        {
            SolutionId = solutionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SolutionId")]
        public string SolutionId { get; set; }

    }
}