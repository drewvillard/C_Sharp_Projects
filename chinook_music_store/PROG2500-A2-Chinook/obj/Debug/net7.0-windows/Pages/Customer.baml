   M S B A M L   `   `   `  ����S  OPROG2500_A3_Chinook_Linq, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PROG2500_A2_Chinook.PagesPROG2500_A2_Chinook.Pages  5      (    "PROG2500_A2_Chinook.Pages.Customer   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:PROG2500_A2_Chinook.Pages     5        N� Title$  Customer��5	       � 	Resources 5         customerViewSource 
 search �� 	UriSource��%X   &	        &	      �� 5   
   6<   �� 5   
   $ /images/search.png?�6%   6F   5      .��5      �� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Stretch=�6.   $��
50,0,70,10q�6L    	 brush#��[ 6`   .+�5      �� $��18(�6   �� 5      $
��Bold"�6   .�6$   Customer Orders65    �� 5      2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve6   .�6'   	  Search:62   5      �� 5      -   5         ��Name$ 	searchBox��5      $	��300��6)   $��75,0,3,0q�65   .��6G   5      �� 5      -   5         ��Name$ searchButton��5      $��25��6+    � ToolTip$ Search��66   .��5      �� #��[ 6   6;   5      5      �� 5   
   -   5         ��Name$ customerListView��5      $��Visible=�6-   $
��True��5      $
�� 600��60   $��Stretch=�6�   
������ ��6@   �� 	 �� Source#	 [  ��5       �� 5!      .R�5"      � #��[ 6   $��Stretch=�6?   $
��auto��6[   
 � RowDefinitions
 5#      �� 5$      �� 5%      �� 5&      �� 5'       � ColumnDefinitions 5)      �� 5*      $��* �6/   �� 5+      $
��auto �6/   .+�5.      �� $��0��6$   $��0��61   $
��Bold"�6A   $��18(�6m   ��6S   �� *
FullName+6m   �� 5/      $��1��6$   $��0��61   $��14(�6W   ��6A   �� *City+6g   �� 51      $��2��6$   $��0��61   $��16(�6Z   ��6A   �� *	Country+6j   �� 53      $��3��6$   $��0��61   $��16(�6X   ��6A   �� *Email+6h   9� 54      $��0��6#   $��1��60   $	��200��6@   $��View Invoices��6P   $��20(�6g   $��4��6u   $
��auto��6�   $��	100,0,0,0q�6�   .��55      �� $ invoiceListView��65   $
�� 100��6'   $��16(�6o   ��6N   �� *
Invoices+��56   "   �� 57   &    �� 
TargetType" ��6,   .�58   *   ��  �� Property � �� �� Value# [ 6G   59   '   ��5;   "   �� 5<   &    �� DataType$ local:Invoice��63   .R�5=   *   �� $ 
Horizontal=�65   $
��auto��6N   .+�5>   *   �� ��64   �� *	OrderDate+6Q   �� 5?   *   ��64   �� *
TotalPrice+6R   �� 5@   *   ��64   �� *InvoiceCount+6T   5A   '   5B   '   5D      5E      5H      5I      5K      5L      5M      