   M S B A M L   `   `   `  ����E  Ainventario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:inventario.Viewsinventario.Views  5      ,    &inventario.Views.Categoria_agricultura   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:inventario.Views     5        N� Title$  Categoria_agricultura��5	       � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid �� 
TargetType ��Name	 J� SnapsToDevicePixels
 �Name J� Opacity � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName   estilosDataGrid �� Padding ��Name � ColumnDefinitions � RowDefinitions   SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name  �� CanContentScroll! ��Name" �� ScrollableHeight# � Maximum$ �� Orientation% �� ViewportHeight& �� ViewportSize*' �� #ComputedVerticalScrollBarVisibility( � Value) �� Mode* �� Mode+ �� ScrollableWidth, �� ViewportWidth,- �� %ComputedHorizontalScrollBarVisibility. �� Triggers/ ]� 
Conditions0 �� Property1 �� Value  TextBox.Static.Border2 �� Color  estilosTextBox-  'System.Windows.Input.KeyboardNavigation3 ��Name��%m  '        (�� �     5      $" DataGridSelectAllButtonStyle��"  )&	  �    &	 �    &	 �    �� 5   
   "  6   .�5      ��  � �� �	#FF10CD006+   �� 5       � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   �� 5       � ��$ 10q�6(   5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ Border��6(   #��� ��68   $
	 True��6y   � 5      $
 Arrow��6&   
���   �$��Right=�6B   $��8,8,3,3q�6^   $
 0.15Q�6o    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   �� $ Border��6;   # � ��6O    � ��5      P� 5        � ��$
 True��6;   . �5!   "   �� $ Border��69   # � ��6M    � ��5"      P� 5#       � {�$ False��6;   . �5$   "   �� $ Arrow��6?    � y�$ 	Collapsed=�6R   5%      5'      5)      5*      �� 5+   
   "  6(   .�5,      ��  � ��# � ��6+   �� 5-       � ��# � ��6+   �� 5.        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5/       � ��$
 true��6>   �� 50       �@��PanningMode$
 Both=�69   �� 51       �@��IsFlicksEnabled$ False��67   �� 52       � �� 53      �� 54      "  6&   .R�55      �� #��z��6!   # z��6K   $
	 True��6o   ._�56      �� $ DG_ScrollViewer��6+   $|�false��6D   ��57   "   �� 58   &   " ��66   .R�59   *   �  5:   .   �� 5;   2   $
��Auto �6C   �� 5<   2   $��* �6C   �� 5=   2   $
��Auto �6C    5?   .   �� 5@   2   $
��Auto �6@   �� 5A   2   $��* �6@   �� 5B   2   $
��Auto �6@   .+�5D   .   �� #��Z 65   $|�false��6d   ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5E   .   $! PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+# Z # Z  �� "  �� 5F   .   $! PART_ScrollContentPresenter��6E   #  z��6j   $��2��6�   $��1��6�   �� 5G   .   $! PART_VerticalScrollBar��68   $��2��6X   ## z" 6h   $$ Vertical=�6�   $��1��6�   #& z% 6  #y�z' 6M  ( 6�   �� *VerticalOffset+$) OneWay=� �� $* TemplatedParent=�6M  � 5H   .   $��1��63   $��2��6C    5I   2   �� 5J   6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5K   6   $��* �6G   .+�5M   2   �� $! PART_HorizontalScrollBar��6<   $��1��6^   ## z+ 6n   $$ 
Horizontal=�6�   #& z, 6  #y�z- 6H  ( 6�   �� *HorizontalOffset+$) OneWay=� �� $* TemplatedParent=�6H  5N   /   5O   +   5P   '   .��5R   "   �� #	 z	 61   5S      5T      5U      5W      . 5X      ]� 5Y      / 5Z      �� 5[      0 �@��
IsGrouping$
1 true��6:   �� 5\      "0 �@%�IsVirtualizingWhenGrouping$1 false��6\   ./�5^      ��  � ��$ false��6F   5_      5a      �� 5c   
   $2 	#FFABAdB3��68   �� 5d   
   " ��6'   .�5e      ��  � ��# � ��6+   �� 5f       � ��$ 1q�60   �� 5g       �@ TabNavigation$
 None=�6A   �� 5h       � ��$
 Left=�6;   �� 5i       �@�FocusVisualStyle 61   Z� �� 5j       �@J�	AllowDrop$
 true��6*   �� 5k       �@��PanningMode$ VerticalFirst=�69   �� 5l       �@��IsFlicksEnabled$ False��67   �� 5m       � �� 5o      �� 5p      " ��6&   .R�5q      �� $3 border��6!   #��z��61   #��z��6[   #��z��6�   $
	 True��6�   ._�5r      �� $ PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5s       5t      P� 5u       � {�$ false��6;   . �5v   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5w      5{      5}      . 5~      ]� 5      / 5�      �� 5�      +0 �@��#IsInactiveSelectionHighlightEnabled$
1 true��6S   �� 5�      0 �@��IsSelectionActive$1 false��6A   ./�5�      ��  �@��SelectionBrush# � /�67   5�      5�      5�      .��5�      � $��Center=�6   $��Center=�6&   $	��440��6C    5�   
   �� 5�      $	��100 �6   �� 5�      $	��43* �6   .+�5�   
   �� $��Buscar:��6   4 J� RenderTransformOrigin$4 3.073,1.612&�6"   
���   �$
��Left=�6Y   $	��Top=�6t   $��	83,16,0,0q�6�   $��20(�6�   $��36��6�   $��72��6�   ��6�   Z� 6�   �� 5�   
   $��183,13,165,45q�6   
���   �5 �� CornerRadius$5 10��6<   $��2q�6N   ._�5�      �� -   5        6 ��Name$6 
txtbuscado��5�   L   #���  6   $��0��6?   $��30,0,0,0q�6a   $��Center=�6t   $
��Left=�6�   $	��576��6�   $��20(�6�   
���   �$��34��6  $4 0.5,0.5&�6  $��7,0,0,0q�64  7 �� SelectionBrush7 6�   Z� ��6�   Z� .��6E  z�5�      V� 5�      .~�5�      �� 8 �� ScaleY$8 1Q�6)   �� 5�      �� 5�      T� 5�      5�      .��5�   +   ��5�      �� 5�      9 �� ImageSource$9 /Views/icono_lupa.png��6!   : j� Stretch$
: None=�5�      ; j� 
AlignmentX$
; Left=�5�      .��5�   &   5�      5�        5�   
   -   5        $ ��data_productos_agricultura��5�   =   #���   6   <   
IsReadOnly$
< True��5�      =   CanUserAddRows$= False��5�      >   CanUserDeleteRows$> False��5�      ?   AutoGenerateColumns$? False��5�      $��
22,11,11,0q�5�      $@   HorizontalScrollBarVisibility$
@ Auto=�5�      $	��294��66   $	��Top=�6C   $��1��6[   A   ColumnsA 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumnB   Header$B Código��6%   C   Width5  /System.Windows.Controls.DataGridLengthConverter$C * 6L   1	  +System.Windows.Controls.DataGridBoundColumnD 	  BindingD 65   �� *cd+6L     5�      $B Nombre��6%   $C * 6L   D 65   �� *nm+6L     5�      $B Cantidad��6%   $C * 6N   D 67   �� *ec+6N     5�      $B Persona��6%   $C * 6M   D 66   �� *pn+6M     5�      $B Estado��6%   $C * 6L   D 65   �� *es+6L     5�      $B 
Categoría��6%   $C * 6O   D 68   �� *cg+6O   5�      5�      5�      