   M S B A M L   `   `   `  ����E  AWpfAppDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfAppDemo
WpfAppDemo  5   	       WpfAppDemo.DBNorthWind   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfAppDemo     5   	     � Title$  DBNorthWind��5   	   $	��450��6   $	��800��6*    � 	Resources 5	      '   !WpfAppDemo.CurrencyValueConverter   currencyConverterObj/   )WpfAppDemo.ConditionalFormattingConverter  conditionalFormattingObj �� 
TargetType  conditionalFormatStyle �� Triggers �� Binding �� 	Converter �� Value �� Property �� Value��%a  &	        &	      &	 &     7  7    5
   
   6'     5   
   6/   �� 5   
   " ��6    5      �� 5       6   �� *	UnitPrice+8    True5      .a�5      ��  � ��
 �����6>   5      �� 5       6   �� *	UnitPrice+8  	 False5      .a�5      ��  � ��
 ��� �6>   5      5      5!      .��5#      � -   5        $��MainGrid��5#      
�������	 � RowDefinitions	 5$   
   �� 5%      $��1* �6   6+   �� 5&      $
��0.8* �6   6-   �� 5'      $
��0.8* �6   6-   �� 5(      $
��0.8* �6   6-   �� 5)      $��4* �6   6+   �� 5*      $
��0.8* �6   6-   
 � ColumnDefinitions
 5-   
   �� 5.      $��1* �6   6,   �� 5/      $��2* �6   6,   .+�52   
   �� $��0��6   $��0��6!   $��2��61   $��NorthWind Enterprises��6E   $��Arial Black)�6b   $��20(�6{   
����  �$��Center=�53      $��Center=�6/   55      �� 57   
   $��	ProductID��6   $��Center=�6$   $��Center=�6A   $��1��6\   $��0��6i   6{   �� 58   
   $��Product Name��6   $��Center=�6'   $��Center=�6D   $��0��6_   $��2��6o   6~   �� 59   
   $��
Unit Price��6   $��Center=�6%   $��Center=�6B   $��0��6]   $��3��6m   6|   �� 5<   
   -   5        $��Prodid��5<   ;   $��1��6   $��1��6   $��10q�6/   ��5=      �� *	ProductID+�� 5>   
   -   5        $��Prodname��5>   ;   $��2��6   $��1��6   $��10q�6/   ��5?      �� *ProductName+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . .��5@   *    =� ErrorTemplate 5A      �� 5B      .R�5C      ]� .+�5D      �� $��12(�6$   
���  ��$	��Top=�5E   Z   ��5D   C   ��  �� ElementName$ Erroradorner�� �� Path$9 3AdornedElements.(Validation.Errors)[0].ErrorContent�5E   Z   �� 5F       ��Name$ ErrorAdorner��64   5G      5H      .��5I   (   5J      �� 5N   
   -   5        $��	Unitprice��5N   ;   $��3��6   $��1��6   $��10q�6/   ��6L   �� *	UnitPrice+# [   �� ConverterParameter$ c�� �� ConverterCulture$ hi-IN���� 5S   
   -   5        $��lstItems��5S   C   $��4��6   $��0��6   $��2��6/   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5U      ��5S   S   �� ��5W      �� 5X      .R�5Y      ��  �� Orientation$ 
Horizontal=�6!   #��[ 6:   .+�5Z      �� $��50��6?   ��6$   �� *	ProductID+6?   �� 5[      $	��250��6A   ��6$   �� *ProductName+6A   �� 5\      $	��100��5]   L   ��5\   $   �� *	UnitPrice+# [  $ c��$ hi-IN��5]   L   5`      5a      5c      �� 5g   
   $ 
Horizontal=�6   $��5��6.   $��0��6;   $��2��6K   $��Center=�5h      $��Center=�60   .+�5j      �� -   5        $��btnAdd��5k   E   $��30��5j      $��50��6!   $��Center=�6,   $��Center=�6I   $
��_Add��5k      $��10q�69   6E   �� 5m      -   5        $��btnEdit��5n   1   $��30��5m      $��50��6!   $��Center=�6,   $��Center=�6I   $��_Edit��5n      $��10q�6%   61   �� 5p      -   5        $��	btnCancel��5q   K   $��30��5p      $��50��6!   $��Center=�6,   $��Center=�6I   $��_Cancel��5q      $��10q�6'   6K   �� 5s      -	   5        $��btnSave��5t   1   $��30��5s      $��50��6!   $��Center=�6,   $��Center=�6I   $��_Save��5t      $��10q�6%   6@   �� 5v      -
   5        $��	btnDelete��5w   3   $��30��5v      $��50��6!   $��Center=�6,   $��Center=�6I   $��_Delete��5w      $��10q�6'   6D   5y      5|      5      