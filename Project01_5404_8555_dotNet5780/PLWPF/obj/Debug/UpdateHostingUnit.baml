   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	       PLWPF.UpdateHostingUnit   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  UpdateHostingUnit��5   	   $	��729��6#   $
��1600��60    � 	Resources 5	         	BorderKey �� 
TargetType �� Property �� Value  commonStyle �� BasedOn��%  &	        &	 U     '�� H    7  '�� �    7  '�� 4    7  '�� �    7  �� 5
   
   " ��6#   .�5      ��  �@��CornerRadius$ 15��6-   5      �� 5   
   " ��6%   .�5      ��  � ��
 ���� 6-   �� 5       � ��
 ���� 6,   �� 5       � ��$ Guttman Yad-Brush)�6,   �� 5       � �� �	#FF2F17C56,   �� 5       � ��$ 16(�6*   5      �� 5   
   " ��6   8   .�5      ��  � ��$ 16(�6*   �� 5       � �� �	#FF2F17C56-   5      �� 5   
   " ��6   8   .�5      ��  � ��$
 Bold"�6,   �� 5       � ��$ 16(�6*   5      �� 5   
   " ��6   8   .�5!      ��  � ��$ 16(�6*   �� 5"       � ��
 �����6,   5#      �� 5$   
   " ��6   8   5&      5'      .��5)      � $��0,2,2,-2q�6   $	��729��6   $
��1600��6*    � ColumnDefinitions 5*   
   �� 5+      ��5-   
   �� 5.       �� ImageSource$' !Resources\HP-fallback-image-1.jpg��6    j� Stretch$ UniformToFill=�6I   	 j� TileMode$
	 Tile=�6a   .+�51   
   �� $&�� עדכון יחידת אירוח��6   $��18(�6-   $
��Bold"�6<   $
��Left=�6N   $��
106,49,0,0q�6i   $	��Top=�6}   $	��196��6�   �� 52   
   $#��:שם יחידת האירוח��6   $
��Left=�6-   $��232,117,0,0q�6H   $	��Top=�6]   $	��160��6u   
 J� RenderTransformOrigin$
 	0.54,0.47&�6�   �� 53   
   -   5        $��poolCB��53      $��   בריכה��6!   $
��Left=�66   $��285,154,0,0q�6Q   $	��Top=�6f   $��96��6~   $��18��6�   �� 54   
   -   5        $��GardenCB��54      $��    גינה��6#   $
��Left=�67   $��285,177,0,0q�6R   $	��Top=�6g   $	��103��6   $��18��6�   $
 
0.54,0.881&�6�   �� 55   
   -   5        $��	jakouziCB��55      $��   ג'קוזי��6$   $
��Left=�6:   $��285,200,0,0q�6U   $	��Top=�6j   $	��106��6�   $��18��6�   �� 56   
   -   5        $��AttractionCB��56      $��אטרקציות��6'   $
��Left=�6<   $��285,223,0,0q�6W   $	��Top=�6l   $	��105��6�   $��18��6�   $
 
0.54,0.526&�6�   �� 57   
   -   5        $��UpdateHU��57      $��עדכן��6!   $��5q�60   ���	#FF28C9BB���	#FF2F17C5$
��Left=�6t   $��
72,379,0,0q�6�   $	��Top=�6�   $	��115��6�   $��44��6�   $��16(�6�   $
��Bold"�6�   $
 
-0.016,0.5&�6
  ��58      �� 59       �� 
TargetType" ��6"   .R�5:      � .+�5;      A� ���	#FF2F17C5$��2��5<      ��5=      
� 5>   "    �� 	Transform 5?   &   V� 5@   *   .~�5A   .   ��  �� ScaleY$
 0.65Q�6=   5B   +   .��5D   &   �  � Offset$ 0Q�63    � Color$ 	#FFDDDDDD��5E   )   � 5F   &   $ 1Q�63   $ Transparent��5G   )   5I   #   5K      �� 5L      $��Center=�6+   $��Center=�5M      5N      5O      5Q      �� 5R   
   -   5        $��AreaBtn��5R      $#��     מיקום היחידה ��6    ���	#FFABCCEE$
��Left=�6U   $��
67,158,0,0q�6p   ���	#FF2F17C5$	��Top=�6�   $	��173��6�   $��33��6�   $��14(�6�   $��Normal"�6�    5S      ��%_   '��       �� 5T      " ��6   .�5U      ��  �@��CornerRadius$ 10��65   5V      5W      5X      �� 5Y   
   $��Resources\place.png��6   $
��Left=�6-   $��32��6H   $��
71,157,0,0q�6T   $	��Top=�6h   $��54��6�   � 5[   
   -   5        $	��gr3��5[      $y�	Collapsed=�6   $
��Left=�61   $	��149��6L   $��
78,191,0,0q�6Y   $	��Top=�6m   $	��148��6�   .+�5\      �� -   5        $��AreaCB��5\       �� 
IsEditable . $��16(�68   ���	#FF2F17C5$
��Bold"�6]    �� Text$ בחר יעד��6p   $
��Left=�6�   $��	51,12,0,0q�6�   $	��Top=�6�   $��84��6�   $��27��6�   �� 5]      -	   5        $��	SubAreaCB��5]       . $��16(�6i   ���	#FF2F17C5$
��Bold"�6�   $ בחר תת יעד��6�   $y�	Collapsed=�6�   $	��111��6�   $��28��6�   $��24,39,13,82q�6�   5^      �� 5_   
   $��:אתר לינה��6   $
��Left=�6$   $��33��6?   $��113,267,0,0q�6K   $	��Top=�6`   $	��113��6x   $
 
0.45,0.431&�6�   �� 5`   
   -
   5         ��Name$ TypeHostingUnitCB��5`       . $��14(�6A   ���	#FF2F17C5$
��Bold"�6f   $
��Left=�6�   $��
79,305,0,0q�6�   $	��Top=�6�   $	��120��6�   $��24��6�    �� SelectedItem 6x   �� *Type+6�   �� 5c   
   $��:ארוחות��6   $
��Left=�6$   $��381,268,0,0q�6?   $	��Top=�6T   $��84��6l   �� 5d   
   -   5        $��BreakfastCB��5d      $��
  בוקר��6&   $
��Left=�67   $��285,276,0,0q�6U   $	��Top=�6j   $��24��6�   �� 5e   
   -   5        $��LunchCB��5e      $��צהריים��6"   $
��Left=�63   $��285,305,0,0q�6O   $	��Top=�6d   $��24��6|   �� 5f   
   -   5        $��DinnerCB��5f      $��	   ערב��6#   $
��Left=�64   $��285,334,0,0q�6Q   $	��Top=�6f   $��24��6~   $��74��6�   �� 5h   
   -   5         ��Name$ RoomBtn��5h      $!��       :מספר חדרים��6"   ���	#FF8FBCEC$��271,379,1133,306q�6r   $��Normal"�6�    5i      ��%_   '��       �� 5j      " ��6   .�5k      ��  �@��CornerRadius$ 15��65   5l      5m      5n      �� 5o   
   $��Resources/blue bed.png��6   $
��Left=�61   $��50��6L   $��42��6X   $��278,377,0,302q�6c   $
 
0.125,0.74&�6z   � 5q   
   -   5        $	��gr4��5q      $y�	Collapsed=�6   $
��Left=�61   $	��100��6L   $��271,428,0,0q�6Y   $	��Top=�6n   $	��187��6�    5r      �� 5s      $
��122* �6#   �� 5t      $	��65* �6#   .+�5v      �� $��
חדרים��6   $
��Left=�6%   $��1,10,0,0q�6@   $	��Top=�6R   $��46��6j   $��64��6v   $��16(�6�   ���	#00000000���	#FFCAF7F7$
��Bold"�6�   $��1��6�   �� 5w      -   5        $ RoomPlus��5w      $��+��6'   $
��Left=�63   $	��Top=�6O   $��40��6g   $��	-2,10,0,0q�6r   $��46��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5x      -   5         ��Name$ 
txtNumRoom��5x      $��0��6*   
������ $
��Left=�6M   $��46��6h    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $��46��6�   $��	37,10,0,0q�6�   $��24(�6�   $
��Bold"�6�   �� 5y      -   5        $ 	RoomMinus��5y      $��-��6(   $
��Left=�64   $	��Top=�6P   $��40��6h   $��	72,10,0,0q�6s   $��46��6�   $
 
1.45,0.337&�6�   $��24(�6�   $
��Bold"�6�   6�   5z      �� 5|   
   -   5        $��RoomTxt��5|      $��0��6"   
������ $
��Left=�6G   $��23��6b   $��325,389,0,0q�6n   $	��Top=�6�   $��19��6�   6�   �� 5}   
   -   5        $��NLabel��5}      $�� ��6   $��10(�6)   $
��Left=�67   $��19��6R   $��
211,98,0,0q�6^   $	��Top=�6r   $	��185��6�   �� 5~   
   -   5        $��GoBack��5~   D   
������ 
������ $
��Left=�6S   $	��Top=�6n   $��60��6�   $��48��6�   .��5      �� $��Resources\blue Arrow.png��6   $��47��66   $��50��6B   5�      �� 5�   
   -   5        $��NameHu��5�       . $
��Left=�63   $��
80,121,0,0q�6N   $	��Top=�6b   $	��120��6z   6�   �� 5�   
   -   5        $	��upd��5�      $y�	Collapsed=�6   $9��3יחידת האירוח התעדכנה בהצלחה��62   $��20(�6Y   $
��Left=�6g   $��
80,487,0,0q�6�   $	��Top=�6�   $	��355��6�   �� 5�   
   -   5        $��vi��5�      $y�	Collapsed=�6   $��Resources\vi 1.png��61   $
��Left=�6M   $��70��6h   $��446,467,0,0q�6t   $	��Top=�6�   $��75��6�   $
 0.5,0.5&�6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�       �� Angle$ 22.124Q�6&   T� 5�      5�      5�      5�      5�      