// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI


using NetDimension.NanUI.CefGlue.Interop;

namespace NetDimension.NanUI.CefGlue;
/// <summary>
/// Callback interface used to asynchronously continue a download.
/// </summary>
public sealed unsafe partial class CefBeforeDownloadCallback
{
    /// <summary>
    /// Call to continue the download. Set |download_path| to the full file path
    /// for the download including the file name or leave blank to use the
    /// suggested name and the default temp directory. Set |show_dialog| to true
    /// if you do wish to show the default "Save As" dialog.
    /// </summary>
    public void Continue(string downloadPath, bool showDialog)
    {
        fixed (char* downloadPath_ptr = downloadPath)
        {
            var n_downloadPath = new cef_string_t(downloadPath_ptr, downloadPath != null ? downloadPath.Length : 0);
            cef_before_download_callback_t.cont(_self, &n_downloadPath, showDialog ? 1 : 0);
        }
    }
}
