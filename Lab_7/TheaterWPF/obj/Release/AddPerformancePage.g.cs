﻿#pragma checksum "..\..\AddPerformancePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AA75A97349CCAFB5F4F8B356F0F0CC47892AFE61"
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
using TheaterWPF;


namespace TheaterWPF {
    
    
    /// <summary>
    /// AddPerformacePage
    /// </summary>
    public partial class AddPerformacePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AddPerformancePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid contentGrid;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddPerformancePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label headlineLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddPerformancePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock msgBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddPerformancePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddPerformancePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dateTextBlock_Copy;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddPerformancePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameInputBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddPerformancePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker inputDatePicker;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddPerformancePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TheaterWPF;component/addperformancepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddPerformancePage.xaml"
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
            this.contentGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.headlineLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.msgBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.nameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.dateTextBlock_Copy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.nameInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.inputDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\AddPerformancePage.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.AddPerformanceButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

