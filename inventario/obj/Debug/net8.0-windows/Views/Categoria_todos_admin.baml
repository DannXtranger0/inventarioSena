   M S B A M L   `   `   `  ����E  Ainventario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:inventario.Viewsinventario.Views  5      ,    &inventario.Views.Categoria_todos_admin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:inventario.Views     5        N� Title$  Categoria_todos_admin��5	       � 	Resources 5         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  estiloTextBox �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name J� SnapsToDevicePixels	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  FocusVisual �� StrokeDashArray  Button.MouseOver.Background  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  botonAgregarEstilo �� CornerRadius ��Name=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%h  &	        &	 #     &	 F     &	 i     7   &	 �    &	 o    &	 �    &	 �    &	 �    &		 �    &	
     &	 A    7  7  7  7  7  7 	 7 
 '  �
    �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6&   .�5      ��  � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop$
 true��6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled$ False��67   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 True��6�   ._�5      �� $	 PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5      
 5       P� 5!       � {�$ false��6;   . �5"   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5#      5'      5)       5*      ]� 5+       5,      �� 5-      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 5.       �@��IsSelectionActive$ false��6A   ./�50      ��  �@��SelectionBrush# � /�67   51      53      �� 54   
   .�55      ��  � �� 56      �� 57      .R�58      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   59      5;      5=      �� 5>   
   $ 	#FF56E34A��6>   �� 5?   
   $ 	#FFC4E5F6��6<   �� 5@   
   $ 	#FF2C628B��68   �� 5A   
   $ 	#FFF4F4F4��6=   �� 5B   
   $ 	#FFADB2B5��69   �� 5C   
   $ 	#FF838383��6=   �� 5D   
   " ��6+   .�5E      ��  �@�FocusVisualStyle8   61   �� 5F       � ��# � ��6+   �� 5G       � ��$ 1q�60   �� 5H       � ��$ Center=�6;   �� 5I       � ��$ Center=�69   �� 5J       � ��$ 1q�6(   �� 5K       � �� 5L      �� 5M      " ��6&   .R�5N      �� $ border��6!   $ 8��61   #��z��6B   #��z��6l   #��z��6�   $
 true��6�   ._�5O      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5P      
 5Q      P� 5R       �@��IsDefaulted$
 true��6=   . �5S   "   �� $ border��6@   # � ��6T    � ��5T      P� 5U       �@J�IsMouseOver$
 true��6=   . �5V   "   �� $ border��6?   8   � ��6S   5W      P� 5X       � ��$
 true��6;   . �5Y   "   �� $ border��6?   8   � ��6S   �� 5Z   "   $ border��6@   8   � ��6T   5[      P� 5\       � {�$ false��6;   . �5]   "   �� $ border��6?   8   � ��6S   �� 5^   "   $ border��6@   8   � ��6T   �� 5_   "   $ contentPresenter��6K   8   � ��6i   5`      5b      5d      5g      �� 5h   
   "  6   .�5i      ��  � �� �	#FF10CD006+   �� 5j       � ��
 �   �6+   �� 5k       � ��$
 Bold"�6+   �� 5l       � ��$ Center=�6;   �� 5m       � ��$ 10q�6(   5n      5o      .��5q      � $��-2,0,2,0q�6    � RowDefinitions 5s   
   �� 5t      $
��Auto �6   �� 5u      $	��97* �6   �� 5v      $
��281* �6   .+�5z   
   � $��0��6   $��10,10,10,10q�6   $��2��61    � ColumnDefinitions 5{      �� 5|      $
��auto �6#   �� 5}      $	��13* �6#   �� 5~      $
��282* �6#    5�      �� 5�      $
��Auto �6    .+�5�      �� $��2��6   $��0,0,52,0q�6(   �� 5�      $��2��6   $��0��6$   $��Buscar:��61   $��33,1,1036,9q�6C    J� RenderTransformOrigin$ 3.073,1.612&�6X   �� 5�      
���   �$��2q�6)   $ 8��6=   $��35,-4,442,0q�6N   $��2��6c   ._�5�      �� -   5         ��Name$ 
txtbuscado��5�   `   #���  6   $��2��6C   $��0��6S   $��4,1,8,1q�6t   $��30,0,0,0q�6�   $��Center=�6�   $��20(�6
  ��6�   Z�  �� SelectionBrush 6�   Z�  �� SelectionTextBrush 6�   Z� .��6=  ��5�      �� 5�       �� ImageSource$ /Views/icono_lupa.png��6%    j� Stretch$
 None=�5�   !    j� 
AlignmentX$
 Left=�5�   !   .��5�   *   5�      5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -   5        $��dataproductos��5�         
IsReadOnly$
 True��5�         CanUserAddRows$ False��5�          CanUserDeleteRows$  False��5�      !   AutoGenerateColumns$! False��5�      $��87,62,116,10q�5�      $"   HorizontalScrollBarVisibility$
" Auto=�5�      $��1��5�      $��2��6   #   Columns# 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn$   Header$$ Código��6%   %   Width5  /System.Windows.Controls.DataGridLengthConverter$% * 6L   1  +System.Windows.Controls.DataGridBoundColumn&   Binding& 65   �� *cd+6L     5�      $$ Nombre��6%   $% * 6L   & 65   �� *nm+6L     5�      $$ Cantidad��6%   $% * 6N   & 67   �� *ec+6N     5�      $$ Persona��6%   $% * 6M   & 66   �� *pn+6M     5�      $$ Estado��6%   $% * 6L   & 65   �� *es+6L     5�      $$ 
Categoría��6%   $% * 6O   & 68   �� *cg+6O   4  .System.Windows.Controls.DataGridTemplateColumn  5�      $$ Acciones��6)   '   CellTemplate' 5�      �� 5�      .R�5�      �� ( �� Orientation$( 
Horizontal=�6)   .+�5�   "   �� ) ��Name$) btneliminar��6)   -   5        $��5q�5�   |   ��6@   �� *id+.��5�   &   �� $��16��6,   $��/Views/eliminar.png��67   $��0,0,5,0q�6T   $��Center=�6e   $��Center=�6�   6�   5�   #   �� 5�   "   $��	btneditar��6*   -   5        $��5q�5�   ;   $��Stretch=�6~   $��Stretch=�6�   ��6F   �� *id+.��5�   &   �� $��16��6,   $��/Views/editar.png��67   $��0,0,5,0q�6R   6e   5�   #   5�      5�      5�      5�      �� 5�   
   -   5        $) 
btnagregar��5�   >   #���  6   $
��Left=�6R   $��	507,0,0,0q�6m   $��Center=�6�   $	��246��6�   $��47��6�   ���	#FF10CD00
�������$��16(�6�   ��6  Z� .��5�      �  5�      �� 5�      $��40 �6'   �� 5�      $��* �6'   .+�5�      �� $��/Views/icono_agregrar.png��6   $��0��6;   $
��Left=�6K   $��-5,0,0,0q�6f   $��27��6x   $��Center=�6�   $��27��6�   �� 5�      $��Agregar nuevo producto��6   $��2��6:   $��	32,0,-8,0q�6N   $��Center=�6a   5�      5�      5�      5�      