﻿#pragma checksum "..\..\..\EventsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F76E542DEA032FB9A9B1DD2D097B9BF07439EB94"
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
using lab9;


namespace lab9 {
    
    
    /// <summary>
    /// EventsWindow
    /// </summary>
    public partial class EventsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\EventsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RoutedTextBox1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\EventsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RoutedTextBox2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\EventsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FirstRoutedBtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\EventsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SecondRoutedBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/lab9;component/eventswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EventsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RoutedTextBox1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.RoutedTextBox2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            
            #line 22 "..\..\..\EventsWindow.xaml"
            ((System.Windows.Controls.ListBox)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.FirstRoutedBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\..\EventsWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.FirstRoutedBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FirstRoutedBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\EventsWindow.xaml"
            this.FirstRoutedBtn.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.FirstRoutedBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 25 "..\..\..\EventsWindow.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.FirstRoutedBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 30 "..\..\..\EventsWindow.xaml"
            ((System.Windows.Controls.ListBox)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SecondRoutedBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 31 "..\..\..\EventsWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SecondRoutedBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SecondRoutedBtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\EventsWindow.xaml"
            this.SecondRoutedBtn.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SecondRoutedBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 33 "..\..\..\EventsWindow.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SecondRoutedBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
