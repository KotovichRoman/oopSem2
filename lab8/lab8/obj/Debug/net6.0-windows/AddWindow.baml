   M S B A M L   `   `   `  ����?  ;lab8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab67lab67  5   	       lab67.AddWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:lab67     5   	      	MainTitle  � Title#  �   5   	   $	��400��6.   $	��400��6>   $	��400��6M   $	��400��6Y   $	��600��6f   $	��600��6v   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.6* �6   6,   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$ 
FromHeader��5      $��0��6$   $��3��61     AddGame#���  6E   $��Center=�6i   $��Center=�6�   $
��Bold"�6�   $��Times New Roman)�6�   $��20(�6�   �� 5   
   -   5        $ GameNameLabel��5      $��1��6'   $��0��64     AddName#���  6D   $��Times New Roman)�6h   $��22,0.4,22.8,32.4q�6�   �� 5   
   -   5         ��Name$ GameNameBox��5      $��1��6'   $��0��64   $��16,26.4,30.8,0q�6D    �� TextWrapping$
 Wrap=�6\   $��23��6p   $	��Top=�6|     Trigger#���  6�   �� 5   
   -   5        $ GenresLabel��5      $��2��6%   $��0��62     AddGenre#���  6B   $��Times New Roman)�6g   $��22,0.4,22.8,32.4q�6�   �� 5   
   -   5         ��Name$ GenresComboBox��5      $��2��6+   $��0��68   $��16,23.6,30.8,0q�6H   $��23��6`   $	��Top=�6l   .@�5      ��   CategoryAction#���  6   6H   �� 5        CategoryStrategy#���  6   6J   �� 5         CategorySimulator#���  6   6K   �� 5!        CategorySlesher#���  6   6I   �� 5"       	 CategorySport#��� 	 6   6G   5#      �� 5%   
   -   5        $ 
PriceLabel��5%      $��3��6$   $��0��61    
 AddPrice#��� 
 6A   $��Times New Roman)�6f   $��22,0.4,22.8,32.4q�6�   �� 5&   
   -   5        $ PriceBox��5&      $��3��6$   $��0��61   $��16,26.6,30.8,0q�6A   $
 Wrap=�6Y   $��23��6m   $	��Top=�6y   #���  6�   �� 5(   
   -   5        $ QuantityLabel��5(      $��4��6'   $��0��64     AddQuantity#���  6D   $��Times New Roman)�6l   $��22,0.4,22.8,32.4q�6�   �� 5)   
   -	   5        $ QuantityBox��5)      $��4��6'   $��0��64   $��16,26.6,30.8,0q�6D   $
 Wrap=�6\   $��23��6p   $	��Top=�6|   #���  6�   �� 5+   
   -
   5        $ 
ImageLabel��5+      $��5��6$   $��0��61     AddImage#���  6A   $��Times New Roman)�6f   $��22,0.4,22.8,32.4q�6�   �� 5,   
   -   5         ��Name$ ImageButton��5,      $��5��6&   $��0��63   $��16,26.6,30.8,0q�6C     AddSelectedImage#���  6[   $��23��6�   $	��Top=�6�   6�   �� 5.   
   -   5        $ 	AddButton��5.      $��6��6$   $��1��61    	 AddOk#���  6B   $��61.2,18.6,60.6,0q�6d   $��19��6~   $	��Top=�6�   6�   5/      50      