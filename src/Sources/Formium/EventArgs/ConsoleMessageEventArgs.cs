// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace NetDimension.NanUI;

public class ConsoleMessageEventArgs : EventArgs
{

    public ConsoleMessageEventArgs(CefBrowser browser, CefLogSeverity level, string message, string source, int line)
    {
        Level = level;
        Message = message;
        Source = source;
        Line = line;
    }

    public CefLogSeverity Level { get; }
    public string Message { get; }
    public string Source { get; }
    public int Line { get; }
    public bool Handled { get; set; } = false;
}
