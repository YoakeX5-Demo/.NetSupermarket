﻿#pragma checksum "..\..\..\..\Pages\UserManagement\Home.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "322414A99A6E06D28A75F1FE22E5148E074D1D57B9113088D555AF8A22E75233"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Supermarket.Pages;
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


namespace Supermarket.Pages.User {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Pages\UserManagement\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Filter;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\UserManagement\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_data;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\UserManagement\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\UserManagement\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Edit;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\UserManagement\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Delete;
        
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
            System.Uri resourceLocater = new System.Uri("/Supermarket;component/pages/usermanagement/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\UserManagement\Home.xaml"
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
            
            #line 13 "..\..\..\..\Pages\UserManagement\Home.xaml"
            ((Supermarket.Pages.User.Home)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_Filter = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\Pages\UserManagement\Home.xaml"
            this.tb_Filter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_Filter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dg_data = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btn_Add = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Pages\UserManagement\Home.xaml"
            this.btn_Add.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Pages\UserManagement\Home.xaml"
            this.btn_Edit.Click += new System.Windows.RoutedEventHandler(this.btn_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Pages\UserManagement\Home.xaml"
            this.btn_Delete.Click += new System.Windows.RoutedEventHandler(this.btn_Delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

