   M S B A M L   `   `   `  ����@  <Chuck, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ChuckChuck  5   	       Chuck.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Chuck     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $��25(�5	   	   .��5
      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   $��40��6*   �� 5      .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6&   .+�5      �� -   5        $��SearchJokeTBox��5      $	��250��60   6A   �� 5      -   5        $��SearchJokeBtn��5      .��6K   Search6S   5      � 5      $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��
JokesDGrid��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         MinRowHeight$ 40Q�6'      AutoGenerateColumns$ False��5         
IsReadOnly$
 True��63      CanUserResizeColumns$ False��5         CanUserResizeRows$ False��64   	   CanUserReorderColumns$	 False��5      $
   HorizontalScrollBarVisibility$
 Disabled=�65      HeadersVisibility$ Column=�5         HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6-      Width$
 auto 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
created_at+   ElementStyle 5      �� 5   "   .�5   &   ��  �� Property �@��Padding �� Value$ 10q�6J   5    #   5"        5#      $
 Joke��6-    6;   �� *value+ 5$      �� 5%   "   .�5&   &   ��  � ��$
 Wrap=�6O   �� 5'   &    �@��Padding$ 10q�6J   5(   #   5*      5,      5-      5.      5/      