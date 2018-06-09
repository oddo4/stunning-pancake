using cookbook2.Model;
using cookbook2.Pages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace cookbook2.ViewModels
{
    class SearchPageViewModel : ViewModelBase
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

        private RelayCommand<string> searchCommand;

        public RelayCommand<string> SearchCommand
        {
            get { return searchCommand; }
            set { searchCommand = value; RaisePropertyChanged("SearchCommand"); }
        }

        private bool busy = false;

        public bool Busy
        {
            get { return busy; }
            set { busy = value; RaisePropertyChanged("Busy"); }
        }



        public SearchPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SearchCommand = new RelayCommand<string>(SearchItems, true);
            SelectItemCommand = new RelayCommand(ShowItem, true);
        }

        public void SearchItems(string query)
        {
            ListResults = null;
            ShowPosts(query);
        }

        public void ShowItem()
        {
            var item = ((Hit)SelectedItem).Recipe;
            //Debug.WriteLine(((Hit)SelectedItem).Recipe.Label);
            Navigation.PushAsync(new RecipePage(item));
        }

        public async void ShowPosts(string query)
        {
            Busy = true;
            string json = await api.GetPostsJsonTask(query);
            var result = await api.ParsePostJsonTask(json);
            dataResults = result.Hits;

            ListResults = new ObservableCollection<Hit>();

            foreach (Hit item in dataResults)
            {
                ListResults.Add(item);
            }

            Busy = false;
            Debug.WriteLine("False");
            //PostsListView.ItemsSource = col;
        }
    }
}
