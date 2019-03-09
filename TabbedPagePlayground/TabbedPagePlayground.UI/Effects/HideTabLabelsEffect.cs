using Xamarin.Forms;

namespace TabbedPagePlayground.UI.Effects
{
    public class HideTabLabelsEffect : RoutingEffect
    {
        public HideTabLabelsEffect()
            : base($"AppEffects.{nameof(HideTabLabelsEffect)}")
        {
        }
    }
}