﻿#pragma checksum "..\..\Glav.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C3888937A2ABAC9D357C8D294E823E479ED7815549A64582A1143A5449D8B960"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Glav
    /// </summary>
    public partial class Glav : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Glav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Glavnaya;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Glav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Zakazchik;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Glav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Orders;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Glav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cars;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Glav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Vihod;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Glav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Glav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sodzat;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/glav.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Glav.xaml"
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
            this.Glavnaya = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Glav.xaml"
            this.Glavnaya.Click += new System.Windows.RoutedEventHandler(this.Glav_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Zakazchik = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Glav.xaml"
            this.Zakazchik.Click += new System.Windows.RoutedEventHandler(this.Zakazchiki_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Orders = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Glav.xaml"
            this.Orders.Click += new System.Windows.RoutedEventHandler(this.Orders_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Cars = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Glav.xaml"
            this.Cars.Click += new System.Windows.RoutedEventHandler(this.Cars_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Vihod = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Glav.xaml"
            this.Vihod.Click += new System.Windows.RoutedEventHandler(this.Vihod_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 15 "..\..\Glav.xaml"
            this.MainFrame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.MainFrame_Navigated);
            
            #line default
            #line hidden
            
            #line 15 "..\..\Glav.xaml"
            this.MainFrame.ContentRendered += new System.EventHandler(this.MainFrame_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Sodzat = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Glav.xaml"
            this.Sodzat.Click += new System.Windows.RoutedEventHandler(this.Sozdat_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

