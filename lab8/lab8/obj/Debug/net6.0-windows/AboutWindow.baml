   M S B A M L   `   `   `  ����?  ;lab8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab67lab67  5   	       lab67.AboutWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:lab67     5   	   -   5          � Title$  AboutWindow��5      $	��450��6   $	��800��6,   $	��450��6;   $	��800��6K   $	��450��6Z   $	��800��6g   .��5	      � $��
0,0,-0.4,0q�6    � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      6!    � RowDefinitions 5   
   �� 5      6   .+�5   
   �� -   5         ��Name$ 
ImageField��5      $
��Left=�6$   $��10q�6?   $	��380��6K   $	��400��6W   $	��Top=�6d   �� 5   
   $��1��6   $��20q�6%   $��Center=�61   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��0,10q�62   .+�5      �� -   5         ��Name$ 	NameLabel��5      $��20(�6/   $
��Wrap=�6=      AddName#���   6Q   �� 5      -   5        $ NameBox��5      $��20(�6-   $
��Wrap=�6;   5      �� 5      $ 
Horizontal=�6   $
��0,10q�62   .+�5      �� -   5        $ GenresLabel��5      $��20(�61   $
��Wrap=�6?     AddGenre#���  6S   �� 5      -   5        $ 	GenresBox��5      $��20(�6/   $
��Wrap=�6=   5      �� 5      $ 
Horizontal=�6   $
��0,10q�62   .+�5      �� -   5        $ 
PriceLabel��5      $��20(�60   $
��Wrap=�6>     AddPrice#���  6R   �� 5      -   5        $ PriceBox��5      $��20(�6.   $
��Wrap=�6<   5      �� 5      $ 
Horizontal=�6   $
��0,10q�62   .+�5       �� -	   5        $ QuantityLabel��5       $��20(�63   $
��Wrap=�6A     AddQuantity#���  6U   �� 5!      -
   5        $ QuantityBox��5!      $��20(�61   $
��Wrap=�6?   5"      �� 5#      $ 
Horizontal=�6   $
��0,10q�62   .+�5$      �� -   5        $ StatusLabel��5$      $��20(�61   $
��Wrap=�6?     
AddStatuse#���  6S   �� 5%      -   5        $ 	StatusBox��5%      $��20(�6/   $
��Wrap=�6=     DataTrigger#���  6Q   5&      �� 5'      $ 
Horizontal=�6   $
��0,60q�62   .+�5(      �� -   5         ��Name$ 
EditButton��5(        Editing#���  6-   $��75��6Q   $
��40,0q�6\   6j   �� 5)      -   5        $ DeleteButton��5)        AboutRemove#���  6/   $��75��6W   6b   5*      5+      5,      5-      