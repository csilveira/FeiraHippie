﻿#pragma checksum "C:\Users\CaioCesar\Documents\GitHub\FeiraHippie\TCC.FeiraHippie.WP\TCC.FeiraHippie.WP\Pages\ItemPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "86024E7DF5EFC0D18691A560A6A14AF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace TCC.FeiraHippie.WP {
    
    
    public partial class ItemPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock lblPageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtTitle;
        
        internal System.Windows.Controls.TextBox txtQuantity;
        
        internal System.Windows.Controls.TextBox txtDescription;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TCC.FeiraHippie.WP;component/Pages/ItemPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.lblPageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("lblPageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtTitle = ((System.Windows.Controls.TextBox)(this.FindName("txtTitle")));
            this.txtQuantity = ((System.Windows.Controls.TextBox)(this.FindName("txtQuantity")));
            this.txtDescription = ((System.Windows.Controls.TextBox)(this.FindName("txtDescription")));
        }
    }
}

