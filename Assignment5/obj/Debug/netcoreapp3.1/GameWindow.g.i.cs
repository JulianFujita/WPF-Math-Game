﻿#pragma checksum "..\..\..\GameWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26D9AB943D013BA3D2617351F7574863FFE854DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Assignment5;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Assignment5 {
    
    
    /// <summary>
    /// GameWindow
    /// </summary>
    public partial class GameWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label game_type_label;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ready_button;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label countdown_label;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label second_number_label;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label first_number_label;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label operator_label;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label equality_label;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox answer_box;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timer_label;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label feedback_label;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button quit_button;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submit_button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Assignment5;component/gamewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GameWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.game_type_label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ready_button = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\GameWindow.xaml"
            this.ready_button.Click += new System.Windows.RoutedEventHandler(this.ReadyButtonPressed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.countdown_label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.second_number_label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.first_number_label = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.operator_label = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.equality_label = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.answer_box = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\GameWindow.xaml"
            this.answer_box.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.AnswerBoxChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.timer_label = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.feedback_label = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.quit_button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\GameWindow.xaml"
            this.quit_button.Click += new System.Windows.RoutedEventHandler(this.QuitButtonPressed);
            
            #line default
            #line hidden
            return;
            case 12:
            this.submit_button = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\GameWindow.xaml"
            this.submit_button.Click += new System.Windows.RoutedEventHandler(this.SubmitButtonPressed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

