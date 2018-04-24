using SpoonacularAPI.PCL;
using SpoonacularAPI.PCL.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cookbook
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            string result = GetPostsJsonTask().Result;

            Debug.WriteLine(result);
        }

        public async Task<string> GetPostsJsonTask()
        {
            var client = new HttpClient();
            var uri = new Uri("https://api.edamam.com/search?q=chicken&app_id=$df168dd4&app_key=$25df00d4dd3c62cd7caad4f4fb908673&from=0&to=3&calories=591-722&health=alcohol-free");

            string content = await Task.Run(async () =>
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode) return await response.Content.ReadAsStringAsync();
                throw new HttpRequestException("Communication with server failed");
            });
            return content;
        }

        /*public async void x()
        {
            string xMashapeKey = "O8mZRtKK3kmshkJh60flqbZJJ4Vnp1OlvY9jsns6NdLtbZXbB1"; // The Mashape application you want to use for this session.

            SpoonacularAPIClient client = new SpoonacularAPIClient(xMashapeKey);

            APIController controller = client.Client;

            int id = 22347;

            dynamic result = await controller.GetProductInformationAsync(id);
        }*/
    }
}
