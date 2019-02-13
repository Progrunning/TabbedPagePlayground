using System.Linq;
using TabbedPagePlayground.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(UnselectedTabColorEffect), nameof(UnselectedTabColorEffect))]

namespace TabbedPagePlayground.iOS
{
    public class UnselectedTabColorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var tabBar = Container.Subviews.OfType<UITabBar>().FirstOrDefault();
            if (tabBar == null)
            {
                return;
            }

            tabBar.UnselectedItemTintColor = UIColor.Red;
            // By default iOS sets BarTintColor to be Translucent (https://developer.apple.com/documentation/uikit/uinavigationbar/1624931-bartintcolor),
            // which fades the actual color, so we need to turn it off
            tabBar.Translucent = false;
        }

        protected override void OnDetached()
        {
        }
    }
}