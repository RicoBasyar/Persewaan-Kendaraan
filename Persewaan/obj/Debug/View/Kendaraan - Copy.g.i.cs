﻿#pragma checksum "..\..\..\View\Kendaraan - Copy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB69B521F202F7237F1852FDAD60E6FFB1D6EEE489BEFD1872F24025D1EE7646"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Persewaan.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Persewaan.View {
    
    
    /// <summary>
    /// Kendaraan
    /// </summary>
    public partial class Kendaraan : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentFade;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtnopol;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbmotor;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbmobil;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox merk;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox harga_perhari;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\Kendaraan - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Persewaan;component/view/kendaraan%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Kendaraan - Copy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TrainsitionigContentSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 2:
            this.TrainsitionigContentFade = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 3:
            this.txtnopol = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\View\Kendaraan - Copy.xaml"
            this.txtnopol.GotFocus += new System.Windows.RoutedEventHandler(this.txtnopol_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rdbmotor = ((System.Windows.Controls.RadioButton)(target));
            
            #line 27 "..\..\..\View\Kendaraan - Copy.xaml"
            this.rdbmotor.Checked += new System.Windows.RoutedEventHandler(this.rdbmotor_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rdbmobil = ((System.Windows.Controls.RadioButton)(target));
            
            #line 28 "..\..\..\View\Kendaraan - Copy.xaml"
            this.rdbmobil.Checked += new System.Windows.RoutedEventHandler(this.rdbmobil_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.merk = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\View\Kendaraan - Copy.xaml"
            this.merk.GotFocus += new System.Windows.RoutedEventHandler(this.merk_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.harga_perhari = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\View\Kendaraan - Copy.xaml"
            this.harga_perhari.GotFocus += new System.Windows.RoutedEventHandler(this.harga_perhari_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\View\Kendaraan - Copy.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Edit = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\View\Kendaraan - Copy.xaml"
            this.Edit.Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\View\Kendaraan - Copy.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

