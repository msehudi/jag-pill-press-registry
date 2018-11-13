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
    /// principalobjectaccess
    /// </summary>
    public partial class MicrosoftDynamicsCRMprincipalobjectaccess
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMprincipalobjectaccess class.
        /// </summary>
        public MicrosoftDynamicsCRMprincipalobjectaccess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMprincipalobjectaccess class.
        /// </summary>
        public MicrosoftDynamicsCRMprincipalobjectaccess(int? inheritedaccessrightsmask = default(int?), long? versionnumber = default(long?), int? accessrightsmask = default(int?), string principaltypecode = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? changedon = default(System.DateTimeOffset?), string objecttypecode = default(string), string principalid = default(string), int? utcconversiontimezonecode = default(int?), string principalobjectaccessid = default(string), string objectid = default(string))
        {
            Inheritedaccessrightsmask = inheritedaccessrightsmask;
            Versionnumber = versionnumber;
            Accessrightsmask = accessrightsmask;
            Principaltypecode = principaltypecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Changedon = changedon;
            Objecttypecode = objecttypecode;
            Principalid = principalid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Principalobjectaccessid = principalobjectaccessid;
            Objectid = objectid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inheritedaccessrightsmask")]
        public int? Inheritedaccessrightsmask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessrightsmask")]
        public int? Accessrightsmask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "principaltypecode")]
        public string Principaltypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "changedon")]
        public System.DateTimeOffset? Changedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "principalid")]
        public string Principalid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "principalobjectaccessid")]
        public string Principalobjectaccessid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public string Objectid { get; set; }

    }
}