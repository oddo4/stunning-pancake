using cookbook2.Model;
using cookbook2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cookbook2.Pages
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
            BindingContext = new RecipePageViewModel(recipe, Navigation);
        }
    }
}