   M S B A M L   `   `   `  ����F  BPringlesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PringlesApp.MVVM.ViewModelPringlesApp.MVVM.ViewModel  5   	   )clr-namespace:PringlesAppPringlesApp  5   	   ?$clr-namespace:PringlesApp.ConvertersPringlesApp.Converters  5	   	       PringlesApp.MainWindow   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >	viewModel(clr-namespace:PringlesApp.MVVM.ViewModel     5   	   +localclr-namespace:PringlesApp     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5
converters$clr-namespace:PringlesApp.Converters  5	   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5
   	     � Title$  PringlesApp��5   	   $	��450��6   $	��800��6*   $	��405��66   $	��720��6F      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��12(�5   	    � Icon$ Images/PringlesLogo.ico��5   	   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension   � DataContext 5      .   (PringlesApp.MVVM.ViewModel.MainViewModel  5   
    � 	Resources 5      7  1PringlesApp.Converters.BoolToLoginStatusConverter  BoolToLoginStatusConverter��%   &	         5   
   60   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5       $��4* �6   .+�5"   
   � $��0��6   $��0��6    5#      �� 5$      $��* �6#   �� 5%      $
��2.5* �6#   .+�5'      �� $��0��6   $��Images/PringlesLogo.png��6$   �� 5(      $��1��6   $��Pringles��6(    �� TextAlignment$ Center=�68   $��Center=�6O   $
��Left=�5)      $��28(�64   
�������5*      5+      � 5,   
   $��1��6   $��0��6    5-      �� 5.      $��* �6    �� 5/      $��* �6    �� 50      $��* �6    �� 51      $��* �6    �� 52      $��* �6    �� 53      $��* �6    �� 54      $��* �6    �� 55      $��* �6    �� 56      $��* �6    �� 57      $��* �6    �� 58      $��* �6    �� 59      $��* �6    �� 5:      $��* �6    .+�5=      �� $��Strona główna��62   $
��auto��6J   ��6   �� *	RowHome+��6X   �� *ChangeToHomePageCommand+�� 5>      $��Twój ranking��64   $
��auto��6K   ��6   �� *	RowRating+��5?      �� *ChangeToRatingCommand+{�5@      �� *
IsLogged+�� 5B      $��10��62   $$��Images/Pringles-Main-Image.png��6D   $��UniformToFill=�6l   $��Center=�6�   ��6   �� *
RowImage+6�   �� 5D      $��Kontakt��65   $
��auto��6G   ��6   �� *
RowContact+��6U   �� *ChangeToContactCommand+5F      � 5G   
   $��0��6   $��1��6    5H      �� 5I      $��3* �6#   �� 5J      $��* �6#   �� 5K      $��* �6#   .+�5M      �� $��1��6   $
��auto��5N   4   ��6   �� *
LoggedUser+{�5O      �� *
IsLogged+��5P      �� *ChangeToProfileCommand+�� 5R      $��2��6   $
��auto��5S      ��5R   %   �� *
IsLogged+ �� 	Converter# [ ��5S   #   �� *ChangeToLoginCommand+5T      �� 5U   
   $��1��6   $��1��6&   ��66   �� *CurrentView+5W      5X      