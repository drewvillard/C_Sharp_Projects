   M S B A M L   `   `   `  ����S  OPROG2500_A3_Chinook_Linq, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:PROG2500_A2_ChinookPROG2500_A2_Chinook  5   	   $    PROG2500_A2_Chinook.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:PROG2500_A2_Chinook     5   	   -   5          � Title$  Chinook Music Store��5   	   $	��650��6%   $	��900��62    � 	Resources 5
         home �� 	UriSource  artists 
 albums 
 tracks  exit  	catalogue  customer  SubMenuItemsPanel 	 brush � RowDefinitions�� 5   
   %d  &	        &	 /     &	 ^     &	 �     &	 �     &	 �     &	 "    &	 U    7  �� 5      $ /images/home.png?�6'   6F   �� 5      $ /images/band.png?�6*   6I   �� 5      $ /images/album.png?�6)   6I   �� 5      $ /images/song.png?�6)   6H   �� 5      $ /images/reject.png?�6'   6H   �� 5      $ /images/catalogue.png?�6,   6P   �� 5      $ /images/customer.png?�6+   6N   �� 5      .R�5      � 8��   5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   5!      5"      5#      .��5&      ]� .+�5'   
   o� $	��Top=�6   #��[ 6$   .@�5(      m� $
��File��6   ��5)      �� 5*       �� ResourceKey$ SubMenuItemsPanel��6.   6P   .@�5,      m� -   5        $��_Exit��5,       m� Icon 5-      �� 5.      #��[ 6    6A   50      51      m� 52      $��_Pages��6   ��53      �� 55      $ SubMenuItemsPanel��6.   .@�57      m� -   5         m�Name$
 Home��57      $��_Home��6)   $��0��6K    58      �� 59      #��[  6    6A   5;      m� 5<      -   5        $ ViewArtists��5<      $��_View Artists��60   $��1��6a    5=      �� 5>      #��[ 6    6D   5@      m� 5A      -   5        $ 
ViewAlbums��5A      $��_View Albums��6/   $��2��6^    5B      �� 5C      #��[ 6    6C   5E      m� 5F      -   5        $ 
ViewTracks��5F      $��_View Tracks��6/   $��3��6^    5G      �� 5H      #��[ 6    6C   5J      5L      5M      � 5N   
   $	��Top=�6   $��30��6$   $	��Top=�60   #��[ 6H   .+�5Q      �� $%��Welcome To Chinook Music Store!��6   $��Center=�6?   $��Center=�5R      
���   �$��3��5S      
������ $��20(�6A   $��26��6O   $	��320��6[   $
��Bold"�6g   5U      c� 5V   
   $
��Left=�6   $��86��6(   #��[ 63   .@�5W      ��  �� Orientation$ Vertical=�6   $��50��60   .+�5X      �� -   5         ��Name$ 
HomeButton��5X      	 � ToolTip$
	 Home��6@   .��5Y      �� #��[  6   6=   5Z      �� 5[      -   5        $ ArtistsButton��5[      $	 View Artists��6J   .��5\      �� #��[ 6   6@   5]      �� 5^      -	   5        $ AlbumsButton��5^      $	 View Albums��6H   .��5_      �� #��[ 6   6?   5`      �� 5a      -
   5        $ TracksButton��5a      $	 View Tracks��6H   .��5b      �� #��[ 6   6?   5c      �� 5d      -   5        $ CataloguesButton��5d      $	 View Catalogue��6R   .��5e      �� #��[ 6   6B   5f      �� 5g      -   5        $ CustomerButton��5g      $	 View Customers��6N   .��5h      �� #��[ 6   6A   5i      5j      5k       � 5l   
   -   5        
  �Name$
 	mainFrame��5l      $
��Auto��6#   $
��Auto��61     � NavigationUIVisibility$ Hidden=�6>   $��Bottom=�5m      #��[ 6(   5p      5q      5~      