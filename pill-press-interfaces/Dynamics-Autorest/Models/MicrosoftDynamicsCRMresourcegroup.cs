// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// resourcegroup
    /// </summary>
    public partial class MicrosoftDynamicsCRMresourcegroup
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresourcegroup
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresourcegroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMresourcegroup
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMresourcegroup(string resourcegroupid = default(string), string name = default(string), string _organizationidValue = default(string), long? versionnumber = default(long?), string _businessunitidValue = default(string), string objecttypecode = default(string), int? grouptypecode = default(int?), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMconnection> resourcegroupConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> resourcegroupConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMconstraintbasedgroup resourcegroupidConstraintbasedgroup = default(MicrosoftDynamicsCRMconstraintbasedgroup), IList<MicrosoftDynamicsCRMbulkdeletefailure> resourceGroupBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMduplicaterecord> resourceGroupDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMteam resourcegroupidTeam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMduplicaterecord> resourceGroupDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsyncerror> resourceGroupSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> resourceGroupAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            Resourcegroupid = resourcegroupid;
            Name = name;
            this._organizationidValue = _organizationidValue;
            Versionnumber = versionnumber;
            this._businessunitidValue = _businessunitidValue;
            Objecttypecode = objecttypecode;
            Grouptypecode = grouptypecode;
            Organizationid = organizationid;
            ResourcegroupConnections2 = resourcegroupConnections2;
            ResourcegroupConnections1 = resourcegroupConnections1;
            Businessunitid = businessunitid;
            ResourcegroupidConstraintbasedgroup = resourcegroupidConstraintbasedgroup;
            ResourceGroupBulkDeleteFailures = resourceGroupBulkDeleteFailures;
            ResourceGroupDuplicateBaseRecord = resourceGroupDuplicateBaseRecord;
            ResourcegroupidTeam = resourcegroupidTeam;
            ResourceGroupDuplicateMatchingRecord = resourceGroupDuplicateMatchingRecord;
            ResourceGroupSyncErrors = resourceGroupSyncErrors;
            ResourceGroupAsyncOperations = resourceGroupAsyncOperations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroupid")]
        public string Resourcegroupid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grouptypecode")]
        public int? Grouptypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroup_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ResourcegroupConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroup_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ResourcegroupConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroupid_constraintbasedgroup")]
        public MicrosoftDynamicsCRMconstraintbasedgroup ResourcegroupidConstraintbasedgroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ResourceGroupBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ResourceGroupDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcegroupid_team")]
        public MicrosoftDynamicsCRMteam ResourcegroupidTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ResourceGroupDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ResourceGroupSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResourceGroup_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ResourceGroupAsyncOperations { get; set; }

    }
}