// Updated by XamlIntelliSenseFileGenerator 2021/7/10 12:41:35
#pragma checksum "..\..\..\..\Pages\User\UserManagement.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0066595DAB2A0A82C9D63C9CF305C8F508025EE72567D5C529E5CA88A37625A5"
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


namespace Supermarket.Pages
{


    /// <summary>
    /// UserManagement
    /// </summary>
    public partial class UserManagement : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 20 "..\..\..\..\Pages\User\UserManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Filter;

#line default
#line hidden


#line 30 "..\..\..\..\Pages\User\UserManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_data;

#line default
#line hidden


#line 35 "..\..\..\..\Pages\User\UserManagement.xaml"
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
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Supermarket;component/pages/user/usermanagement.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Pages\User\UserManagement.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 11 "..\..\..\..\Pages\User\UserManagement.xaml"
                    ((Supermarket.Pages.UserManagement)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);

#line default
#line hidden
                    return;
                case 2:
                    this.tb_Filter = ((System.Windows.Controls.TextBox)(target));

#line 29 "..\..\..\..\Pages\User\UserManagement.xaml"
                    this.tb_Filter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_Filter_TextChanged);

#line default
#line hidden
                    return;
                case 3:
                    this.dg_data = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 4:
                    this.btn_Delete = ((System.Windows.Controls.Button)(target));

#line 35 "..\..\..\..\Pages\User\UserManagement.xaml"
                    this.btn_Delete.Click += new System.Windows.RoutedEventHandler(this.btn_Delete_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btn_Add;
    }
}

