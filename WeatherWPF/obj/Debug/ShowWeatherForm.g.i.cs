﻿#pragma checksum "..\..\ShowWeatherForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39A7D96BBFB17BA0DAFFD0298EA5C5773509F790"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WeatherWPF;


namespace WeatherWPF {
    
    
    /// <summary>
    /// ShowWeatherForm
    /// </summary>
    public partial class ShowWeatherForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\ShowWeatherForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_cityName;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ShowWeatherForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_country;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ShowWeatherForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_temperature1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ShowWeatherForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ShowWeatherForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock day_of_weeks1;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ShowWeatherForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_humidity1;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ShowWeatherForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_wind1;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ShowWeatherForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_date1;
        
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
            System.Uri resourceLocater = new System.Uri("/WeatherWPF;component/showweatherform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ShowWeatherForm.xaml"
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
            this.text_cityName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.text_country = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.text_temperature1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.day_of_weeks1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.text_humidity1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.text_wind1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.text_date1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 56 "..\..\ShowWeatherForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
