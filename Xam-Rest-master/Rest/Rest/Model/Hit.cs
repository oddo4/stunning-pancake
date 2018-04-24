using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Model
{
    public partial class Hit
    {
        [JsonProperty("recipe")]
        public Recipe Recipe { get; set; }

        [JsonProperty("bookmarked")]
        public bool Bookmarked { get; set; }

        [JsonProperty("bought")]
        public bool Bought { get; set; }
    }
}
