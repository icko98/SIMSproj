﻿#pragma checksum "..\..\..\Windows\ScheduleRenovation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CBAE2507C1438AAD9ECCABFD559E79E0CDF35E4DE666486545CE0201E7936DAB"
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
using ZdravoHospital.Windows;


namespace ZdravoHospital.Windows {
    
    
    /// <summary>
    /// ScheduleRenovation
    /// </summary>
    public partial class ScheduleRenovation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Windows\ScheduleRenovation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomId;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\ScheduleRenovation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker StartDate;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\ScheduleRenovation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EndDate;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\ScheduleRenovation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\ScheduleRenovation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonYes;
        
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
            System.Uri resourceLocater = new System.Uri("/ZdravoHospital;component/windows/schedulerenovation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ScheduleRenovation.xaml"
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
            this.RoomId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.StartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.EndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.Description = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Windows\ScheduleRenovation.xaml"
            this.Description.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 32 "..\..\..\Windows\ScheduleRenovation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_No);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonYes = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Windows\ScheduleRenovation.xaml"
            this.ButtonYes.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Yes);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

