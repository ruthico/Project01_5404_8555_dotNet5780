﻿#pragma checksum "..\..\LinqHu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE74817FF58D432B8978EA5957C6F5E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF;
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


namespace PLWPF {
    
    
    /// <summary>
    /// LinqHu
    /// </summary>
    public partial class LinqHu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BGR;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListView_HU;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Bhu;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid availibleGRID;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EntryDate_DatePicker;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SumOFday;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BUSY;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid busyGRID;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EntryDate_DatePicker1;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\LinqHu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SumOFday1;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/linqhu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LinqHu.xaml"
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
            this.GoBack = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\LinqHu.xaml"
            this.GoBack.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BGR = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.ListView_HU = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            
            #line 149 "..\..\LinqHu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AvailibleUnit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 157 "..\..\LinqHu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AllUnit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 165 "..\..\LinqHu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BusyUnit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Bhu = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.availibleGRID = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.EntryDate_DatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.SumOFday = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 182 "..\..\LinqHu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AvailibleClickCheck);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BUSY = ((System.Windows.Controls.Border)(target));
            return;
            case 13:
            this.busyGRID = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            this.EntryDate_DatePicker1 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 15:
            this.SumOFday1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            
            #line 191 "..\..\LinqHu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BusyClickCheck);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

