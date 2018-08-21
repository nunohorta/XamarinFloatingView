using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace Droid
{
    [Activity(
        Label = "floating_view"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
