   M S B A M L   `   `   `  ����D  @AnimeBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AnimeBase	AnimeBase  5   	        AnimeBase.AddProductWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:AnimeBase     5   	   8
syncfusion!http://schemas.syncfusion.com/wpf     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5	   	   -   5        
������   � AllowsTransparency$
  True��5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AddClientWindow��5   	   $	��450��6!   $	��450��6.    � 	Resources 5         	bollToVis��%   &	        �� 5   
   6'   5      .��5      ��  �� CornerRadius$ 20��6   ��5   
   �� 5       �� ImageSource$ /AddProductArt.jpg��6   ._�5   
   � .+�5      ��  J� Opacity$	 0.9Q�6   $ 20��6#   ��5      �� 5      	 �� 
StartPoint$		 0,0&�6*   
 �� EndPoint$	
 1,1&�6;   .��5      �  � Color$ #002171��6'    � Offset$ 0Q�67   � 5      $ #1976d2��6'   $
 0.75Q�67   � 5      $ #0097a7��6'   $ 1Q�67   5      5!      � 5"       � RowDefinitions 5#      �� 5$      $
��Auto �6$   �� 5%      $��* �6$   .+�5(      �� -   5         ��Name$ closeWinBtn��5(      $��0q�5)      $��X��5*      
�������$��12(�5,      $��Right=�5-      $��15q�5.      $��
Montserrat)�5/       � Cursor$
 Hand��50      ��52      �� 53       �� 
TargetType" ��6    .�54      ��  �� Property � �� �� Value �#ec407a6;    �� Triggers 55      P� 56   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �57   &   ��  � �� �#b0003a6C   58   #   5:      ��5=      �� 5>       �� 
TargetType" ��6*   .R�5?      �� $��18��6%   $��18��60   $ 9��5@   )   #��z��5A   )   ._�5B   "   �� $��Center=�63   $��Center=�5C   7   5D      5E      5G      ]� 5I      $��1��6   .+�5J      �� $	��Top=�6!   $��Center=�66   $'��!Добавление товара��6S   ���#ffffff$��16(�5K   !   $��SemiBold"�6/   $��0 0 0 10q�6E   � 5L      $	��200��6   $��10q�6'   $��Center=�63   $	��Top=�6P   .+�5M      �� $
��15 0q�6$   $��Center=�62   ���#b0b9c6 J� IsHitTestVisible$ False��5N   $   $'��!Название продукта��6=    K� ZIndex$ 1��6V   y�5O   $   ��  �� ElementName$ nameTextBlock�� �� Path$ Text.IsEmpty� �� 	Converter# [  �� 5Q      $ 7��6!   ���#ffffff���	#FFABADB3$��1q�5R   !   $��Center=�65    � UseLayoutRounding$
 True��6P   ._�5S      �� -   5         ��Name$ nameTextBlock��5S   &   $��0 0 20 0q�6=     	filterBox#��[ 6O   5T      5U      � 5V      $	��200��6   $��10q�6'   $��Center=�63   $	��Top=�6P   .+�5W      �� $
��15 0q�6$   $��Center=�62   ���#b0b9c6$ False��5X   $   $��Цена��6=   $ 1��6I   y�5Y   $   �� $ priceTextBlock��$ Text.IsEmpty�# [  �� 5[      $ 7��6!   ���#ffffff���	#FFABADB3$��1q�5\   !   $��Center=�65   $
 True��6P   ._�5]      �� -   5        $ priceTextBlock��5]   &   $��0 0 20 0q�6>   #��[ 6P   5^      5_      � 5`      $	��200��6   $��10q�6'   $��Center=�63   $	��Top=�6P   .+�5a      �� $
��15 0q�6$   $��Center=�62   ���#b0b9c6$ False��5b   $   $��Количество��6=   $ 1��6O   y�5c   $   �� $ quntityTextBlock��$ Text.IsEmpty�# [  �� 5e      $ 7��6!   ���#ffffff���	#FFABADB3$��1q�5f   !   $��Center=�65   $
 True��6P   ._�5g      �� -   5        $ quntityTextBlock��5g   &   $��0 0 20 0q�6@   #��[ 6R   5h      5i      � 5j      $	��200��6   $��10q�6'   $��Center=�63   $	��Top=�6P   .+�5k      �� $��15 10q�6$   $	��Top=�63   ���#b0b9c6$ False��5l   $   $��Описание��6=   $ 1��6M   y�5m   $   �� $ descriptionTextBlock��$ Text.IsEmpty�# [  �� 5o      $ 7��6!   ���#ffffff���	#FFABADB3$��1q�5p   !   $��Center=�65   $
 True��6P   ._�5q      �� -   5        $ descriptionTextBlock��5q   &    �� TextWrapping$
 Wrap=�6D    �� AcceptsReturn$
 True��6X   $��0 0 20 0q�6m   #��[ 6   5r      5s      �� 5u      -   5          	addButton#��[ 5u      $��0q�6@   $��Center=�6K   $��Bottom=�6�   .��5v      �� $!��Добавить товар��6$   5w      5x      5y      5z      5{      5|      