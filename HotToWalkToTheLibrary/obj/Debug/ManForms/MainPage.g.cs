﻿#pragma checksum "..\..\..\ManForms\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7ED93981DADDD27D057C9DEDEAE2A80CB623C6CFF6EB2A90140B5620D91549D4"
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
using Microsoft.Windows.Themes;
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
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\ManForms\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Add;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ManForms\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Edit;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ManForms\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Delete;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ManForms\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SearchText;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ManForms\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ManForms\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Reload;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ManForms\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform Angle;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\ManForms\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MainDataGrid;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\ManForms\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Error;
        
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
            System.Uri resourceLocater = new System.Uri("/HotToWalkToTheLibrary;component/manforms/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ManForms\MainPage.xaml"
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
            this.Add = ((System.Windows.Controls.Image)(target));
            
            #line 17 "..\..\..\ManForms\MainPage.xaml"
            this.Add.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Add_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Edit = ((System.Windows.Controls.Image)(target));
            
            #line 18 "..\..\..\ManForms\MainPage.xaml"
            this.Edit.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Edit_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Delete = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\..\ManForms\MainPage.xaml"
            this.Delete.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Delete_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\ManForms\MainPage.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Reload = ((System.Windows.Controls.Image)(target));
            
            #line 36 "..\..\..\ManForms\MainPage.xaml"
            this.Reload.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Reload_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Angle = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 8:
            this.MainDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 66 "..\..\..\ManForms\MainPage.xaml"
            this.MainDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Error = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
