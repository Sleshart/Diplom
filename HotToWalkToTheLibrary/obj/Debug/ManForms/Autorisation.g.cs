﻿#pragma checksum "..\..\..\ManForms\Autorisation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67C17A6B1C925B89793AAC081505E183244ABA0D391E36BA489DE72768C3D7AF"
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
    /// Autorisation
    /// </summary>
    public partial class Autorisation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HotToWalkToTheLibrary.ManForms.Autorisation Authoris;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseButton;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LogText;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PassText;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PassTextBox;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Войти;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Втекст;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\ManForms\Autorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image HidePass;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\ManForms\Autorisation.xaml"
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
            System.Uri resourceLocater = new System.Uri("/HotToWalkToTheLibrary;component/manforms/autorisation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ManForms\Autorisation.xaml"
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
            this.Authoris = ((HotToWalkToTheLibrary.ManForms.Autorisation)(target));
            return;
            case 2:
            
            #line 35 "..\..\..\ManForms\Autorisation.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CloseButton = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            
            #line 68 "..\..\..\ManForms\Autorisation.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LogText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\ManForms\Autorisation.xaml"
            this.Login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Login_TextChanged);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\ManForms\Autorisation.xaml"
            this.Login.AddHandler(System.Windows.Input.Keyboard.KeyDownEvent, new System.Windows.Input.KeyEventHandler(this.Login_KeyDown));
            
            #line default
            #line hidden
            return;
            case 7:
            this.PassText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 76 "..\..\..\ManForms\Autorisation.xaml"
            this.Password.KeyDown += new System.Windows.Input.KeyEventHandler(this.Password_KeyDown);
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\ManForms\Autorisation.xaml"
            this.Password.PasswordChanged += new System.Windows.RoutedEventHandler(this.Password_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PassTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 79 "..\..\..\ManForms\Autorisation.xaml"
            this.PassTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PassTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Войти = ((System.Windows.Controls.Border)(target));
            
            #line 80 "..\..\..\ManForms\Autorisation.xaml"
            this.Войти.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Войти_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Втекст = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.HidePass = ((System.Windows.Controls.Image)(target));
            
            #line 100 "..\..\..\ManForms\Autorisation.xaml"
            this.HidePass.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.HidePass_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 100 "..\..\..\ManForms\Autorisation.xaml"
            this.HidePass.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.HidePass_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Error = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

