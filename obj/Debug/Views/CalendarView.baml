   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    	Practice4"   Practice4.Views.CalendarView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	     � 	Resources  5       �� 
TargetType   ButtonStyle �� Property �� Value �� Triggers P� Property P� Value��%�   &	        �� 5	   
   " ��6   .�5
      ��  � ��
 ��  �6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 �  ��63   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   � $��0��6   $��Center=�6   $��10q�69   .+�5      �� $��Calendar��6   $
��Bold"�5      $��60(�5      $��Arial)�5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� $
��Left=�6   $ Vertical=�64   $��15, 0, 15, 15q�6K   .+�5      �� $��Choose your birthday:��6   $
��Bold"�5       $��15(�5!      $��Arial)�5"      (  "System.Windows.Controls.DatePicker  5&      -   5        	  Name$	 calendar��5&      
   FirstDayOfWeek$
 Monday=�6/      SelectedDate 5'      �� *Date+5(      5)      �� 5*      $ Vertical=�6   $��15q�60   .+�5+      �� $ 
Horizontal=�6   $��0,5,0,5q�66   .+�5,      �� $��
User age: ��6    $
��Bold"�5-       $��15(�5.       $��Arial)�5/       �� 50      -   5         ��Name$	 Age��50       $
��Bold"�51       $��15(�52       $��Arial)�53       ��50   -   ��  �� Path$	 Age� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�53       54      �� 55      $ 
Horizontal=�6   $��0,5,0,5q�66   .+�56      �� $��	Western: ��6    $
��Bold"�57       $��15(�58       $��Arial)�59       �� 5:      -   5        $ Western��5:       $
��Bold"�5;       $��15(�5<       $��Arial)�5=       ��5:   1   �� $ Western�$ TwoWay=�$ PropertyChanged=�5=       5>      �� 5?      $ 
Horizontal=�6   $��0,5,0,5q�66   .+�5@      �� $��	Chinese: ��6    $
��Bold"�5A       $��15(�5B       $��Arial)�5C       �� 5D      -   5        $ Chinese��5D       $
��Bold"�5E       $��15(�5F       $��Arial)�5G       ��5D   1   �� $ Chinese�$ TwoWay=�$ PropertyChanged=�5G       5H      5I      5J      5L      5M      