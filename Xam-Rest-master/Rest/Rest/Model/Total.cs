using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Model
{
    public enum TotalDailyUnit { Empty, G, Kcal, Mg, Μg };

    public partial class Total
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public TotalDailyUnit Unit { get; set; }
    }
}
