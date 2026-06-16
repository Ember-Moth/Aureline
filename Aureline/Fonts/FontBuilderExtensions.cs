using Avalonia;
using Avalonia.Media;

namespace Aureline.Fonts;

/// <summary>
/// AppBuilder extension to register CJK font fallback.
/// Call after <c>.WithInterFont()</c> to ensure CJK glyphs are available
/// on all devices, including Android OEM ROMs with broken system font fallback.
/// </summary>
public static class FontBuilderExtensions
{
    /// <summary>
    /// Registers Noto Sans SC as a global font fallback for CJK Unicode ranges.
    /// Covers: CJK Unified Ideographs, Extension A, Compatibility Ideographs,
    /// CJK Radicals, CJK Symbols/Punctuation, Fullwidth Forms, and common
    /// Latin/punctuation ranges used in mixed-language text.
    /// </summary>
    public static AppBuilder WithCjkFontFallback(this AppBuilder appBuilder)
    {
        return appBuilder
            .ConfigureFonts(fontManager =>
            {
                fontManager.AddFontCollection(new NotoCjkFontCollection());
            })
            .With(new FontManagerOptions
            {
                FontFallbacks =
                [
                    new FontFallback
                    {
                        FontFamily = new FontFamily("fonts:NotoCJK#Noto Sans SC"),
                        UnicodeRange = UnicodeRange.Parse(
                            "U+0080-00FF," +    // Latin-1 Supplement (accented chars in proxy names)
                            "U+2000-206F," +    // General Punctuation
                            "U+2E80-2EFF," +    // CJK Radicals Supplement
                            "U+2F00-2FDF," +    // Kangxi Radicals
                            "U+3000-303F," +    // CJK Symbols and Punctuation
                            "U+3100-312F," +    // Bopomofo
                            "U+3200-32FF," +    // Enclosed CJK Letters and Months
                            "U+3300-33FF," +    // CJK Compatibility
                            "U+3400-4DBF," +    // CJK Unified Ideographs Extension A
                            "U+4E00-9FFF," +    // CJK Unified Ideographs
                            "U+F900-FAFF," +    // CJK Compatibility Ideographs
                            "U+FE30-FE4F," +    // CJK Compatibility Forms
                            "U+FF00-FFEF")      // Halfwidth and Fullwidth Forms
                    }
                ]
            });
    }
}
