using Rest.Model;
using Rest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rest.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipePage : ContentPage
    {
        public RecipePage()
        {
            InitializeComponent();
        }

        public RecipePage(Recipe recipe)
        {
            InitializeComponent();
            BindingContext = new RecipePageViewModel(recipe);
        }
    }
}