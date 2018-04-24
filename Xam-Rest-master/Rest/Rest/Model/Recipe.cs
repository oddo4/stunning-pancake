using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Model
{
    public partial class Recipe
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("shareAs")]
        public string ShareAs { get; set; }

        [JsonProperty("yield")]
        public long Yield { get; set; }

        [JsonProperty("dietLabels")]
        public string[] DietLabels { get; set; }

        [JsonProperty("healthLabels")]
        public string[] HealthLabels { get; set; }

        [JsonProperty("cautions")]
        public object[] Cautions { get; set; }

        [JsonProperty("ingredientLines")]
        public string[] IngredientLines { get; set; }

        [JsonProperty("ingredients")]
        public Ingredient[] Ingredients { get; set; }

        [JsonProperty("calories")]
        public double Calories { get; set; }

        [JsonProperty("totalWeight")]
        public double TotalWeight { get; set; }

        [JsonProperty("totalTime")]
        public long TotalTime { get; set; }

        [JsonProperty("totalNutrients")]
        public Dictionary<string, Total> TotalNutrients { get; set; }

        [JsonProperty("totalDaily")]
        public Dictionary<string, Total> TotalDaily { get; set; }

        [JsonProperty("digest")]
        public Digest[] Digest { get; set; }
    }
}
