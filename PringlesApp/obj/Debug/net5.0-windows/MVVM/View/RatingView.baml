   M S B A M L   `   `   `  ����F  BPringlesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PringlesApp.MVVM.ViewPringlesApp.MVVM.View  5      G(clr-namespace:PringlesApp.MVVM.ViewModelPringlesApp.MVVM.ViewModel  5      &     PringlesApp.MVVM.View.RatingView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PringlesApp.MVVM.View     5      >	viewModel(clr-namespace:PringlesApp.MVVM.ViewModel     5       *  &MaterialDesignLightSeparatorBackground#���   5
        � DataContext  5      0   *PringlesApp.MVVM.ViewModel.RatingViewModel  5   
   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   � $��0��6   $��0��6    5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6     5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5       $��* �6#   .+�5"      �� $��0��6   $��0��6%   $��Wyszukiwarka��65   $��Bottom=�6I   �� 5#      $��1��6   $��0��6#   $��Bottom=�63   ��5$      �� *SelectedFlavor+ �� UpdateSourceTrigger$ PropertyChanged=��� 5%      $��1��6   $��1��6"   $��
Dodaj smak��62   $
��auto��6G   $
��10,0q�6U   ��5&      �� *AddFlavorCommand+�� 5'      $��1��6   $��2��6"   $��Usuń ocenę��62   $
��auto��6G   $
��10,0q�6U   ��5(      �� *DeleteCommand+�� 5)      $��1��6   $��3��6"   $��Dodaj ocenę��62   $
��auto��6H   $
��10,0q�6V   ��5*      �� *
AddCommand+5+      � 5,   
   $��1��6   .+�5-      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5-         AutoGenerateColumns$ false��6)      
IsReadOnly$
 True��6E    �� SelectedItem 5.      �� *Rating+��5/      �� *SelectedRatings+   Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Pringles��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *Pringles.Flavor+  52      $	 Ocena��6)   
 68   �� *Score+  53      $	 Doznanie smakowe��6)   
 6C   �� *Description+  54      $	 
Data oceny��6)   
 6=   �� *	CreatedOn+ �� StringFormat$ {0:yyyy-mm-dd h:m:ss}��56      57      � 58   
   $��0��6   $	��500��6   $	��100��6)   $��Center=�66    3 /MaterialDesignMultiFloatingActionAccentPopupBox#���  59      ��5:      �� *IsOpenAddRating+.��5;      � 
����� � 5<      �� 5=      $
��0.5* �6$   �� 5>      $��* �6$   �� 5?      $
��0.1* �6$   �� 5@      $��* �6$   �� 5A      $
��0.5* �6$    5C      �� 5D      $��* �6'   �� 5E      $
��0.1* �6'   �� 5F      $
��0.5* �6'   �� 5G      $
��0.1* �6'   �� 5H      $��* �6'   �� 5I      $
��0.1* �6'   �� 5J      $��* �6'   .+�5N      �� $��1��6   $��0��6)   $
��Smak��6:      MaterialDesignBody1TextBlock#���  5O      �� 5P      $��3��6   $��0��6(    �� SelectedIndex 5Q      �� *UserRating.Flavor+��5R      �� *AvailablePringles+��5S      �� 5T      .R�5U      ��  �� Orientation$ 
Horizontal=�6*   .+�5V   "   �� ��6,   �� *Flavor+�� 5W   "   $	�� - ��6,   �� 5X   "   ��6,   �� *Description+5Y      5Z      5]      �� 5^      $��1��6   $��2��6)   $��Ocena��69   #���  5_      �� 5`      $��3��6   $��2��6(   $��Bottom=�68    5a      �� *UserRating.Score+��5b      �� *Scores+�� 5d      $��1��6   $��4��6)   $��Doznanie smakowe��69   #���  5e      �� 5f      $��3��6   $��4��6'   $��Bottom=�67    �� 	MaxLength$	 250��6R   ��5g      �� *UserRating.Description+�� 5i      $��1��6   $��6��6&   $��Anuluj��66   ��5j      �� *CancelCommand+�� 5k      $��3��6   $��6��6&   $��
Zatwierdź��66   ��5l      �� *ConfirmCommand+5o      5p      � 5q   
   $��0��6   $	��500��6   $	��100��6)   $��Center=�66   #���  5r      ��5s      �� *IsOpenAddFlavor+.��5t      � 
����� � 5u      �� 5v      $
��0.5* �6$   �� 5w      $��* �6$   �� 5x      $
��0.1* �6$   �� 5y      $��* �6$   �� 5z      $
��0.5* �6$    5|      �� 5}      $��* �6'   �� 5~      $
��0.1* �6'   �� 5      $��* �6'   �� 5�      $
��0.1* �6'   �� 5�      $��* �6'   .+�5�      �� $��1��6   $��0��6)   $��	Nowy Smak��6:   #���  5�      �� 5�      $��3��6   $��0��6'   $��Bottom=�67   $	 100��6R   ��5�      �� *NewPringles.Flavor+�� 5�      $��1��6   $��2��6)   $
��Opis��69   #���  5�      �� 5�      $��3��6   $��2��6'   $��Bottom=�67   $	 250��6R   ��5�      �� *NewPringles.Description+�� 5�      $��1��6   $��4��6&   $��Anuluj��66   ��5�      �� *CancelFlavorCommand+�� 5�      $��3��6   $��4��6&   $��
Zatwierdź��66   ��5�      �� *ConfirmFlavorCommand+5�      5�      5�      5�      