   M S B A M L   `   `   `  ����U  QWPFApp_Example1_Assignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WPFApp_Example1_AssignmentWPFApp_Example1_Assignment  5   	   +    %WPFApp_Example1_Assignment.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:WPFApp_Example1_Assignment     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��6* �6   .+�5   
   �� $��0��6   $��2��6"   $��Example Assignment-1��66   $��Arial Black)�6R   $��20(�6k   
����  �$��Center=�5      $��Center=�6/   6N   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��Center=�6;   $��Center=�5      .+�5      	� -   5        $��btn_Mr��5   (   $	��Mr.��6   $��70��5      $��30��6%   $��20(�61   	� 5      -   5        $��btn_Mrs��5   )   $
��Mrs.��6   $��70��5      $��30��6%   	� 5      -   5        $��btn_Dr��5   (   $	��Dr.��6   $��70��5      $��30��6%   	� 5      -   5        $��btn_Miss��5   (   $	��Ms.��6   $��70��5      $��30��6%   	� 5      -   5        $��btn_All��5   (   $	��All��6   $��70��5      $��30��6%   5"      &   System.Windows.Controls.DataGrid  5#   
   -   5        $��	dataGrid1��5$   [      AutoGenerateColumns . $��2��5#   O   $	��423��5$      $
��1500��6    $
��Left=�6-   $��	22,24,0,0q�6H   $	��Top=�5%      ��5#      �� *
Employee+5%      5)      5*      