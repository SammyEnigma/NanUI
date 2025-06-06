// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace NetDimension.NanUI;

public sealed class MainWindowCreationAction : IDisposable
{
    public MainWindowCreationAction(Action<IServiceProvider> createAction)
    {
        CreateAction = createAction;
    }

    internal Action<IServiceProvider> CreateAction { get; }

    internal void Invoke(IServiceProvider services)
    {
        CreateAction.Invoke(services);
    }

    public void Dispose()
    {
    }
}


