   M S B A M L   `   `   `  ����S  ODiamondShopSystem.WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:DiamondShopSystem.WpfApp.UIDiamondShopSystem.WpfApp.UI  5   	   +    %DiamondShopSystem.WpfApp.UI.WCustomer   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:DiamondShopSystem.WpfApp.UI     5   	     � Title$  Customer��5   	   $	��450��6   $
��1000��6'   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $��Customer Form��6   $��10q�6.   .��5      �  � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5      $
��Auto �6+   �� 5      $��* �6+   .+�5      �� $��0��6   $��0��6)   $
��Code��69   $
��Left=�6H   $��Center=�6c   �� 5      -   5         ��Name$ 
CustomerId��5   ;   $��0��6   $��1��6+   $��25��6O    �� 
IsReadOnly$
 True��6\   $��5q�6n   $	��180��6y   $
��Left=�6�   �� 5      $��0��6   $��2��6)   $
��Name��69   $
��Left=�6H   $��Center=�6c   �� 5      -   5        $ CustomerName��5   ;   $��0��6   $��3��6+   $��25��6Q   $��5q�6^   $	��180��6i   $
��Left=�6u   �� 5!      $��0��6   $��4��6)   $��Phone��69   $
��Left=�6I   $��Center=�6d   �� 5"      -   5        $ Phone��5"   ;   $��0��6   $��5��6+   $��25��6J   $��5q�6W   $	��180��6b   $
��Left=�6n   �� 5#      $��1��6   $��0��6)   $��Address��69   $
��Left=�6K   $��Center=�6f   �� 5$      -   5        $ Address��5$   ;   $��1��6   $��1��6+   $��25��6L   $��5q�6Y   $	��180��6d   $
��Left=�6p   �� 5&      $��1��6   $��2��6)   $��Email��69   $
��Left=�6I   $��Center=�6d   �� 5'      -   5        $ Email��5'   ;   $��1��6   $��3��6+   $��25��6J   $��5q�6W   $	��180��6b   $
��Left=�6n   �� 5(      $��1��6   $��4��6)   $��Password��69   $
��Left=�6L   $��Center=�6g   �� 5)      -   5        $ Password��5)   ;   $��1��6   $��5��6+   $��25��6M   $��5q�6Z   $	��180��6e   $
��Left=�6q   �� 5+      $��2��6   $��0��6)   $��ImgUrl��69   $
��Left=�6J   $��Center=�6e   �� 5,      -   5        $ ImgUrl��5,   ;   $��2��6   $��1��6+   $��25��6K   $��5q�6W   $	��180��6b   $
��Left=�6n   �� 5-      $��2��6   $��2��6)   $��
CreateDate��69   $
��Left=�6N   $��Center=�6i   (  "System.Windows.Controls.DatePicker  5.      -   5          Name$ 
CreateDate��5.   >   $��2��6!   $��3��6.   $��5q�6R   $	��180��6]   $
��Left=�6i   �� 50      $��2��6   $��4��6)   $��Gender��69   $
��Left=�6J   $��Center=�6e   �� 51      -	   5        $ Gender��51   ;   $��2��6   $��5��6+   $��25��6K   $��5q�6X   $	��180��6c   $
��Left=�6o   �� 52      $��3��6   $��2��6)   $��IsActive��69   $
��Left=�6L   $��Center=�6g   �� 53      -
   5         ��Name$ IsActive��53   <   $��3��6   $��3��6,   $��5q�6O   $
��Left=�6Z   �� 55      $��3��6   $��0��6)   $��
UpdateTime��69   $
��Left=�6N   $��Center=�6i     56      -   5        $ 
UpdateTime��56   >   $��3��6!   $��1��6.   $��5q�6S   $	��180��6^   $
��Left=�6j   57      58      �� 59      $��40��6   $ 
Horizontal=�6%   $��Right=�6>   $	��171��6Z   .+�5:      �� -   5         ��Name$ 
ButtonSave��5:      $
��Save��6-   $��30��6<   $��80��6H   	 J� RenderTransformOrigin$	 -0.041,0.446&�6l   �� 5;      -   5        $ ButtonCancel��5;      $��Cancel��6/   $��30��6@   $��80��6L   6W   5<      �� 5=      $	��210��6   .+�5>      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 grdCustomer��5>         AutoGenerateColumns$ False��60      CanUserAddRows$ False��6n   $	��200��6�   $��10q�6�      SelectionMode$ Single=�5?   L      SelectionUnit$ FullRow=�6c   ��5>   L   �� *	Customers+   Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$
 Code��6-      
Visibility$ Visible=�6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ��  �� Path$ 
CustomerId�6_     5B      $
 Name��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6a      
IsReadOnly$
 True��6m    6;   �� $ CustomerName�6m     5C      $ Phone��6-   $	 100 6[   $
 True��6g    6<   �� $ Phone�6g     5D      $ Address��6-   $	 100 6_   $ Visible=�6k    6>   �� $ Address�6k     5E      $ Email��6-   $	 100 6[   $
 True��6g    6<   �� $ Email�6g     5F      $ Password��6-   $	 100 6a   $
 True��6m    6?   �� $ Password�6m     5G      $ ImgUrl��6-   $	 100 6]   $
 True��6i    6=   �� $ ImgUrl�6i     5H      $ 
CreateDate��6-   $	 100 6e   $
 True��6q    6A   �� $ 
CreateDate�6q     5I      $ Gender��6-   $	 100 6]   $
 True��6i    6=   �� $ Gender�6i     5J      $ IsActive��6-   $	 100 6a   $
 True��6m    6?   �� $ IsActive�6m     5K      $ 
UpdateTime��6-   $	 100 6e   $
 True��6q    6A   �� $ 
UpdateTime�6q   4  .System.Windows.Controls.DataGridTemplateColumn  5L      $ 50 61      CellTemplate 5M      �� 5N   "   .R�5O   &   �� $ ButtonDelete��6>   -   5        $��Delete��5O   -   ��6T   �� $ 
CustomerId�5P   -   5Q   #   5S      5U      5V      5W      5X      5Y      