   M S B A M L   `   `   `  ����D  @MVVMDemo1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMDemo1.ViewsMVVMDemo1.Views  5   	   ;"clr-namespace:MVVMDemo1.ViewModelsMVVMDemo1.ViewModels  5   	       MVVMDemo1.Views.UserView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MVVMDemo1.Views     5   	   6localvm"clr-namespace:MVVMDemo1.ViewModels     5   	     � Title$  UserView��5	   	   $	��450��6   $	��800��6'    � 	Resources 5      (   "MVVMDemo1.ViewModels.UserViewModel   userViewModel��%   &	          5   
   6    5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � -   5        $��	childgrid��5      $��0��6     5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5       $��* �6#   .+�5"      �� $��0��6   $��User ID��6!   �� 5#      $��1��6   $��
First name��6!   �� 5$      $��2��6   $��	Last Name��6!   �� 5%      $��3��6   $��Country��6!   �� 5&      $��0��6   $��1��6#   ��64   �� *UserId+�� 5'      $��1��6   $��1��6#   ��63   �� *	FirstName+�� 5(      $��2��6   $��1��6#   ��64   �� *
LastName+�� 5)      $��3��6   $��1��6#   ��64   �� *	Country+5*      �� 5+   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5,      �� $��1��6   $��Add User��6"   ��65   �� *
AddCommand+�� 5-      $��2��6   $��Delete User��6"   ��68   �� *RemoveCommand+5.      �� 5/   
   -   5        $��lstUser��5/       $��2��6   ��6/   �� *Users+ �� View 50      �� 51      -   5        grdTest��.P�52      �� $��UserId��6%    �� Width$ 50��6^    �� DisplayMemberBinding 65   �� *UserId+6^   �� 53      $��
First Name��6%   $ 80��6e    69   �� *	FirstName+6e   �� 54      $��	Last Name��6%   $	 100��6b    68   �� *
LastName+6b   �� 55      $��Country��6%   $	 100��6_    66   �� *	Country+6_   56      58      59      5;      