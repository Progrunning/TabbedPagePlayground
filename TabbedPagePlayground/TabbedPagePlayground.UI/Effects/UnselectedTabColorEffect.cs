using Xamarin.Forms;

namespace TabbedPagePlayground.UI.Effects
{
    public class UnselectedTabColorEffect : RoutingEffect
    {
        public UnselectedTabColorEffect()
            : base($"AppEffects.{nameof(UnselectedTabColorEffect)}")
        {
        }
    }
}