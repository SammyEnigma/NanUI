// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

using System.ComponentModel;

using NetDimension.NanUI.Properties;

namespace NetDimension.NanUI.Browser.EmbeddedBrowser;
internal class EmbeddedBrowserWindow : StandardWindowForm
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public nint? BrowserWindowHandle { get; internal set; }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public CefBrowser? Browser { get; internal set; }

    public EmbeddedBrowserWindow()
        : base(false, false)
    {

        Text = $"{Messages.External_Browser_Loading} - {Messages.External_Browser_Title}";
        Icon = Resources.DefaultIcon;


        SizeChanged += (_, _) =>
        {
            if (BrowserWindowHandle != null)
            {
                User32.SetWindowPos(BrowserWindowHandle.Value, HWND.NULL, 0, 0, ClientSize.Width, ClientSize.Height, User32.SetWindowPosFlags.SWP_NOMOVE | User32.SetWindowPosFlags.SWP_NOZORDER | User32.SetWindowPosFlags.SWP_NOACTIVATE);
            }
        };

        Activated += (_, _) =>
        {
            Browser?.GetHost()?.SetFocus(true);
        };

        Deactivate += (_, _) =>
        {
            Browser?.GetHost()?.SetFocus(false);
        };
    }
}
