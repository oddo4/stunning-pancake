using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Model
{
    public partial class Params
    {
        [JsonProperty("sane")]
        public object[] Sane { get; set; }

        [JsonProperty("q")]
        public string[] Q { get; set; }

        [JsonProperty("app_key")]
        public string[] AppKey { get; set; }

        [JsonProperty("health")]
        public string[] Health { get; set; }

        [JsonProperty("from")]
        public string[] From { get; set; }

        [JsonProperty("to")]
        public string[] To { get; set; }

        [JsonProperty("calories")]
        public string[] Calories { get; set; }

        [JsonProperty("app_id")]
        public string[] AppId { get; set; }
    }
}
