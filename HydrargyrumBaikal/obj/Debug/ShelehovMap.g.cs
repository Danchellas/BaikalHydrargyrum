﻿#pragma checksum "..\..\ShelehovMap.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9B3EFC2F9A9E9D42F82C680BBEF4190A35110C55655ECF62E4174209B291F604"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HydrargyrumBaikal;
using Microsoft.Maps.MapControl.WPF;
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


namespace HydrargyrumBaikal {
    
    
    /// <summary>
    /// ShelehovMap
    /// </summary>
    public partial class ShelehovMap : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\ShelehovMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExportButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ShelehovMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ShelehovMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VizualisationButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ShelehovMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map ShHydragyrumMap;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ShelehovMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExportFileButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ShelehovMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label3;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ShelehovMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ShelehovMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label2;
        
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
            System.Uri resourceLocater = new System.Uri("/HydrargyrumBaikal;component/shelehovmap.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ShelehovMap.xaml"
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
            this.ExportButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\ShelehovMap.xaml"
            this.ExportButton.Click += new System.Windows.RoutedEventHandler(this.ExportButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BDButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ShelehovMap.xaml"
            this.BDButton.Click += new System.Windows.RoutedEventHandler(this.BDButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.VizualisationButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\ShelehovMap.xaml"
            this.VizualisationButton.Click += new System.Windows.RoutedEventHandler(this.VizualisationButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ShHydragyrumMap = ((Microsoft.Maps.MapControl.WPF.Map)(target));
            return;
            case 5:
            this.ExportFileButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\ShelehovMap.xaml"
            this.ExportFileButton.Click += new System.Windows.RoutedEventHandler(this.ExportFileButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\ShelehovMap.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Label2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

