using Aureline.Fonts;
using Aureline.iOS.Services;
using Avalonia;
using Avalonia.iOS;
using Foundation;

namespace Aureline.iOS;

[Register("AppDelegate")]
public sealed class AppDelegate : AvaloniaAppDelegate<global::Aureline.App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        IosClashRuntime.Install();
        return base.CustomizeAppBuilder(builder)
            .WithInterFont()
            .WithCjkFontFallback();
    }
}
