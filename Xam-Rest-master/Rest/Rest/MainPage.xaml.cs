using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ModernHttpClient;
using Newtonsoft.Json;
using Rest.Model;
using Xamarin.Forms;

namespace Rest
{
    public partial class MainPage : ContentPage
    {
        RecipeSearchAPI api = new RecipeSearchAPI();
        public MainPage()
        {
            InitializeComponent();
            
            ShowPosts();
        }

        public async void ShowPosts()
        {
            string json = await api.GetPostsJsonTask("chicken");
            var c = await api.ParsePostJsonTask(json);
            PostsListView.ItemsSource = c.Hits;


        }
    }
}
