﻿#pragma checksum "C:\Users\thomas\Documents\Visual Studio 2012\Projects\PhoneApp1\PhoneApp1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E24D3BA659A3A0DB3C19D9B9D91EF3DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18033
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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


namespace PhoneApp1 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel WinSoul;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox Login;
        
        internal System.Windows.Controls.TextBlock aff_log;
        
        internal System.Windows.Controls.TextBlock aff_mdp;
        
        internal System.Windows.Controls.PasswordBox Mdp;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.WinSoul = ((System.Windows.Controls.StackPanel)(this.FindName("WinSoul")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Login = ((System.Windows.Controls.TextBox)(this.FindName("Login")));
            this.aff_log = ((System.Windows.Controls.TextBlock)(this.FindName("aff_log")));
            this.aff_mdp = ((System.Windows.Controls.TextBlock)(this.FindName("aff_mdp")));
            this.Mdp = ((System.Windows.Controls.PasswordBox)(this.FindName("Mdp")));
        }
    }
}

