using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CocosSharpDemoParticulas.Droid
{
    [Activity(Label = "CocosSharpDemoParticulas", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var metrics = Resources.DisplayMetrics;

            var width = metrics.WidthPixels / metrics.Density;
            var height = metrics.HeightPixels / metrics.Density;

            App.Width = (int)width;
            App.Height = (int)height;
            App.Density = (int)metrics.Density;

            LoadApplication(new App());
        }
    }
}