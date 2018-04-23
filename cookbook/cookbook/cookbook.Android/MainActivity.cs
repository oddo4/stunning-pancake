using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SpoonacularAPI.PCL;
using System.Threading.Tasks;

namespace cookbook.Droid
{
    [Activity(Label = "cookbook", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            // Configuration parameters
            string xMashapeKey = "Hp8t2adS8JmshbwOUk2OjS8pwmoDp1ula5vjsnZb1nKKp5n1tS"; // The Mashape application you want to use for this session.

            SpoonacularAPIClient client = new SpoonacularAPIClient(xMashapeKey);
        }
    }
}

