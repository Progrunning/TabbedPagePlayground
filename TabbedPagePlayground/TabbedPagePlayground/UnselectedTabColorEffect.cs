using Xamarin.Forms;

namespace TabbedPagePlayground
{
    public class UnselectedTabColorEffect : RoutingEffect
    {
        public UnselectedTabColorEffect()
            : base($"AppEffects.{nameof(UnselectedTabColorEffect)}")
        {
        }
    }
}