#pragma checksum "..\..\SiteOwner.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81A9D903596EDE16F3AD7404E27675DA"
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
    /// SiteOwner
    /// </summary>
    public partial class SiteOwner : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\SiteOwner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\SiteOwner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GrSO;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\SiteOwner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnHU;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\SiteOwner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnHost;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\SiteOwner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_GR;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\SiteOwner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grGR;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\SiteOwner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_commition;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\SiteOwner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Enter;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\SiteOwner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PSW;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/siteowner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SiteOwner.xaml"
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
            
            #line 25 "..\..\SiteOwner.xaml"
            this.GoBack.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GrSO = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.BtnHU = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\SiteOwner.xaml"
            this.BtnHU.Click += new System.Windows.RoutedEventHandler(this.BtnHU_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnHost = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\SiteOwner.xaml"
            this.BtnHost.Click += new System.Windows.RoutedEventHandler(this.BtnHost_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Btn_GR = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\SiteOwner.xaml"
            this.Btn_GR.Click += new System.Windows.RoutedEventHandler(this.Btn_GR_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.grGR = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.btn_commition = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\SiteOwner.xaml"
            this.btn_commition.Click += new System.Windows.RoutedEventHandler(this.commision_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Enter = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\SiteOwner.xaml"
            this.Enter.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Enter);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PSW = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 10:
            
            #line 96 "..\..\SiteOwner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ForgetPsw_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

