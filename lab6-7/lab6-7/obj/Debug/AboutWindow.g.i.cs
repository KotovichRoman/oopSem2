// Updated by XamlIntelliSenseFileGenerator 16.04.2022 1:13:34
#pragma checksum "..\..\AboutWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96179726AB9D3C6E6F819A62A49633D3A0876A5ED8F6A3519858DDAF37CDC999"
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
using lab6_7;


namespace lab6_7
{


    /// <summary>
    /// AboutWindow
    /// </summary>
    public partial class AboutWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 17 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageField;

#line default
#line hidden


#line 20 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameLabel;

#line default
#line hidden


#line 21 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameBox;

#line default
#line hidden


#line 24 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GenresLabel;

#line default
#line hidden


#line 25 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GenresBox;

#line default
#line hidden


#line 28 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PriceLabel;

#line default
#line hidden


#line 29 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PriceBox;

#line default
#line hidden


#line 32 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuantityLabel;

#line default
#line hidden


#line 33 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuantityBox;

#line default
#line hidden


#line 36 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StatusLabel;

#line default
#line hidden


#line 37 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StatusBox;

#line default
#line hidden


#line 41 "..\..\AboutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/lab6-7;component/aboutwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\AboutWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 7 "..\..\AboutWindow.xaml"
                    ((lab6_7.AboutWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);

#line default
#line hidden
                    return;
                case 2:
                    this.ImageField = ((System.Windows.Controls.Image)(target));
                    return;
                case 3:
                    this.NameLabel = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 4:
                    this.NameBox = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 5:
                    this.GenresLabel = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 6:
                    this.GenresBox = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 7:
                    this.PriceLabel = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 8:
                    this.PriceBox = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 9:
                    this.QuantityLabel = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 10:
                    this.QuantityBox = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 11:
                    this.StatusLabel = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 12:
                    this.StatusBox = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 13:
                    this.DeleteButton = ((System.Windows.Controls.Button)(target));

#line 41 "..\..\AboutWindow.xaml"
                    this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button EditButton;
    }
}

