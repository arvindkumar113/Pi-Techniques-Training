   M S B A M L   `   `   `  ����T  PCheckBox_Trigger_Demo_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CheckBox_Trigger_Demo_WPFCheckBox_Trigger_Demo_WPF  5   	   *    $CheckBox_Trigger_Demo_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:CheckBox_Trigger_Demo_WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $&�� Check Box Triggering Demo in WPF��6!   $��10q�5      $	��500��6    $��50��6,    �� TextAlignment$ Center=�68   $��Center=�5      $��Center=�6/   $��24(�6L   $
��Bold"�6Z   
����  �
����� �5   *   �� 5   
   -   5        $��txtBox1��5   7   $��1��6   $��10q�6   $��5q�6+   $	��400��5      $��40��6   
���z�����5      �� *Text+ �� ElementName$ txtBox2�� �� Mode$ TwoWay=��� 5   
   -   5        $��txtBox2��5   8   $��2��6   $��10q�6    $��5q�6,   $	��400��5      $��40��6   
���������5      �� *Text+$ txtBox1��$ TwoWay=�5      5      