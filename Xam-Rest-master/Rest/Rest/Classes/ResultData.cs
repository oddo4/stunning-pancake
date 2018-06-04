using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Model
{
    public partial class ResultData
    {
        [JsonProperty("q")]
        public string Q { get; set; }

        [JsonProperty("from")]
        public long From { get; set; }

        [JsonProperty("to")]
        public long To { get; set; }

        [JsonProperty("params")]
        public Params Params { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("hits")]
        public Hit[] Hits { get; set; }
    }
}
