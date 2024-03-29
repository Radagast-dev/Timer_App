﻿#pragma checksum "..\..\..\Timer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "257DBCE521082A530385165621313FFBC1D9DB30"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using Timer_App;


namespace Timer_App {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label secLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label inputSecLabel;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button setInput;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox countUp;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox countDown;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement bttf_time_machine_gif;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement bttf_theme_song;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Timer_App;component/timer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Timer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.startButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Timer.xaml"
            this.startButton.Click += new System.Windows.RoutedEventHandler(this.startButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.stopButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Timer.xaml"
            this.stopButton.Click += new System.Windows.RoutedEventHandler(this.stopButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.secLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.inputSecLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.setInput = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Timer.xaml"
            this.setInput.Click += new System.Windows.RoutedEventHandler(this.setInput_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.inputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.countUp = ((System.Windows.Controls.CheckBox)(target));
            
            #line 17 "..\..\..\Timer.xaml"
            this.countUp.Checked += new System.Windows.RoutedEventHandler(this.countUp_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.countDown = ((System.Windows.Controls.CheckBox)(target));
            
            #line 18 "..\..\..\Timer.xaml"
            this.countDown.Checked += new System.Windows.RoutedEventHandler(this.countDown_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.bttf_time_machine_gif = ((System.Windows.Controls.MediaElement)(target));
            
            #line 19 "..\..\..\Timer.xaml"
            this.bttf_time_machine_gif.MediaEnded += new System.Windows.RoutedEventHandler(this.bttf_time_machine_gif_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 11:
            this.bttf_theme_song = ((System.Windows.Controls.MediaElement)(target));
            
            #line 20 "..\..\..\Timer.xaml"
            this.bttf_theme_song.MediaEnded += new System.Windows.RoutedEventHandler(this.bttf_theme_song_MediaEnded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

