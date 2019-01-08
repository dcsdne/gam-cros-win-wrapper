﻿#pragma checksum "..\..\..\Windows\PreferencesWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4F97497D2238A370BAB64B9F27E1A1DCEAF26F43"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChromebookGUI;
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


namespace ChromebookGUI {
    
    
    /// <summary>
    /// PreferencesWindow
    /// </summary>
    public partial class PreferencesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveAndCloseButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PrioritiesTextBlock;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SearchForAssetIdsBeforeSerialNumbersCheckBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InstructionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PrioritiesTextBlock_Copy;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ShowWarningWhenImportingFromCSVFile;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UpdatesTextBlock;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox PromptWhenUpdatesAreAvailableCheckBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ViewsTextBlock;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Windows\PreferencesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox UseTextBoxLayoutInsteadOfButtonLayoutCheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ChromebookGUI;component/windows/preferenceswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\PreferencesWindow.xaml"
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
            this.SaveAndCloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Windows\PreferencesWindow.xaml"
            this.SaveAndCloseButton.Click += new System.Windows.RoutedEventHandler(this.SaveAndCloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Windows\PreferencesWindow.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PrioritiesTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.SearchForAssetIdsBeforeSerialNumbersCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.InstructionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.PrioritiesTextBlock_Copy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ShowWarningWhenImportingFromCSVFile = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.UpdatesTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.PromptWhenUpdatesAreAvailableCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.ViewsTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.UseTextBoxLayoutInsteadOfButtonLayoutCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

