   M S B A M L   `   `   `  ����C  ?WPFDemo1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFDemo1WPFDemo1  5   	       WPFDemo1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPFDemo1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $	��25* �6   �� 5      $	��50* �6   �� 5      $	��75* �6   .+�5"   
   �� $��2��6   $��Registration Form��6$   $��10q�6@   $��Center=�6L   $��Center=�6i   5#      �� 5$   
   $��1��6   $��0��6   $��	User Nane��6-   $��Center=�6A   $��Center=�6^   5%      �� 5&   
   $��2��6   $��0��6   $��Address��6-   $��Center=�6?   $��Center=�6\   5'      �� 5(   
   $��3��6   $��0��6   $��country��6-   $��Center=�6?   $��Center=�6\   5)      �� 5*   
   $��4��6   $��0��6   $��Gender��6-   $��Center=�6>   $��Center=�6[   5+      �� 5,   
   $��5��6   $��0��6   $��Hobbies��6-   $��Center=�6?   $��Center=�6\   5-      �� 5/   
   -   5        $��txtUname��5/   /   $��1��6   $��1��6   $	��150��6?   $��10q�6K   $
��Left=�6W   �� 50   
   -   5        $��txtAdd��50   /   $��2��6   $��1��6   $	��150��6=   $��50��6I   $��10q�6U   $
��Left=�6a    �� TextWrapping$ WrapWithOverflow=�6|   " �� VerticalScrollBarVisibility$
 Auto=�51      $ �� HorizontalScrollBarVisibility$
 Auto=�65    �� 	IsEnabled .  �� AcceptsReturn . 52      �� 54   
   -   5        $��
cmbCountry��54   0   $��3��6   $��1��6    $	��100��6B   $��10q�6N   $
��Left=�6Z   .@�55      �� .��6   France6#   �� 56       �� 
IsSelected . .��6-   India64   �� 57      .��6   	America6$   �� 58      .��6   	England6$   59      �� 5;   
   -   5        $��	cmbGender��5;   W   $��4��6   $��1��6"   $��10q�62   	 �� Orientation$	 
Horizontal=�6>   .+�5<      	� $
��Male��6   $��5q�6)   
 	� 	GroupName$
 gender��64   	� 5=      $��Female��6   $��5q�6+   $
 gender��66   6K   	� 5>      $��Others��6   $��5q�6+   $
 gender��66   6K   5?      �� 5A   
   $��5��6   $��1��6"   $��10q�62   $	 
Horizontal=�6>   .+�5B      �� -   5        $��
cheReading��5B      $��5q�6)   .��64   	Reading6=   �� 5C      -   5         ��Name$ 
chkWriting��5C      $��5q�6+   .��67   	Writing6@   5D      �� 5F   
   $��6��6   $��1��6"   $��10q�62   $	 
Horizontal=�6>   .+�5G      �� -   5        $��	btnSubmit��5G      $��Submit��6&   $��5q�6O   6\   �� 5H      -   5        $��
btnCancell��5H      $��Cancel��6'   $��5q�68   6^   5I      5P      5Q      