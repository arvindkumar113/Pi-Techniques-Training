   M S B A M L   `   `   `  ����I  ECalculatorDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CalculatorDemoCalculatorDemo  5   	       CalculatorDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CalculatorDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5         
calcButton �� 
TargetType �� Property �� Value �� BasedOn �� 
TargetType ��Name �� CornerRadius	 �� Triggers
 P� Property P� Value �� 
TargetName��%�  &	        '�� �     7   �� 5   
   " ��6#   .�5      ��  � ��$ 4q�6'   63   �� 5       � ��
 �����6?   �� 5       � ��$ 16(�6)   66   �� 5       � ��$
 Bold"�6+   6:   5      �� 5   
   " ��6   8   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $	 elc��6!   
�������$��3q�6B   $ 10��6V   ���#6c7793._�5      �� #��z��6-   $��Center=�6Q   $��Center=�6n   5      	 5      P� 5      
 �@J�IsMouseOver . . �5   "   �� $	 elc��6?    � �� �#26d9486P   5      P� 5       
 � �� . . �5!   "   �� $	 elc��6@    � �� �#3c13ec6Q   5"      5$      5'      5(      5)      .��5-      �  � ColumnDefinitions 5.   
   �� 5/      �� 50      �� 51      �� 52       � RowDefinitions 55   
   �� 56      $
��0.8* �6   �� 57      $
��1.1* �6   �� 58      $��1* �6   �� 59      $��1* �6   �� 5:      $��1* �6   �� 5;      $��1* �6   �� 5<      $��1* �6   .+�5A   
   �� -   5         ��Name$
 btn7��5A      $��0��6    $��3��6C   .��6P   76S   �� 5B   
   -   5        $
 btn8��5B   !   $��1��6   $��3��6B   .��6O   86R   �� 5C   
   -   5        $
 btn9��5C   !   $��2��6   $��3��6B   .��6O   96R   �� 5D   
   -   5        $
 btn4��5D   !   $��0��6   $��4��6C   .��6P   46S   �� 5E   
   -   5        $
 btn5��5E   !   $��1��6   $��4��6C   .��6P   56S   �� 5F   
   -   5        $
 btn6��5F   !   $��2��6   $��4��6B   .��6O   66R   �� 5G   
   -   5        $
 btn1��5G   !   $��0��6   $��5��6D   .��6Q   16T   �� 5H   
   -   5        $
 btn2��5H   !   $��1��6   $��5��6B   .��6O   26R   �� 5I   
   -	   5        $
 btn3��5I   !   $��2��6   $��5��6B   .��6O   36R   �� 5J   
   -
   5        $
 btn0��5J   !   $��1��6   $��6��6B   .��6O   06R   �� 5K   
   -   5        $ btnDot��5K   !   $��2��6   $��6��6F   .��6S   .6V   �� 5O   
   -   5        $ btnPlus��5O   !   $��3��6   $��2��6H   .��6U   +6X   �� 5P   
   -   5        $ btnSub��5P   !   $��3��6   $��3��6F   .��6S   -6V   �� 5Q   
   -   5        $ btnMul��5Q   !   $��3��6   $��4��6F   .��6S   x6V   �� 5R   
   -   5        $ btnDiv��5R   !   $��3��6   $��5��6F   .��6S   /6V   �� 5S   
   -   5        $ btnEqual��5S   !   $��3��6   $��6��6J   .��6W   =6Z   �� 5T   
   -   5        $ 
btnPlusMin��5T   !   $��0��6   $��6��6N   .��6[   +-6_   �� 5V   
   -   5        $ btnCE��5V   .   $��0��6   $��2��6!   .��6Q   CE6U   �� 5W   
   -   5        $
 btnC��5W   .   $��1��6   $��2��6!   .��6O   C6R   �� 5X   
   -   5        $ btnBackspace��5X   .   $��2��6   $��2��6!   $��<=��6_   6q   �� 5\   
   -   5         ��Name$ 
txtDisplay��5^      $��1��5\      $��1��6   $��4��6/    �� TextAlignment$ Right=�6C   $��Bottom=�5]      $��45(�6-   $��0q�6;   5^      �� 5`   
   $��0��6   $��0��6!   $��4��61    �� TextAlignment$ Center=�6E   
��� ���$��Center=�5a   (   $��30(�6C   
Calculator6^   5f      5h      