   M S B A M L   `   `   `  ����^  ZNorthWind_Add_Delete_Cancell_Button, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:NorthWind_Add_Delete_Cancell_Button#NorthWind_Add_Delete_Cancell_Button  5   	   4    .NorthWind_Add_Delete_Cancell_Button.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:NorthWind_Add_Delete_Cancell_Button     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      ;   5NorthWind_Add_Delete_Cancell_Button.CurrencyConverter   currencyConverterObjH   BNorthWind_Add_Delete_Cancell_Button.ConditionalFormattingConverter  conditionalFormattingObj �� 
TargetType  conditionalFormatStyle �� Triggers �� Binding �� 	Converter �� Value �� Property �� Value��%a  &	        &	      &	 &     7  7    5
   
   6"     5   
   6/   �� 5   
   " ��6    5      �� 5       6   �� *	UnitPrice+8    True5      .a�5      ��  � ��
 �����6>   5      �� 5       6   �� *	UnitPrice+8  	 False5      .a�5      ��  � ��
 ��� �6>   5      5      5      .��5       �� 
���   �$��1,1,1,1q�6!   	 �� CornerRadius$	 60,60,60,60��6;   
���  ��._�5#   
   � -   5        
 �Name$
 	Main_Grid��5#       � ColumnDefinitions 5$      �� 5%      $��1* �6#   �� 5&      $��2* �6#    � RowDefinitions 5(      �� 5)      $��1* �6    �� 5*      $
��0.8* �6    �� 5+      $
��0.8* �6    �� 5,      $
��0.8* �6    �� 5-      $��4* �6    �� 5.      $��1* �6    �� 5/      $��1* �6    .+�52      �� $��0��6   $��0��6%   $��2��65   $��North Wind Enterprises��53      $��Center=�62   $��Center=�54      $��32(�6/   $��Medium"�6=   
����  �55      �� 58      $��1��6   $��0��6!   $��
Product ID��61   $��Center=�59      $��Center=�6+   $��16(�5:      $��Calbiri)�6   �� 5;      $��2��6   $��0��6!   $��Product Name��61   $��Center=�5<      $��Center=�6+   $��16(�5=      $��Calbiri)�6   �� 5>      $��3��6   $��0��6!   $��
Unit Price��61   $��Center=�5?      $��Center=�6+   $��16(�5@      $��Calbiri)�6   �� 5C      -   5        $��txtBox_productId��5E      $��1��5C      $��1��6#   $��5q�63   $��3q�6>   $	��300��5D      $��25��6   $
��Left=�5E   *   ��5F      �� *	ProductID+�� 5G      -   5        $��txtBox_productName��5I      $��2��5G      $��1��6#   $��5q�63   $��3q�6>   $	��300��5H      $��25��6   $
��Left=�5I   ,   ��5J      �� *ProductName+�� 5K      -   5        $��txtBox_UnitPrice��5M      $��3��5K      $��1��6#   $��5q�63   $��3q�6>   $	��300��5L      $��25��6   $
��Left=�5M   *   ��5N      �� *	UnitPrice+# [   �� ConverterParameter$ c�� �� ConverterCulture$ hi-IN���� 5R      -   5        $��lstItem��5R   G   $��4��6   $��0��6#   $��2��63   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5T      ��5S      �� ��5U      �� 5V      .R�5W      ��  �� Orientation$ 
Horizontal=�6%   #��[ 6>   .+�5X      �� $��5q�6C    �� Padding$ 3q�6N   $	��160��5Y       ��5X   (   �� *	ProductID+5Y       �� 5Z      $��5q�6E   $ 3q�6P   $	��300��5[       ��5Z   (   �� *ProductName+5[       �� 5\      $��5q�5]   P   $ 3q�6[   $��60��5^       ��5\   (   �� *	UnitPrice+# [  $ c��$ hi-IN��5^       5_      5`      5d      �� 5f      $ 
Horizontal=�6   $��5��62   $��0��6?   $��2��6O   $��Center=�5g      $��Center=�60   .+�5i      �� -   5        $��btnAdd��5j   E   $��30��5i      $��50��6%   $��Center=�60   $��Center=�6M   $
��_Add��5j      $��10q�69   6E   �� 5l      -   5        $��	btnCancel��5m   K   $��30��5l      $��50��6%   $��Center=�60   $��Center=�6M   $��_Cancel��5m      $��10q�6'   6K   �� 5o      -   5        $��btnSave��5p   3   $��30��5o      $��50��6%   $��Center=�60   $��Center=�6M   $��_Submit��5p      $��10q�6'   6B   �� 5r      -	   5        $��	btnDelete��5s   3   $��30��5r      $��50��6%   $��Center=�60   $��Center=�6M   $��_Delete��5s      $��10q�6'   6D   5u      5x      5y      5z      