   M S B A M L   `   `   `  ����S  OPROG2500_A3_Chinook_Linq, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PROG2500_A2_Chinook.PagesPROG2500_A2_Chinook.Pages  5      &     PROG2500_A2_Chinook.Pages.Tracks   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:PROG2500_A2_Chinook.Pages     5        N� Title$  Tracks��5	       � 	Resources 5         tracksViewSource  trackTemplate 	 brush � RowDefinitions � ColumnDefinitions 
 search �� 	UriSource��%6  &	        &	      7  &	 �    �� 5   
   6:   �� 5   
   .R�5      � 8��   5      �� 5      �� 5      �� 5       5      �� 5      $��* �6'   �� 5      $
��auto �6'   .+�5      �� $��0��6   $��0��6)   $
��Bold"�69   $��18(�6a   ��6K   �� *Name+6a   �� 5      $��1��6   $��0��6)   $��14(�6S   ��69   �� *
Composer+6c   �� 5      $��0��6   $��1��6)   $��16(�6S   ��69   �� *
timeInMS+6c   �� 5!      $��1��6   $��1��6)   $��16(�6V   ��69   �� *sizeInBytes+6f   � 5#      $��2��6   $��1��6*   $��2��6:   .+�5$      �� $��Price: $��6    $��16(�60   6@   �� 5%      $��16(�6;   ��6    �� *	UnitPrice+6K   5&      5(      5)      �� 5+   
   $ /images/search.png?�6%   6F   5,      .��5.      �� .+�5/   
   ��  �� Orientation$ 
Horizontal=�6   $��Stretch=�6.   $��
70,0,95,10q�6L   #��[ 6`   .+�50      �� $��18(�6   �� 51      $
��Bold"�6   .�6$   Chinook Artists65    �� 52      2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve6   .�6'       Search Artists:6<   53      �� 54      -   5         ��Name$ 	searchBox��54      $	��300��6)   $��20,0,3,0q�65   .��6G   55      �� 56      -   5         ��Name$ searchButton��56      $��25��6+   	 � ToolTip$	 Search��6Q   .��57      �� #��[ 6   6;   58      59      �� 5:   
   -   5        
 ��Name$
 tracksListView��5:      $	��550��6+   #��[ 5<      $��Stretch=�5=      
������ ��5;      ��  �� Source# [  5@      5A      5C      