﻿#pragma checksum "..\..\..\ManForms\BooksChanger.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE16666CD786CA96CE1CFC3A8DB11BD59A8E56145D81353A4D4306DE0034DA2A"
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
    /// BooksChanger
    /// </summary>
    public partial class BooksChanger : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\ManForms\BooksChanger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HotToWalkToTheLibrary.ManForms.BooksChanger ChangerWindow;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ManForms\BooksChanger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Title;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ManForms\BooksChanger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Author;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ManForms\BooksChanger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MakeYears;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ManForms\BooksChanger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HowMany;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\ManForms\BooksChanger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\ManForms\BooksChanger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Action;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\ManForms\BooksChanger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Atext;
        
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
            System.Uri resourceLocater = new System.Uri("/HotToWalkToTheLibrary;component/manforms/bookschanger.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ManForms\BooksChanger.xaml"
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
            this.ChangerWindow = ((HotToWalkToTheLibrary.ManForms.BooksChanger)(target));
            return;
            case 2:
            this.Title = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Author = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.MakeYears = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.HowMany = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 47 "..\..\..\ManForms\BooksChanger.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 49 "..\..\..\ManForms\BooksChanger.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CloseButton = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.Action = ((System.Windows.Controls.Border)(target));
            
            #line 72 "..\..\..\ManForms\BooksChanger.xaml"
            this.Action.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Action_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Atext = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

