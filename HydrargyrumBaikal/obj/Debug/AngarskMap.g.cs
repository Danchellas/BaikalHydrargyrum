﻿#pragma checksum "..\..\AngarskMap.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "190F785EFE0402E70F8F4BD98F53887236DE724D45A56C04B0364070A27FAD82"
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
    /// AngarskMap
    /// </summary>
    public partial class AngarskMap : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\AngarskMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExportButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AngarskMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AngarskMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VizualisationButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AngarskMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map AHydragyrumMap;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AngarskMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExportFileButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AngarskMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AngarskMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label2;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AngarskMap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label3;
        
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
            System.Uri resourceLocater = new System.Uri("/HydrargyrumBaikal;component/angarskmap.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AngarskMap.xaml"
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
            
            #line 23 "..\..\AngarskMap.xaml"
            this.ExportButton.Click += new System.Windows.RoutedEventHandler(this.ExportButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BDButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\AngarskMap.xaml"
            this.BDButton.Click += new System.Windows.RoutedEventHandler(this.BDButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.VizualisationButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AngarskMap.xaml"
            this.VizualisationButton.Click += new System.Windows.RoutedEventHandler(this.VizualisationButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AHydragyrumMap = ((Microsoft.Maps.MapControl.WPF.Map)(target));
            return;
            case 5:
            this.ExportFileButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\AngarskMap.xaml"
            this.ExportFileButton.Click += new System.Windows.RoutedEventHandler(this.ExportFileButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\AngarskMap.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Label3 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

