   M S B A M L   `   `   `  ����Q  MMohamadShiha_S00189636, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MohamadShiha_S00189636MohamadShiha_S00189636  5   	   '    !MohamadShiha_S00189636.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MohamadShiha_S00189636     5   	   -   5          � Title$  Exam Phone App��5	   	   $	��450��6    $	��800��6-    � 
ResizeMode$ CanMinimize=�69    � 	Resources 5         PhoneListBox �� Orientation �� Path��%  &	        �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $��2q�69   $
��Left=�6D   $��Center=�6`   ��6   �� $ OS_Image�6`   �� 5      $��16(�6   $��2q�6F   $
��Left=�6Q   $��Center=�6l   ��6+   �� $
 Name�6l   5      5      5      .��5      � $	��550��6   $	��550��6   $	��250��6&    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��8* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��1��6   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6+   .��5      �� -   5         ��Name$ PhoneslistBox��5      #��[  6-   $ Depth3=�5       	 �� SelectedValuePath$	 Price��5!      6.   5"        5$   
   $��1��6   $��0��6.   $ Depth4=�6;   .��5%      �� -   5        
 ��Name$
 PhonePriceTextBox��5%      $��Price:��63   $��Center=�6A   $��20(�6^   5&        5(   
   $��1��6   $��1��6+   $ Depth1=�6;   .��5)      �� -   5         ��Name$ 
PhoneImage��5)      $��10q�6)   5*      5,      5-      