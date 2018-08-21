using Foundation;
using MvvmCross;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.ViewModels;
using UIKit;

namespace iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<Core.App>, Core.App>
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            // here is where your custom code should be placed

            return result;
        }
    }
}
