   M S B A M L   `   `   `  ����L  HHydrargyrumBaikal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HydrargyrumBaikalHydrargyrumBaikal  5   	   d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 67   "    HydrargyrumBaikal.IrkutskMap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HydrargyrumBaikal     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     67     � Title$  
IrkutskMap��5   	   $	��800��6   $
��1280��6)    � WindowStartupLocation$ CenterScreen=�66   .��5	      � $��	0,10,0,13q�6   $��Center=�6   $
��1260��6;    � ColumnDefinitions 5
   
   �� 5      $	��41* �6   �� 5      $	��19* �6   .+�5   
   �� -   5         ��Name$ ExportButton��5   :      ButtonDataBase#���   6   $��1��6P   $#��Сохранить карту��6`   $
��Left=�6z   $��
26,698,0,0q�6�   $	��Top=�6�   $��39��6�   $	��166��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6	  �� 5   
   -   5        $ BDButton��5   :   #���   6   $��1��6L   $-��'Перейти к базе данных��6\   $
��Left=�6|   $��115,638,0,0q�6�   $	��Top=�6�   $��39��6�   $	��180��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�    J� RenderTransformOrigin$ 0.456,0.181&�6#  �� 5   
   -   5        $ VizualisationButton��5   :   #���   6   $��1��6W   $$��Визуализировать��6g   $
��Left=�6�   $��
26,435,0,0q�6�   $	��Top=�6�   $��40��6�   $	��358��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6  '  !Microsoft.Maps.MapControl.WPF.Map  5   
   -   5          Name$ HydragyrumMap��5      +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AiW95rnA8msG-ACjKnH_wr3oVKUiz4MtUGC1GY4wqg6Vqp10WfOzBA8SERgNqKa1 6'      Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 52.2864, 104.3050 6~      	ZoomLevel$ 10Q�6�   	   Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$	 AerialWithLabels 6�   $��0,0,0,10q�6�   5      �� 5   
   
���**��$ 6.215,0.621&�6!   $��1��6E   $��116,363,248,355q�6U   �� 5   
   
���  ��$ 6.215,0.621&�6   $��1��6C   $��116,339,248,377q�6S   �� 5   
   
��� ���$ 6.215,0.621&�6"   $��1��6F   $��116,315,248,401q�6V   �� 5   
   
��� ���$ 6.215,0.621&�6"   $��1��6F   $��116,293,248,424q�6V   �� 5   
   
��� � �$ 6.215,0.621&�6    $��1��6D   $��116,271,248,446q�6T   �� 5   
   
���2�2�$ 
4.71,0.918&�6%   $��1��6H   $��116,249,248,468q�6X   �� 5   
   
�����@�$ 6.215,0.621&�6%   $��1��6I   $��116,229,248,490q�6Y   �� 5   
   
����� �$ 6.215,0.621&�6$   $��1��6H   $��116,205,248,512q�6X   �� 5   
   
����=H�$ 6.215,0.621&�6)   $��1��6M   $��116,181,248,535q�6]   �� 5   
   $��1��6   $��> 34.1 нг/м3��6    $��Bahnschrift SemiBold)�6:   $��13(�6\   $
��Left=�6k   $��159,363,0,0q�6�   $	��Top=�6�   �� 5   
   $��1��6   $!��34 нг/м3 - 31.4 нг/м3��6    $��Bahnschrift SemiBold)�6@   $��13(�6b   $
��Left=�6q   $��159,339,0,0q�6�   $	��Top=�6�   �� 5   
   $��1��6   $#��31.3 нг/м3 - 28.7 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,315,0,0q�6�   $	��Top=�6�   �� 5    
   $��1��6   $!��28.6 нг/м3 - 26 нг/м3��6    $��Bahnschrift SemiBold)�6@   $��13(�6b   $
��Left=�6q   $��159,293,0,0q�6�   $	��Top=�6�   �� 5!   
   $��1��6   $#��25.9 нг/м3 - 23.3 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,271,0,0q�6�   $	��Top=�6�   �� 5"   
   $��1��6   $#��23.2 нг/м3 - 20.6 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,249,0,0q�6�   $	��Top=�6�   �� 5#   
   $��1��6   $#��20.5 нг/м3 - 17.9 нг/м3��6    $��Bahnschrift SemiBold)�6B   $��13(�6d   $
��Left=�6s   $��159,227,0,0q�6�   $	��Top=�6�   �� 5$   
   $��1��6   $$��17.8 нг/м3 - 15.2 нг/м3 ��6    $��Bahnschrift SemiBold)�6C   $��13(�6e   $
��Left=�6t   $��159,203,0,0q�6�   $	��Top=�6�   �� 5%   
   $��1��6   $��< 15.1 нг/м3��6    $��Bahnschrift SemiBold)�6:   $��13(�6\   $��Center=�6k   $��	0,181,0,0q�6�   $	��Top=�6�   �� 5&   
   -   5        $ ExportFileButton��5&   :   #���   6   $��1��6T   $%��Сохранить данные��6d   $
��Left=�6   $��217,698,0,0q�6�   $	��Top=�6�   $��39��6�   $	��166��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6  �� 5'   
   -   5        $ 
backButton��5'   :   #���   6   $��1��6N   $��
Назад��6^   $
��Left=�6n   $��
242,10,0,0q�6�   $	��Top=�6�   $��39��6�   $	��142��6�   $��16(�6�   $��Bahnschrift SemiBold)�6�   6�   �� 5(   
   -   5        
 ��Name$
 Label2��5(      $7��1Работа с расчетным модулем��6    $��Center=�6E   $	��Top=�6b   $��20(�6z   $��Bahnschrift SemiBold)�6�   $��	0,100,0,0q�6�   $��1��6�   �� 5)   
   -   5        $
 Label3��5)      $$��Работа с данными��6    $��Center=�6;   $	��Top=�6X   $��20(�6p   $��Bahnschrift SemiBold)�6~   $��	0,556,0,0q�6�   $��1��6�   �� 5*   
   -	   5        $" SummVizualisationButton_Copy��5*   :   #���   6   $��1��6`   $O��IРасчет годового суммарного загрязнения��6p   $
��Left=�6�   $��
25,497,0,0q�6�   $	��Top=�6�   $��40��6�   $	��358��6�   $��16(�6   $��Bahnschrift SemiBold)�6  60  5+      5,      