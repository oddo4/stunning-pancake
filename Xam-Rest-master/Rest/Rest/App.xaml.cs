using BottomBar.XamarinForms;
using Rest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Rest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Rest.MainPage();

            BottomBarPage bottomBarPage = new BottomBarPage();
            bottomBarPage.BarTheme = BottomBarPage.BarThemeTypes.DarkWithAlpha;
            //bottomBarPage.FixedMode = true;

            string[] tabTitles = { "Home", "Search", "Categories", "Favorites", "Profile" };
            Page[] tabPages = { new HomePage(), new SearchPage(), new CategoryPage(), new FavoritePage(), new ProfilePage() };

            for (int i = 0; i < tabTitles.Length; ++i)
            {
                string title = tabTitles[i];

                FileImageSource icon = (FileImageSource)FileImageSource.FromFile(string.Format("ic_action_{0}.png", title.ToLowerInvariant()));

                // create tab page
                var tabPage = new NavigationPage(tabPages[i]);
                tabPage.Title = title;
                tabPage.Icon = icon;

                // set tab color
                /*if (tabColor != null)
                {
                    BottomBarPageExtensions.SetTabColor(tabPage, Color.FromHex(tabColor));
                }*/

                //BottomBarPageExtensions.SetTabColor(tabPage, Color.White);


                // add tab pag to tab control
                bottomBarPage.Children.Add(tabPage);
            }

            MainPage = bottomBarPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
