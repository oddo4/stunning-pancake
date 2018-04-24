using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Model
{
    public enum DigestUnit { G, Mg, Μg };

    public partial class Digest
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("schemaOrgTag")]
        public string SchemaOrgTag { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("hasRDI")]
        public bool HasRdi { get; set; }

        [JsonProperty("daily")]
        public double Daily { get; set; }

        [JsonProperty("unit")]
        public DigestUnit Unit { get; set; }

        [JsonProperty("sub", NullValueHandling = NullValueHandling.Ignore)]
        public Digest[] Sub { get; set; }
    }
}
