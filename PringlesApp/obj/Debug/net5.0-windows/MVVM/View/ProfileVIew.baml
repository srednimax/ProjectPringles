   M S B A M L   `   `   `  ����F  BPringlesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PringlesApp.MVVM.ViewPringlesApp.MVVM.View  5      G(clr-namespace:PringlesApp.MVVM.ViewModelPringlesApp.MVVM.ViewModel  5      '    !PringlesApp.MVVM.View.ProfileVIew   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PringlesApp.MVVM.View     5      >	viewModel(clr-namespace:PringlesApp.MVVM.ViewModel     5       *  &MaterialDesignLightSeparatorBackground#���   5
        � DataContext  5      1   +PringlesApp.MVVM.ViewModel.ProfileViewModel  5   
   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6!   $��Nazwa użytkownika:��61   $��Center=�5       $
��Left=�6/      MaterialDesignBody1TextBlock#���  5!      �� 5"   
   $��1��6   $��2��6!   $��Center=�5$      $
��Left=�6/   #���  5%      ��5#      �� *User.Username+5%      �� 5'   
   $��2��6   $��1��6!   $��Email:��61   $��Center=�5(      $
��Left=�6/   #���  5)      �� 5*   
   $��2��6   $��2��6!   $��Center=�5,      $
��Left=�6/   #���  5-      ��5+      �� *
User.Email+5-      �� 5/   
   $��3��6   $��1��6!   $��Data urodzenia:��61   $��Center=�50      $
��Left=�6/   #���  51      �� 52   
   $��3��6   $��2��6!   $��Center=�54      $
��Left=�6/   #���  55      ��53      �� *User.DateOfBirth+ �� StringFormat$ {0:yyyy-mm-dd}��55      �� 57   
   $��4��6   $��1��6!   $��Płeć:��61   $��Center=�58      $
��Left=�6/   #���  59      �� 5:   
   $��4��6   $��2��6!   $��Center=�5<      $
��Left=�6/   #���  5=      ��5;      �� *User.Gender+5=      �� 5?   
   $��5��6   $��1��6!   $��Numer telefonu:��61   $��Center=�5@      $
��Left=�6/   #���  5A      �� 5B   
   $��5��6   $��2��6!   $��Center=�5D      $
��Left=�6/   #���  5E      ��5C      �� *User.PhoneNumber+5E      �� 5G   
   $��6��6   $��1��6!   $��Członek od:��61   $��Center=�5H      $
��Left=�6/   #���  5I      �� 5J   
   $��6��6   $��2��6!   $��Center=�5L      $
��Left=�6/   #���  5M      ��5K      �� *User.CreatedOn+$ {0:yyyy-mm-dd h:m:ss}��5M      5N      5O      