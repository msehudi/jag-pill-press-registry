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
    /// contactquotes
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontactquotes
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactquotes
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactquotes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactquotes
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactquotes(string contactquoteid = default(string), string contactid = default(string), long? versionnumber = default(long?), string quoteid = default(string))
        {
            Contactquoteid = contactquoteid;
            Contactid = contactid;
            Versionnumber = versionnumber;
            Quoteid = quoteid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactquoteid")]
        public string Contactquoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public string Quoteid { get; set; }

    }
}