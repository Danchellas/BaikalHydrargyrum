   M S B A M L   `   `   `  ����L  HHydrargyrumBaikal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HydrargyrumBaikalHydrargyrumBaikal  5   	   d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 67   "    HydrargyrumBaikal.AngarskMap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HydrargyrumBaikal     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     67     � Title$  
AngarskMap��5   	   $	��815��6   $
��1280��6)    � WindowStartupLocation$ CenterScreen=�66   .��5	      � $��	0,10,0,13q�6   $��Center=�6   $
��1260��6;    � ColumnDefinitions 5
   
   �� 5      $	��41* �6   �� 5      $	��19* �6   .+�5   
   �� 
���**�� J� RenderTransformOrigin$ 6.215,0.621&�6!   $��1��6E   $��116,374,248,359q�6U   �� 5   
   
���  ��$ 6.215,0.621&�6   $��1��6C   $��116,350,248,381q�6S   �� 5   
   
��� ���$ 6.215,0.621&�6"   $��1��6F   $��116,327,248,405q�6V   �� 5   
   
��� ���$ 6.215,0.621&�6"   $��1��6F   $��116,304,248,428q�6V   �� 5   
   
��� � �$ 6.215,0.621&�6    $��1��6D   $��116,283,248,450q�6T   �� 5   
   
���2�2�$ 
4.71,0.918&�6%   $��1��6H   $��116,261,248,472q�6X   �� 5   
   
�����@�$ 6.215,0.621&�6%   $��1��6I   $��116,240,248,494q�6Y   �� 5   
   
����� �$ 6.215,0.621&�6$   $��1��6H   $��116,216,248,516q�6X   �� 5   
   
����=H�$ 6.215,0.621&�6)   $��1��6M   $��116,193,248,539q�6]   �� 5   
   -   5         ��Name$ ExportButton��5   :      ButtonDataBase#���   6   $��1��6P   $#��Сохранить карту��6`   $
��Left=�6z   $��
25,703,0,0q�6�   $	��Top=�6�   $��39��6�   $	��166��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6	  �� 5   
   -   5        $ BDButton��5   :   #���   6   $��1��6L   $-��'Перейти к базе данных��6\   $
��Left=�6|   $��116,640,0,0q�6�   $	��Top=�6�   $��39��6�   $	��180��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6  �� 5   
   -   5        $ VizualisationButton��5   :   #���   6   $��1��6W   $$��Визуализировать��6g   $��Center=�6�   $��	0,448,0,0q�6�   $	��Top=�6�   $��38��6�   $	��358��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6  '  !Microsoft.Maps.MapControl.WPF.Map  5   
   -   5          Name$ AHydragyrumMap��5      +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AiW95rnA8msG-ACjKnH_wr3oVKUiz4MtUGC1GY4wqg6Vqp10WfOzBA8SERgNqKa1 6(      Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 52.5366700, 103.8863900 6      	ZoomLevel$ 11Q�6�   	   Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$	 AerialWithLabels 6�   $��0,0,0,10q�6�   5      �� 5   
   $��1��6   $��> 35.3 нг/м3��6    $��Bahnschrift SemiBold)�6:   $��13(�6\   $
��Left=�6k   $��159,373,0,0q�6�   $	��Top=�6�   �� 5   
   $��1��6   $#��35.2 нг/м3 - 32.3 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,350,0,0q�6�   $	��Top=�6�   �� 5   
   $��1��6   $#��32.2 нг/м3 - 29.3 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,327,0,0q�6�   $	��Top=�6�   �� 5   
   $��1��6   $#��29.2 нг/м3 - 26.3 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,304,0,0q�6�   $	��Top=�6�   �� 5    
   $��1��6   $#��26.2 нг/м3 - 23.3 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,283,0,0q�6�   $	��Top=�6�   �� 5!   
   $��1��6   $#��23.2 нг/м3 - 20.3 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,261,0,0q�6�   $	��Top=�6�   �� 5"   
   $��1��6   $#��17.2 нг/м3 - 14.3 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,238,0,0q�6�   $	��Top=�6�   �� 5#   
   $��1��6   $$��14.2 нг/м3 - 11.3 нг/м3 ��6    $��Bahnschrift SemiBold)�6C   $��13(�6e   $
��Left=�6t   $��159,215,0,0q�6�   $	��Top=�6�   �� 5$   
   $��1��6   $��< 11.2 нг/м3��6    $��Bahnschrift SemiBold)�6:   $��13(�6\   $��Center=�6k   $��	0,193,0,0q�6�   $	��Top=�6�   �� 5%   
   -   5        $ ExportFileButton��5%   :   #���   6   $��1��6T   $%��Сохранить данные��6d   $
��Left=�6   $��217,703,0,0q�6�   $	��Top=�6�   $��39��6�   $	��166��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6  �� 5&   
   -   5        $ 
backButton��5&   :   #���   6   $��1��6N   $��
Назад��6^   $
��Left=�6n   $��
242,10,0,0q�6�   $	��Top=�6�   $��39��6�   $	��142��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6�   �� 5'   
   -   5        
 ��Name$
 Label2��5'      $7��1Работа с расчетным модулем��6    $��Center=�6E   $	��Top=�6b   $��20(�6z   $��Bahnschrift SemiBold)�6�   $��	0,104,0,0q�6�   $��1��6�   �� 5(   
   -   5        $
 Label3��5(      $$��Работа с данными��6    $��Center=�6;   $	��Top=�6X   $��20(�6p   $��Bahnschrift SemiBold)�6~   $��	0,566,0,0q�6�   $��1��6�   �� 5)   
   -	   5        $ summVizualisationButton��5)   :   #���   6   $��1��6[   $O��IРасчет суммарного годового загрязнения��6k   $
��Left=�6�   $��
18,508,0,0q�6�   $	��Top=�6�   $��38��6�   $	��358��6�   $��16(�6�   $��Bahnschrift SemiBold)�6	  6+  5,      5-      