using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using cookbook2.Model;
using cookbook2.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cookbook2.ViewModels
{
    class HomePageViewModel : ViewModelBase
    {
        INavigation Navigation;
        RecipeSearchAPI api = new RecipeSearchAPI();
        Hit[] dataResults;

        private ObservableCollection<Hit> listResults;

        public ObservableCollection<Hit> ListResults
        {
            get
            {
                return listResults;
            }
            set
            {
                listResults = value;
                RaisePropertyChanged("ListResults");
            }
        }

        private object selectedItem;

        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }

        private RelayCommand selectItemCommand;

        public RelayCommand SelectItemCommand
        {
            get
            {
                return selectItemCommand;
            }
            set
            {
                selectItemCommand = value;
                RaisePropertyChanged("SelectItemCommand");
            }
        }

        public HomePageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            ShowPosts();
            SelectItemCommand = new RelayCommand(ShowItem, true);
        }

        public void ShowItem()
        {
            var item = ((Hit)SelectedItem).Recipe;
            Debug.WriteLine(((Hit)SelectedItem).Recipe.Label);
            Navigation.PushAsync(new RecipePage(item));
        }

        public async void ShowPosts()
        {
            string json = await api.GetPostsJsonTask("chicken");
            var result = await api.ParsePostJsonTask(json);
            dataResults = result.Hits;

            ListResults = new ObservableCollection<Hit>();

            foreach (Hit item in dataResults)
            {
                ListResults.Add(item);
            }

            //PostsListView.ItemsSource = col;
        }
    }
}
