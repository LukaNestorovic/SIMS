﻿#pragma checksum "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2CB479F761F723AE3D7E3B473EB002ED8CB33624"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjekatSIMS.View.DoctorView;
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


namespace ProjekatSIMS.View.DoctorView {
    
    
    /// <summary>
    /// ScheduleSurgery
    /// </summary>
    public partial class ScheduleSurgery : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Potvrdi;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Odustani;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBId;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DPTime;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPatient;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBDoctor;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBRoom;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBType;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPatient_Copy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjekatSIMS;component/view/doctorview/schedulesurgery.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Potvrdi = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            this.Potvrdi.Click += new System.Windows.RoutedEventHandler(this.Potvrdi_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Odustani = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            this.Odustani.Click += new System.Windows.RoutedEventHandler(this.Odustani_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TBId = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            this.TBId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Id_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DPTime = ((System.Windows.Controls.DatePicker)(target));
            
            #line 21 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            this.DPTime.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Time_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TBPatient = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            this.TBPatient.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Patient_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CBDoctor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            this.CBDoctor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Doctor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CBRoom = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            this.CBRoom.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Room_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TBType = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            this.TBType.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Type_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TBPatient_Copy = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\..\View\DoctorView\ScheduleSurgery.xaml"
            this.TBPatient_Copy.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Patient_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

