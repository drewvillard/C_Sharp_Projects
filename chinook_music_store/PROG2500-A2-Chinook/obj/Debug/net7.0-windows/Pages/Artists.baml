   M S B A M L   `   `   `  ����S  OPROG2500_A3_Chinook_Linq, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PROG2500_A2_Chinook.PagesPROG2500_A2_Chinook.Pages  5      '    !PROG2500_A2_Chinook.Pages.Artists   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:PROG2500_A2_Chinook.Pages     5        N� Title$  Artists��5	       � 	Resources 5         artistViewSource �� 
TargetType �� Property �� Value 	 brush 
 search �� 	UriSource��%�   &	        '��      7  &	 �     �� 5   
   6:   �� 5   
   " ��6   .�5      ��  � ��$
 Left=�64   6C   �� 5       � ��8   6+   �� 5       � ��$ 6q�6(   64   5      �� 5   
   $ /images/search.png?�6%   6F   5      .��5      �� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Stretch=�6.   $��
70,0,95,10q�6L   #��[ 6`   .+�5      �� $��18(�6   �� 5   
   $
��Bold"�6   .�6    Chinook Artists61    �� 5   
   2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve6   .�6#       Search Artists:68   5      �� 5      -   5         ��Name$ 	searchBox��5      $	��300��6)   $��20,0,3,0q�65   .��6G   5       �� 5!      -   5        	 ��Name$	 searchButton��5!      $��25��6+   
 � ToolTip$
 Search��6Q   .��5"      �� #��[ 6   6;   5#      5$      �� 5&   
   -   5         ��Name$ artistListView��5&      $��10q�6+   #��[ 6z   $
��True��5'      $	��550��68   ��5&   9   ��  �� Source# [   �� View 5(      �� 5)      .P�5*      �� $��ID��6%    �� Width$
 auto��6[    �� DisplayMemberBinding 61   �� *
ArtistId+6[   �� 5+      $��Artists Name��6%   $
 auto��6a    6;   �� *Name+6a   5-      5/      51      52      