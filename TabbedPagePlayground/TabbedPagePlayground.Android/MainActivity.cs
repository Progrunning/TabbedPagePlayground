using Android.App;
using Android.Content.PM;
using Android.OS;
using TabbedPagePlayground.UI;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Resource = Android.Resource;

[assembly: ResolutionGroupName("AppEffects")]

namespace TabbedPagePlayground.Droid
{
    [Activity(Label = "TabbedPagePlayground",
              Icon = "@mipmap/icon",
              Theme = "@style/Theme.Splash",
              MainLauncher = true,
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetTheme(Resource.Style.MainTheme);

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}