﻿#pragma checksum "..\..\EditRouteWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "319461E1AE9714EDD3EDA59C83C7B776"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BusSystemUI;
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


namespace BusSystemUI {
    
    
    /// <summary>
    /// EditRouteWindow
    /// </summary>
    public partial class EditRouteWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\EditRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label titleLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\EditRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image busImage;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\EditRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label windowLabel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\EditRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox routeIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\EditRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox distanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\EditRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox employeeIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\EditRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\EditRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BusSystemUI;component/editroutewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditRouteWindow.xaml"
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
            this.titleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.busImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.windowLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.routeIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.distanceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.employeeIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\EditRouteWindow.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.submitButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.returnButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\EditRouteWindow.xaml"
            this.returnButton.Click += new System.Windows.RoutedEventHandler(this.returnButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
