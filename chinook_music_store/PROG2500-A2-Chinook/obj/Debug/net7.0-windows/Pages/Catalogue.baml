   M S B A M L   `   `   `  ����S  OPROG2500_A3_Chinook_Linq, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PROG2500_A2_Chinook.PagesPROG2500_A2_Chinook.Pages  5      )    #PROG2500_A2_Chinook.Pages.catalogue   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:PROG2500_A2_Chinook.Pages     5        N� Title$  	catalogue��5	       � 	Resources 5
         catalogueViewSource 
 search �� 	UriSource��%X   &	        &	      �� 5   
   6=   �� 5   
   $ /images/search.png?�6%   6F   5      .��5      �� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Stretch=�6.   $��
50,0,70,10q�6L    	 brush#��[ 6`   .+�5      �� $��18(�6   �� 5      $
��Bold"�6   .�6(   Music Catalogue69    �� 5      2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve6   .�6+     Search by artist:6@   5      �� 5      -   5         ��Name$ 	searchBox��5      $	��300��6)   $��75,0,3,0q�65   .��6G   5      �� 5      -   5         ��Name$ searchButton��5      $��25��6+    � ToolTip$ Search��66   .��5      �� #��[ 6   6;   5      5      �� 5   
   -   5         ��Name$ catalogueListView��5      $��Visible=�6.   $
��True��5      $
��auto��68   $
�� 600��6E   ��5      �� 5       	 �� 
TargetType"	 ��6   .�5!      �� 
 �� Property
 � �� �� Value# [ 63   5#      ��5%      �� 5&      .R�5'      �� $ 
Horizontal=�6!   .+�5(      �� $
��Bold"�6;   $��14(�6M   ��6$   �� *Index+6]   �� 5)       preserve6/   $	��  (��6$   6F   �� 5*      ��6$   �� *artistCount+�� 5+      $��)��6$   6/   9� 5,      $�� View Artists��6#   $��20(�6:   $	��300��6H   .��5-      �� $��Visible=�6F   $
��True��5.      ��5-   '   �� *artist+��5/   "   �� 50   &   "	 ��6,   .�51   *   �� 
 � ��# [ 6G   52   '   ��54   "   �� 55   &    �� DataType$ local:Artist��63   .R�56   *   �� $ 
Horizontal=�65   $
��auto��6N   .+�57   .   �� ��68   �� *Name+6P   9� 58   .   $��Show Albums��67   $	��200��6L   .��59   2   �� $��Visible=�6Z   $
��True��5:   i   ��59   ;   �� *Albums+��5;   6   �� 5<   :   "	 ��6@   .�5=   >   �� 
 � ��# [ 6[   5?   ;   ��5A   6   �� 5B   :   $ local:Album��6G   .R�5C   >   �� $�� auto��6I   $ 
Horizontal=�6W   .+�5D   B   �� ��6L   �� *Title+6e   9� 5E   B   $��View Tracks��6K   $	��150��6`   .��5F   F   �� $��Visible=�6n   $
��True��5G   x   ��5F   O   �� *Tracks+��5H   J   �� 5I   N   "	 ��6T   .�5J   R   �� 
 � ��# [ 6o   5L   O   ��5N   J   �� 5O   N   .R�5P   R   �� $
��auto��6]   .+�5Q   V   �� ��6`   �� *Name+6x   5R   S   5S   O   5U   G   5V   C   5W   ?   5X   ;   5Z   3   5[   /   5\   +   5]   '   5_      5`      5a      5b      5d      5e      5f      