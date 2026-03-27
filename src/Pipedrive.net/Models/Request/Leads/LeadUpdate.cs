using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pipedrive
{
    public class LeadUpdate
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("label_ids")]
        public List<Guid> LabelIds { get; set; }

        [JsonProperty("person_id")]
        public long? PersonId { get; set; }

        [JsonProperty("organization_id")]
        public long? OrganizationId { get; set; }

        [JsonProperty("is_archived")]
        public bool? IsArchived { get; set; }
    }
}
