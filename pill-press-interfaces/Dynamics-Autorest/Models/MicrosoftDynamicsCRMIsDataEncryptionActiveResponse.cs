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
    /// IsDataEncryptionActiveResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMIsDataEncryptionActiveResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMIsDataEncryptionActiveResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMIsDataEncryptionActiveResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMIsDataEncryptionActiveResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMIsDataEncryptionActiveResponse(bool? isActive = default(bool?))
        {
            IsActive = isActive;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

    }
}
