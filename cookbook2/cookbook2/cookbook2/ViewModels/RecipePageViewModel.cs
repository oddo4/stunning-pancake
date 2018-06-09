using GalaSoft.MvvmLight;
using cookbook2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using cookbook2.Pages;
using GalaSoft.MvvmLight.Command;

namespace cookbook2.ViewModels
{
    class RecipePageViewModel : ViewModelBase
    {
        INavigation Navigation;
        private Recipe recipe;

        public Recipe Recipe
        {
            get
            {
                return recipe;
            }
            set
            {
                recipe = value;
                RaisePropertyChanged("Recipe");
            }
        }

        private int listViewHeight;

        public int ListViewHeight
        {
            get { return listViewHeight; }
            set { listViewHeight = value; RaisePropertyChanged("ListViewHeight"); }
        }

        private RelayCommand<string> webViewCommand;

        public RelayCommand<string> WebViewCommand
        {
            get { return webViewCommand; }
            set { webViewCommand = value; RaisePropertyChanged("WebViewCommand"); }
        }


        public RecipePageViewModel(Recipe recipe, INavigation navigation)
        {
            this.Recipe = recipe;
            this.Navigation = navigation;
            ListViewHeight = (recipe.Ingredients.Length * 40) + (recipe.Ingredients.Length * 10) + 5;

            WebViewCommand = new RelayCommand<string>(ShowWebView);
        }

        private void ShowWebView(string url)
        {
            Navigation.PushAsync(new WebViewPage(Recipe.Url));
        }
    }
}
