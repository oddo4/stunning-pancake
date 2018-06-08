using GalaSoft.MvvmLight;
using Rest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.ViewModels
{
    class RecipePageViewModel : ViewModelBase
    {
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

        public RecipePageViewModel(Recipe recipe)
        {
            this.Recipe = recipe;
        }
    }
}
