﻿#pragma checksum "C:\Users\gushchin\Documents\GitHub\InstagramWorkTest\InstagramDownloaderTest\View\StartView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A651B566FAA5CA7164786F81B57B1322"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InstagramDownloaderTest.UserSelectorControl;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace InstagramDownloaderTest.View {
    
    
    public partial class StartView : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Shell.ProgressIndicator loadingProgressBar;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal InstagramDownloaderTest.UserSelectorControl.SelectorControl Selector;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/InstagramDownloaderTest;component/View/StartView.xaml", System.UriKind.Relative));
            this.loadingProgressBar = ((Microsoft.Phone.Shell.ProgressIndicator)(this.FindName("loadingProgressBar")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Selector = ((InstagramDownloaderTest.UserSelectorControl.SelectorControl)(this.FindName("Selector")));
        }
    }
}

