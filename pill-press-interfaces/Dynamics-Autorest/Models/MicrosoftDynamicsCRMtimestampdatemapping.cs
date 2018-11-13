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
    /// timestampdatemapping
    /// </summary>
    public partial class MicrosoftDynamicsCRMtimestampdatemapping
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtimestampdatemapping class.
        /// </summary>
        public MicrosoftDynamicsCRMtimestampdatemapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtimestampdatemapping class.
        /// </summary>
        public MicrosoftDynamicsCRMtimestampdatemapping(long? timestamp = default(long?), System.DateTimeOffset? date = default(System.DateTimeOffset?), string timestampdatemappingid = default(string))
        {
            Timestamp = timestamp;
            Date = date;
            Timestampdatemappingid = timestampdatemappingid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestampdatemappingid")]
        public string Timestampdatemappingid { get; set; }

    }
}