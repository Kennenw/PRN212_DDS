   M S B A M L   `   `   `  ����S  ODiamondShopSystem.WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:DiamondShopSystem.WpfApp.UIDiamondShopSystem.WpfApp.UI  5   	   1    +DiamondShopSystem.WpfApp.UI.WSearchCustomer   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:DiamondShopSystem.WpfApp.UI     5   	     � Title$  Search Customer��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $��Customer Form��6   $��10q�6.   .��5      �  � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5      $
��Auto �6+   �� 5      $��* �6+   .+�5      �� $��0��6   $��0��6)   $
��Name��69   $
��Left=�6H   $��Center=�6c   �� 5      -   5         ��Name$ CustomerName��5   ;   $��0��6   $��1��6+   $��25��6Q   $��5q�6�   $	��180��6�   $
��Left=�6�   ��6]   ��  �� Path$ Customer.CustomerName� �� Mode$ TwoWay=�6�   �� 5      $��0��6   $��2��6)   $��Phone��69   $
��Left=�6I   $��Center=�6d   �� 5      -   5        $ Phone��5   ;   $��0��6   $��3��6+   $��25��6J   $��5q�6�   $	��180��6�   $
��Left=�6�   ��6V   �� $ Customer.Phone�$ TwoWay=�6�   �� 5!      $��1��6   $��0��6)   $��Address��69   $
��Left=�6K   $��Center=�6f   �� 5"      -   5        $ Address��5"   ;   $��1��6   $��1��6+   $��25��6L   $��5q�6�   $	��180��6�   $
��Left=�6�   ��6X   �� $ Customer.Address�$ TwoWay=�6�   �� 5$      $��1��6   $��2��6)   $��Email��69   $
��Left=�6I   $��Center=�6d   �� 5%      -   5        $ Email��5%   ;   $��1��6   $��3��6+   $��25��6J   $��5q�6�   $	��180��6�   $
��Left=�6�   ��6V   �� $ Customer.Email�$ TwoWay=�6�   �� 5'      $��0��6   $��4��6)   $��Gender��69   $
��Left=�6J   $��Center=�6e   �� 5(      -   5        $ Gender��5(   ;   $��0��6   $��5��6+   $��25��6K   $��5q�6�   $	��180��6�   $
��Left=�6�   ��6W   �� $ Customer.Gender�$ TwoWay=�6�   �� 5*      $��2��6   $��4��6)   $��IsActive��69   $
��Left=�6L   $��Center=�6g   �� 5+      -   5         ��Name$ IsActive��5+   <   $��2��6   $��5��6,   $��5q�6�   $
��Left=�6�    d� 	IsChecked 6N   �� $ Customer.IsActive�$ TwoWay=�6�   5-      5.      �� 5/      $��40��6   $ 
Horizontal=�6%   $��Right=�6>   $	��171��6Z   .+�50      �� -   5        	 ��Name$	 ButtonSearch��50      $��Search��6/   $��30��6@   $��80��6L   6W   �� 51      -   5        $	 	ButtonAdd��51      $��Add New��6,   $��30��6>   $��80��6J   6U   52      �� 53      $	��210��6   .+�54      &   System.Windows.Controls.DataGrid  -	   5        
  Name$
 grdCustomer��54         AutoGenerateColumns$ False��60      CanUserAddRows$ False��6n   $	��200��6�   $��10q�6�      SelectionMode$ Single=�55   D      SelectionUnit$ FullRow=�6[   ��54   L   �� *	Customers+   Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$
 Code��6-      
Visibility$ Visible=�6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� $ 
CustomerId�6_     58      $
 Name��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6a      
IsReadOnly$
 True��6m    6;   �� $ CustomerName�6m     59      $ Phone��6-   $	 100 6[   $
 True��6g    6<   �� $ Phone�6g     5:      $ Address��6-   $	 100 6_   $ Visible=�6k    6>   �� $ Address�6k     5;      $ Email��6-   $	 100 6[   $
 True��6g    6<   �� $ Email�6g     5<      $ Password��6-   $	 100 6a   $
 True��6m    6?   �� $ Password�6m     5=      $ ImgUrl��6-   $	 100 6]   $
 True��6i    6=   �� $ ImgUrl�6i     5>      $ 
CreateDate��6-   $	 100 6e   $
 True��6q    6A   �� $ 
CreateDate�6q     5?      $ Gender��6-   $	 100 6]   $
 True��6i    6=   �� $ Gender�6i     5@      $ IsActive��6-   $	 100 6a   $
 True��6m    6?   �� $ IsActive�6m     5A      $ 
UpdateTime��6-   $	 100 6e   $
 True��6q    6A   �� $ 
UpdateTime�6q   4  .System.Windows.Controls.DataGridTemplateColumn  5B      $ 50 61      CellTemplate 5C      �� 5D   "   .R�5E   &   �� $	 ButtonViewDetail��6-   -
   5        $
��View��5E   G   ��6W   �� $ 
CustomerId�6�   5F   #   5H      5J      5K      5L      5M      5N      