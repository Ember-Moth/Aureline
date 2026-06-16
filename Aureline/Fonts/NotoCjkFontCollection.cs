using System;
using Avalonia.Media.Fonts;

namespace Aureline.Fonts;

/// <summary>
/// Registers the embedded Noto Sans SC font with Avalonia's FontManager.
/// This font provides CJK glyph coverage for devices where the system
/// font fallback chain is unreliable (common on Android OEM ROMs).
/// </summary>
public sealed class NotoCjkFontCollection : EmbeddedFontCollection
{
    public NotoCjkFontCollection() : base(
        new Uri("fonts:NotoCJK", UriKind.Absolute),
        new Uri("avares://Aureline/Assets/Fonts", UriKind.Absolute))
    {
    }
}
