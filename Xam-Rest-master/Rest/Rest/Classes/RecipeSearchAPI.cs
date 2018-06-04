using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Model
{
    class RecipeSearchAPI
    {
        private string apiID = "df168dd4";
        private string apiKey = "25df00d4dd3c62cd7caad4f4fb908673";

        /// <summary>
        /// Parse Json string via task - no lag on UI
        /// </summary>
        /// <param name="json">Json string of Posts</param>
        /// <returns>Collection of parsed objects</returns>
        /// <exception cref="HttpRequestException">If device could not connect ie. Internet access denied or Status code is not Success</exception>
        public async Task<ResultData> ParsePostJsonTask(string json)
        {
            return await Task.Run(() => JsonConvert.DeserializeObject<ResultData>(json));

        }

        //Nutrition Analysis API and Database
        //API ID = ef9393e8
        //API KEY = e217c0120f0ee71b206806177c3e750e

        //Recipe Search API
        //API ID = df168dd4
        //API KEY = a7d32a938a697834f1248f5973c4705c

        /// <summary>
        /// Download data from API via background Task
        /// </summary>
        /// <returns>Json string from API</returns>
        public async Task<string> GetPostsJsonTask(string query)
        {
            var client = new HttpClient();
            var uri = new Uri("https://api.edamam.com/search?q=" + query + "&app_id=" + apiID + "&app_key=" + apiKey + "&from=0&to=100");

            string content = await Task.Run(async () =>
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode) return await response.Content.ReadAsStringAsync();
                throw new HttpRequestException("Communication with server failed");
            });
            return content;
        }
    }
}
