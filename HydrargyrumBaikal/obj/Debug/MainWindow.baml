   M S B A M L   `   `   `  ����L  HHydrargyrumBaikal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HydrargyrumBaikalHydrargyrumBaikal  5   	   "    HydrargyrumBaikal.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HydrargyrumBaikal     5   	     � Title$  
MainWindow��5   	   $	��400��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�66   .��5	      � $��
10,0,-10,0q�6    � RowDefinitions 5
   
   �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ IrkustkButton��5   2    
  Button#���   6   $��Иркутск��6I   $
��Left=�6[   $��
99,298,0,0q�6v   $	��Top=�6�   $	��200��6�   $��45��6�   $��20(�6�   $��Bahnschrift SemiBold)�6�   6�   �� 5   
   -   5        $ AngarskButton��5   2   #���   6   $��Ангарск��6I   $��Center=�6[   $��	0,298,0,0q�6x   $	��Top=�6�   $	��200��6�   $��45��6�   $��20(�6�   $��Bahnschrift SemiBold)�6�   6�   �� 5   
   -   5        $ ShelehoxButton��5   2   #���   6   $��Шелехов��6J   $
��Left=�6\   $��699,298,0,0q�6w   $	��Top=�6�   $	��200��6�   $��46��6�   $��20(�6�   $��Bahnschrift SemiBold)�6�   6�   �� 5   
   -   5         ��Name$ Label1��5      $����Расчет и визуализация полей ртутного загрязнения по данным биомониторинга городов��6    $
��Left=�6|   $��	39,55,0,0q�6�   $	��Top=�6�   $��22(�6�   $��Bahnschrift SemiBold)�6�   $��Normal"�6�   $��40��6  $	��918��6   J� RenderTransformOrigin$ 0.501,0.746&�6  �� 5   
   -   5        $ Label2��5      $f��`Выберите город для дальнейшего предосмотра и работы��6    $��Center=�6^   $��Center=�6{   $��20(�6�   $��Bahnschrift SemiBold)�6�   5      5      