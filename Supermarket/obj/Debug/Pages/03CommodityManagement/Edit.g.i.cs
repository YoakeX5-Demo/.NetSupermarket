﻿#pragma checksum "..\..\..\..\Pages\03CommodityManagement\Edit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9CBBE2FB0BDC7A0121A469CEBDC613967AE8B97E1CA79A904A2C93571190E393"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DMSkin.WPF.Small;
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


namespace Supermarket.Pages.CommodityManagement {
    
    
    /// <summary>
    /// Edit
    /// </summary>
    public partial class Edit : DMSkin.WPF.Small.DMSkinWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_commodityID;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_commodityPrice;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_manufacturer;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_commodityName;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_discount;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_statement;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_picture;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_categoryID;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Certain;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Supermarket;component/pages/03commoditymanagement/edit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
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
            
            #line 29 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
            ((Supermarket.Pages.CommodityManagement.Edit)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_commodityID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_commodityPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_manufacturer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_commodityName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txt_discount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txt_statement = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.img_picture = ((System.Windows.Controls.Image)(target));
            
            #line 48 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
            this.img_picture.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.img_picture_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cb_categoryID = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.btn_Certain = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
            this.btn_Certain.Click += new System.Windows.RoutedEventHandler(this.btn_Certain_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\Pages\03CommodityManagement\Edit.xaml"
            this.btn_Cancel.Click += new System.Windows.RoutedEventHandler(this.btn_Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

