   M S B A M L   `   `   `  ����L  HHydrargyrumBaikal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HydrargyrumBaikalHydrargyrumBaikal  5   	   d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 67   #    HydrargyrumBaikal.ShelehovMap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HydrargyrumBaikal     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     67     � Title$  
AngarskMap��5   	   $	��815��6   $
��1280��6)    � WindowStartupLocation$ CenterScreen=�66   .��5	      � $��	0,10,0,13q�6   $��Center=�6   $
��1260��6;    � ColumnDefinitions 5
   
   �� 5      $	��41* �6   �� 5      $	��19* �6   .+�5   
   �� -   5         ��Name$ ExportButton��5   :      ButtonDataBase#���   6   $��1��6P   $#��Сохранить карту��6`   $
��Left=�6z   $��
25,703,0,0q�6�   $	��Top=�6�   $��39��6�   $	��166��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6	  �� 5   
   -   5        $ BDButton��5   :   #���   6   $��1��6L   $-��'Перейти к базе данных��6\   $
��Left=�6|   $��117,645,0,0q�6�   $	��Top=�6�   $��39��6�   $	��178��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6  �� 5   
   -   5        $ VizualisationButton��5   :   #���   6   $��1��6W   $$��Визуализировать��6g   $��Center=�6�   $��	0,437,0,0q�6�   $	��Top=�6�   $��40��6�   $	��358��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6  '  !Microsoft.Maps.MapControl.WPF.Map  5   
   -   5          Name$ ShHydragyrumMap��5      +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AiW95rnA8msG-ACjKnH_wr3oVKUiz4MtUGC1GY4wqg6Vqp10WfOzBA8SERgNqKa1 6)      Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 52.2138900, 104.1000000 6�      	ZoomLevel$ 12Q�6�      Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$ AerialWithLabels 6�   $��0,0,0,10q�6�   5      �� 5   
   
���**��	 J� RenderTransformOrigin$	 6.215,0.621&�6!   $��1��6E   $��113,363,251,370q�6U   �� 5   
   
���  ��$	 6.215,0.621&�6   $��1��6C   $��113,339,251,392q�6S   �� 5   
   
��� ���$	 6.215,0.621&�6"   $��1��6F   $��113,315,251,416q�6V   �� 5   
   
��� ���$	 6.215,0.621&�6"   $��1��6F   $��113,292,251,439q�6V   �� 5   
   
��� � �$	 6.215,0.621&�6    $��1��6D   $��113,271,251,461q�6T   �� 5   
   
���2�2�$	 
4.71,0.918&�6%   $��1��6H   $��113,249,251,483q�6X   �� 5   
   
�����@�$	 6.215,0.621&�6%   $��1��6I   $��113,228,251,505q�6Y   �� 5   
   
����� �$	 6.215,0.621&�6$   $��1��6H   $��113,204,251,527q�6X   �� 5   
   
����=H�$	 6.215,0.621&�6)   $��1��6M   $��113,181,251,550q�6]   �� 5   
   $��1��6   $��> 236.8 нг/м3��6    $��Bahnschrift SemiBold)�6;   $��13(�6]   $
��Left=�6l   $��156,363,0,0q�6�   $	��Top=�6�   �� 5   
   $��1��6   $%��236.8 нг/м3 - 209.5 нг/м3��6    $��Bahnschrift SemiBold)�6D   $��13(�6f   $
��Left=�6u   $��156,339,0,0q�6�   $	��Top=�6�   �� 5   
   $��1��6   $%��209.4 нг/м3 - 182.2 нг/м3��6    $��Bahnschrift SemiBold)�6D   $��13(�6f   $
��Left=�6u   $��156,315,0,0q�6�   $	��Top=�6�   �� 5   
   $��1��6   $%��182.1 нг/м3 - 154.9 нг/м3��6    $��Bahnschrift SemiBold)�6D   $��13(�6f   $
��Left=�6u   $��156,292,0,0q�6�   $	��Top=�6�   �� 5    
   $��1��6   $%��154.8 нг/м3 - 127.6 нг/м3��6    $��Bahnschrift SemiBold)�6D   $��13(�6f   $
��Left=�6u   $��156,271,0,0q�6�   $	��Top=�6�   �� 5!   
   $��1��6   $%��127.5 нг/м3 - 100.3 нг/м3��6    $��Bahnschrift SemiBold)�6D   $��13(�6f   $
��Left=�6u   $��156,249,0,0q�6�   $	��Top=�6�   �� 5"   
   $��1��6   $"��100.2 нг/м3 - 73 нг/м3��6    $��Bahnschrift SemiBold)�6A   $��13(�6c   $
��Left=�6r   $��156,226,0,0q�6�   $	��Top=�6�   �� 5#   
   $��1��6   $$��72.9 нг/м3 - 45.7 нг/м3 ��6    $��Bahnschrift SemiBold)�6C   $��13(�6e   $
��Left=�6t   $��156,203,0,0q�6�   $	��Top=�6�   �� 5$   
   $��1��6   $��< 45.6 нг/м3��6    $��Bahnschrift SemiBold)�6:   $��13(�6\   $��Center=�6k   $��	0,181,0,0q�6�   $	��Top=�6�   �� 5%   
   -   5        $ ExportFileButton��5%   :   #���   6   $��1��6T   $%��Сохранить данные��6d   $
��Left=�6   $��217,703,0,0q�6�   $	��Top=�6�   $��39��6�   $	��166��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6  �� 5&   
   -   5        
 ��Name$
 Label3��5&      $$��Работа с данными��6    $��Center=�6;   $	��Top=�6X   $��20(�6p   $��Bahnschrift SemiBold)�6~   $��	0,566,0,0q�6�   $��1��6�   �� 5'   
   -   5        $ 
backButton��5'   :   #���   6   $��1��6N   $��
Назад��6^   $
��Left=�6n   $��
242,10,0,0q�6�   $	��Top=�6�   $��39��6�   $	��142��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6�   �� 5(   
   -   5        $
 Label2��5(      $7��1Работа с расчетным модулем��6    $��Center=�6E   $	��Top=�6b   $��20(�6z   $��Bahnschrift SemiBold)�6�   $��	0,100,0,0q�6�   $��1��6�   �� 5)   
   -	   5        $ SummVizualisationButton��5)   :   #���   6   $��1��6[   $O��IРасчет годового суммарного загрязнения��6k   $��Center=�6�   $��	0,502,0,0q�6�   $	��Top=�6�   $��40��6�   $	��358��6�   $��16(�6�   $��Bahnschrift SemiBold)�6
  6,  5*      5+      