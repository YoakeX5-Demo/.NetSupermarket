   M S B A M L   `   `   `  ���� F  BSupermarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Supermarket.PagesSupermarket.Pages  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf -    'Supermarket.Pages.MemberManagement.Home   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  +localclr-namespace:Supermarket.Pages  >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  -   ���	#FF5B5B5B.��� 
�������.+�� $��16q�  � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -    ��Name$ tb_FilterNumber�� !  MaterialDesignOutlinedTextBox#��[  $	��Top=�$
��auto�� �� AcceptsReturn .  �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 输入ID筛选��&   System.Windows.Controls.DataGrid  -     Name$ dg_data��$��1��$��0,16,0,0q�   CanUserAddRows .     CanUserResizeRows .  	   
IsReadOnly	 . 
   HeadersVisibility$
 Column=�A� $��0,16,0,0q�$��2�� A� Rows$ 1��$	��Top=�$
��Left=�$	��468��.+��� -    ��Name$ btn_Add��$��添加会员��$��Center=�$	��Top=�$	��100���� -   $ btn_Add2��$��充值会员��$��Center=�$	��Top=�$	��100���� -   $ btn_Edit��$��修改会员��$��Center=�$	��Top=�$	��100���� -   $ 
btn_Delete��$��删除会员��$��Center=�$	��Top=�$	��100��