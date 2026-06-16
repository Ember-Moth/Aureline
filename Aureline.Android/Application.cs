using Android.App;
using Android.Runtime;
using Aureline.Fonts;
using Avalonia;
using Avalonia.Android;

namespace Aureline.Android;

[Application]
public class Application : AvaloniaAndroidApplication<global::Aureline.App>
{
    protected Application(nint javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
    }

    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont()
            .WithCjkFontFallback();
    }
}
