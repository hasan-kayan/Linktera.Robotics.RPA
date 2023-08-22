﻿#pragma checksum "..\..\..\..\..\Shared\UiPath.Shared.Activities.Design\Controls\ComboboxControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E6CE37BDEB6FA1031D32881E48DC9A343EDA4B3A"
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
using System.Activities.Presentation.View;
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


namespace UiPath.Shared.Activities.Design.Controls {
    
    
    /// <summary>
    /// ComboboxControl
    /// </summary>
    public partial class ComboboxControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\Shared\UiPath.Shared.Activities.Design\Controls\ComboboxControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UiPath.Shared.Activities.Design.Controls.ComboboxControl Combobox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Shared\UiPath.Shared.Activities.Design\Controls\ComboboxControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Shared\UiPath.Shared.Activities.Design\Controls\ComboboxControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Activities.Presentation.View.ExpressionTextBox ComboboxInputBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Shared\UiPath.Shared.Activities.Design\Controls\ComboboxControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PropertiesComboBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LinkteraRobotics.ExcelActivities.CopySheet.Activities.Design;V1.0.0.0;component/" +
                    "controls/comboboxcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Shared\UiPath.Shared.Activities.Design\Controls\ComboboxControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Combobox = ((UiPath.Shared.Activities.Design.Controls.ComboboxControl)(target));
            return;
            case 2:
            this.Button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\Shared\UiPath.Shared.Activities.Design\Controls\ComboboxControl.xaml"
            this.Button.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboboxInputBox = ((System.Activities.Presentation.View.ExpressionTextBox)(target));
            return;
            case 4:
            this.PropertiesComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\..\..\..\Shared\UiPath.Shared.Activities.Design\Controls\ComboboxControl.xaml"
            this.PropertiesComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PropertiesComboBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\..\Shared\UiPath.Shared.Activities.Design\Controls\ComboboxControl.xaml"
            this.PropertiesComboBox.DropDownOpened += new System.EventHandler(this.PropertiesComboBox_OnDropDownOpened);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

