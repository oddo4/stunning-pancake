using Rest.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rest.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        RecipeSearchAPI api = new RecipeSearchAPI();
        public HomePage()
        {
            InitializeComponent();

            ShowPosts();
        }
        public async void ShowPosts()
        {
            string json = await api.GetPostsJsonTask("chicken");
            var c = await api.ParsePostJsonTask(json);
            ObservableCollection<Hit> col = new ObservableCollection<Hit>();

            foreach (Hit item in c.Hits)
            {
                col.Add(item);
            }

            PostsListView.ItemsSource = col;

            Debug.WriteLine(col.Count);
        }

        async void testclick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}