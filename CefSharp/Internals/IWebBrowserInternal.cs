﻿// Copyright © 2010-2016 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;

namespace CefSharp.Internals
{
    /// <summary>
    /// Interface implemented by UI control that contains
    /// a ManagedCefBrowserAdapter instance.
    /// </summary>
    public interface IWebBrowserInternal : IWebBrowser
    {
        void OnAfterBrowserCreated();

        void SetAddress(AddressChangedEventArgs args);
        void SetLoadingStateChange(LoadingStateChangedEventArgs args);
        void SetTitle(TitleChangedEventArgs args);
        void SetTooltipText(string tooltipText);

        void OnFrameLoadStart(FrameLoadStartEventArgs args);
        void OnFrameLoadEnd(FrameLoadEndEventArgs args);
        void OnConsoleMessage(ConsoleMessageEventArgs args);
        void OnStatusMessage(StatusMessageEventArgs args);
        void OnLoadError(LoadErrorEventArgs args);

        IBrowserAdapter BrowserAdapter { get; }
        bool HasParent { get; set; }
        IntPtr ControlHandle { get; }
    }
}
