﻿#pragma checksum "C:\Users\adams\Documents\Visual Studio 2012\Projects\AdamsCronometro\AdamsCronometro\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F88D0A0E7BF7BE41C68200D1D6E3F16B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace AdamsCronometro {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot Pivot;
        
        internal System.Windows.Controls.TextBlock lblTempo;
        
        internal System.Windows.Controls.Grid Cronometro;
        
        internal System.Windows.Media.RotateTransform PointerAngle;
        
        internal System.Windows.Shapes.Path ponteiro;
        
        internal Microsoft.Phone.Controls.LongListSelector MainLongListSelector;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AdamsCronometro;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Pivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("Pivot")));
            this.lblTempo = ((System.Windows.Controls.TextBlock)(this.FindName("lblTempo")));
            this.Cronometro = ((System.Windows.Controls.Grid)(this.FindName("Cronometro")));
            this.PointerAngle = ((System.Windows.Media.RotateTransform)(this.FindName("PointerAngle")));
            this.ponteiro = ((System.Windows.Shapes.Path)(this.FindName("ponteiro")));
            this.MainLongListSelector = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("MainLongListSelector")));
        }
    }
}

