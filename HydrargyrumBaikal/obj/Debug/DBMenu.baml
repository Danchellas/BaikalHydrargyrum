   M S B A M L   `   `   `  ����L  HHydrargyrumBaikal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HydrargyrumBaikalHydrargyrumBaikal  5   	       HydrargyrumBaikal.DBMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HydrargyrumBaikal     5   	     � Title$  DBMenu��5   	   $	��500��6   $	��740��6%    � WindowStartupLocation$ CenterScreen=�61   .��5	      � -   5         �Name$ MainGrid��5	      $��0,10,0,0q�6    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      $
��405* �6   �� 5      $	��79* �6   .+�5   
   �� -   5         ��Name$ ChangeButton��5   :      ButtonDataBase#���   6   $��Изменить��6P   $
��Left=�6c   $��
440,22,0,0q�6~   $	��Top=�6�   $��39��6�   $	��150��6�   $��Bahnschrift SemiBold)�6�   $��16(�6�   $��1��6�   �� 5   
   -   5        $ DeleteButton��5   :   #���   6   $��Удалить��6P   $
��Left=�6b   $	��Top=�6}   $��39��6�   $	��150��6�   $��Bahnschrift SemiBold)�6�   $��16(�6�   $��1��6�   $��	40,22,0,0q�6�   �� 5   
   -   5        $ 	AddButton��5   :   #���   6   $��Добавить��6M   $
��Left=�6`   $��
240,22,0,0q�6{   $	��Top=�6�   $��39��6�   $	��152��6�   $��Bahnschrift SemiBold)�6�   $��16(�6�   $��1��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridHydrargyrum��5         AutoGenerateColumns . ��6-   �� *	locations+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+6H     5      $	 	City Name��6%   $
 * 6U    68   �� *
CityName+6U     5      $	 Latitude��6%   $
 * 6T    67   �� *
Latitude+6T     5      $	 	Longitude��6%   $
 * 6V    68   �� *	Longitude+6V     5      $	 Sample��6%   $
 * 6P    65   �� *Sample+6P     5      $	 Number��6%   $
 * 6P    65   �� *Number+6P   5      �� 5   
   -   5        $ 
BackButton��5   :   #���   6   $��
Назад��6N   $
��Left=�6^   $��
623,22,0,0q�6y   $	��Top=�6�   $��39��6�   $��90��6�   $��Bahnschrift SemiBold)�6�   $��16(�6�   $��1��6�   6�   5       5!      