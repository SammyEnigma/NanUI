// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI


using NetDimension.NanUI.CefGlue.Interop;

namespace NetDimension.NanUI.CefGlue;
/// <summary>
/// Structure representing IME composition underline information. This is a thin
/// wrapper around Blink's WebCompositionUnderline class and should be kept in
/// sync with that.
/// </summary>
public sealed class CefCompositionUnderline
{
    /// <summary>
    /// Underline character range.
    /// </summary>
    public CefRange Range { get; set; }

    /// <summary>
    /// Text color.
    /// </summary>
    public CefColor Color { get; set; }

    /// <summary>
    /// Background color.
    /// </summary>
    public CefColor BackgroundColor;

    /// <summary>
    /// Set to true (1) for thick underline.
    /// </summary>
    public bool Thick { get; set; }

    /// <summary>
    /// Style.
    /// </summary>
    public CefCompositionUnderlineStyle Style { get; set; }

    internal cef_composition_underline_t ToNative()
    {
        cef_composition_underline_t result;
        result.range = new cef_range_t(Range.From, Range.To);
        result.color = Color.ToArgb();
        result.background_color = BackgroundColor.ToArgb();
        result.thick = Thick ? 1 : 0;
        result.style = Style;
        return result;
    }
}
