   M S B A M L   `   `   `  ���� L  HHydrargyrumBaikal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HydrargyrumBaikalHydrargyrumBaikal  d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF "    HydrargyrumBaikal.IrkutskMap   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:HydrargyrumBaikal     `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF       � Title$  
IrkutskMap��$	��650��$
��1280��.��� $��	0,10,0,13q�$��Center=�$
��1260�� � ColumnDefinitions �� $	��41* ��� $	��19* �.+��� -    ��Name$ Point1��$��Точка 1��$
��Left=�$��	61,96,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��25��$��87���� -   $ Point2��$��Точка 2��$
��Left=�$��
61,126,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point3��$��Точка 3��$
��Left=�$��
61,157,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point4��$��Точка 4��$
��Left=�$��
61,188,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point5��$��Точка 5��$
��Left=�$��
61,219,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point6��$��Точка 6��$
��Left=�$��
61,250,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point7��$��Точка 7��$
��Left=�$��
61,281,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point8��$��Точка 8��$
��Left=�$��
61,312,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -	   $ Point9��$��Точка 9��$
��Left=�$��
61,343,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -
   $ Point10��$��Точка 10��$
��Left=�$��
61,374,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point11��$��Точка 11��$
��Left=�$��
240,96,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��25��$��87���� -   $ Point12��$��Точка 12��$
��Left=�$��240,126,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point13��$��Точка 13��$
��Left=�$��240,157,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point14��$��Точка 14��$
��Left=�$��240,188,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point15��$��Точка 15��$
��Left=�$��240,219,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point16��$��Точка 16��$
��Left=�$��240,250,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point17��$��Точка 17��$
��Left=�$��240,281,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point18��$��Точка 18��$
��Left=�$��240,312,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point19��$��Точка 19��$
��Left=�$��240,343,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$��87���� -   $ Point20��$��Точка 20��$
��Left=�$��240,374,0,0q�$	��Top=�$��18(�$��Bahnschrift SemiBold)�$��Normal"�$��1��$��26��$	��106���� -    ��Name$ ExportButton��$��1��$��Сохранить��$
��Left=�$��
21,542,0,0q�$	��Top=�$��39��$	��166��$��16(�$��Bahnschrift SemiBold)��� -   $ BDButton��$��1��$-��'Перейти к базе данных��$
��Left=�$��203,542,0,0q�$	��Top=�$��39��$	��180��$��16(�$��Bahnschrift SemiBold)��� -   $ VizualisationButton��$��1��$$��Визуализировать��$��Center=�$��	0,441,0,0q�$	��Top=�$��39��$	��358��$��16(�$��Bahnschrift SemiBold)��� -    ��Name$ label3��$��1��$L��FВыберите точки для визуализации полей��$
��Left=�$��	25,37,0,0q�$	��Top=�$��Bahnschrift SemiBold)�$��18(�$��33��$	��390��'  !Microsoft.Maps.MapControl.WPF.Map  -     Name$ HydragyrumMap��+  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AiW95rnA8msG-ACjKnH_wr3oVKUiz4MtUGC1GY4wqg6Vqp10WfOzBA8SERgNqKa1    Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 52.2864, 104.3050    	ZoomLevel$ 10Q�	   Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$	 AerialWithLabels 