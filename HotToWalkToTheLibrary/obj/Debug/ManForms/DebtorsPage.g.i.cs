﻿#pragma checksum "..\..\..\ManForms\DebtorsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E4E239ED120BAABA1641D5B9F359208CAF8568D0E56D164FA093EB2E7DAD2EAF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HotToWalkToTheLibrary.ManForms;
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


namespace HotToWalkToTheLibrary.ManForms {
    
    
    /// <summary>
    /// DebtorsPage
    /// </summary>
    public partial class DebtorsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\ManForms\DebtorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SearchText;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ManForms\DebtorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ManForms\DebtorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Reload;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ManForms\DebtorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform Angle;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\ManForms\DebtorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MainDataGrid;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\ManForms\DebtorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Error;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\ManForms\DebtorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Debtor;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\ManForms\DebtorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Атекст;
        
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
            System.Uri resourceLocater = new System.Uri("/HotToWalkToTheLibrary;component/manforms/debtorspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ManForms\DebtorsPage.xaml"
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
            this.SearchText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\ManForms\DebtorsPage.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Reload = ((System.Windows.Controls.Image)(target));
            
            #line 34 "..\..\..\ManForms\DebtorsPage.xaml"
            this.Reload.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Reload_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Angle = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 5:
            this.MainDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 64 "..\..\..\ManForms\DebtorsPage.xaml"
            this.MainDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Error = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Debtor = ((System.Windows.Controls.Border)(target));
            
            #line 75 "..\..\..\ManForms\DebtorsPage.xaml"
            this.Debtor.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Debtor_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Атекст = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
