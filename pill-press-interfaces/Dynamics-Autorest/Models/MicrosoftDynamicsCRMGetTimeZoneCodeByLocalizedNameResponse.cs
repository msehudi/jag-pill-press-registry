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
    /// GetTimeZoneCodeByLocalizedNameResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMGetTimeZoneCodeByLocalizedNameResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMGetTimeZoneCodeByLocalizedNameResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMGetTimeZoneCodeByLocalizedNameResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMGetTimeZoneCodeByLocalizedNameResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMGetTimeZoneCodeByLocalizedNameResponse(int? timeZoneCode = default(int?))
        {
            TimeZoneCode = timeZoneCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TimeZoneCode")]
        public int? TimeZoneCode { get; set; }

    }
}