   M S B A M L   `   `   `  ����E  AWpfAppDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfAppDemo
WpfAppDemo  5   	       WpfAppDemo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfAppDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $	��2*  �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��
First Name��6   $��1��6%   $��0��62   �� 5   
   $��	Last Name��6   $��2��6$   $��0��61   �� 5   
   $
��City��6   $��3��6   $��0��6,   �� 5   
   -   5         ��Name$ txtFName��5      $��1��6$   $��1��61   6C   �� 5    
   -   5        $ txtLName��5       $��2��6$   $��1��61   6D   �� 5!   
   -   5        $ txtCName��5!      $��3��6$   $��1��61   6C   �� 5#   
   -   5        $��	addButton��5#   !   $��1��6   $��60��6J   $	��Add��6V   $��30��6d   $��4��6p   �� 5&   
   -   5        $��lstName��5&      $��5q�6"   $��2��6-   $��1��6=   $��5��6J   ��6[   ��  �� View 5(      �� 5*      -   5        grdNames��.P�5,      �� $��	Full Name��6!    �� CellTemplate 5.      �� 50      .R�52      ��  �� Orientation$ 
Horizontal=�6)   .+�54   "   �� ��6,   �� *	FirstName+�� 56   "   $�� ��6,   �� 58   "   ��6,   �� *
LastName+5<   #   5>      5B      �� 5D      $��
First Name��6!    �� DisplayMemberBinding 65   �� *	FirstName+�� 5E      $��	Last Name��6!    64   �� *
LastName+�� 5G      $
��City��6!    6/   �� *City+5J      5O      �� 5Q   
   -   5        $��lblCount��5Q      5S      5V      5W      