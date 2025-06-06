// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace NetDimension.NanUI.CefGlue;
/// <summary>
/// DOM event category flags.
/// </summary>
public enum CefDomEventCategory
{
    Unknown = 0x0,
    UI = 0x1,
    Mouse = 0x2,
    Mutation = 0x4,
    Keyboard = 0x8,
    Text = 0x10,
    Composition = 0x20,
    Drag = 0x40,
    Clipboard = 0x80,
    Message = 0x100,
    Wheel = 0x200,
    BeforeTextInserted = 0x400,
    Overflow = 0x800,
    PageTransition = 0x1000,
    PopState = 0x2000,
    Progress = 0x4000,
    XmlHttpRequestProgress = 0x8000,
}
