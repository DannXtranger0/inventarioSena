   M S B A M L   `   `   `  ����E  Ainventario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:inventario
inventario  5   	       inventario.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:inventario     5   	     � Title$  Login��5   	   $	��522��6   $	��955��6$    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � 	Resources 5         CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value  EstiloTextbox ��Name J� SnapsToDevicePixels ��Name �� Triggers �� 
TargetName  TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBox.Static.Border1  TextBox.MouseOver.Border1  TextBox.Focus.Border1  ESTILOPASSWORD-  'System.Windows.Input.KeyboardNavigation ]� 
Conditions �� Property �� Value��%�	  &	        &	 z    &	 �    &	      &	 #    &	 F    &	 i    &	 �    &	 �    7  �� 5   
   " ��6*   .�5      ��  � ��
 �����6+   �� 5       � �� �	#FF45F9056+   �� 5       � �� �	#FF45f9056,   �� 5       � ��$ 2q�60   �� 5       � ��$
 10 5q�6(   �� 5       � ��$ Arial)�6+   �� 5       � ��$ 14(�6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5      #��z��5      $ 7��5      ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5!      	 5"      P� 5$      
 � ��$
 True��6/   . �5%      ��  � �� �	#FF05F11463   5&      5(      �� 5+   
   " ��60   .R�5,      �� $ border��6   #��z��6%   #��z��6O   #��z��6{   $
 True��6�   ._�5-      �� $ PART_ContentHost��6   $|�false��69   $��Hidden=�6K   $��Hidden=�6r   5.       5/      P� 50      
 � {�$ false��6/   . �51      �� $ border��60    �@J�Opacity$
 0.56Q�6D   52      55      �� 56   
   $ 	#FFABAdB3��68   �� 57   
   $ 	#FF7EB4EA��6;   �� 58   
   $ 	#FF569DE5��67   �� 59   
   $ 	#FFABAdB3��69   �� 5:   
   $ 	#FF7EB4EA��6<   �� 5;   
   $ 	#FF569DE5��68   �� 5>   
   " G�6'   .�5?      ��  �@G�PasswordChar$	 ●��6-   �� 5@       � ��# � ��6+   �� 5A       � ��# � ��6+   �� 5B       � ��$ 1q�60   �� 5C       �@ TabNavigation$
 None=�6A   �� 5D       � ��$
 Left=�6;   �� 5E       �@�FocusVisualStyle 61   Z� �� 5F       �@J�	AllowDrop$
 true��6*   �� 5G       �@��PanningMode$ VerticalFirst=�69   �� 5H       �@��IsFlicksEnabled$ False��67   �� 5I       � �� 5J      �� 5K      " G�6&   .R�5L      �� $ border��6!   #��z��61   $
 True��6[   ._�5M      �� $ PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5N       5O      P� 5P      
 � {�$ false��6;   . �5Q   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5R      P� 5T      
 �@J�IsKeyboardFocused$
 true��6C   . �5U   "   �� $ border��6@   8    � ��6T   5V      5X      5Z      	 5[      ]� 5\       5]      �� 5^      + �@G�#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 5_       �@G�IsSelectionActive$ false��6A   ./�5a      ��  �@G�SelectionBrush# � /�67   5b      5d      5g      .��5i      � $��Center=�6   $	��954��6(   
�������$	��506��6G   $��Center=�6T   .+�5r   
   �� $��/logoSena.png��6   $��327,20,368,353q�6'   �� 5u   
   ���	#FF00AF00$��2q�6)   $ 6��6=   $��250,224,248,236q�6N   5w      �� 5x   
   -   5         ��Name$ txtUsername��5x   =   #���  6   $��Center=�6S   $��260,219,257,233q�6u    � Cursor$ IBeam��6�   $��18(�6�   $��60��6�   $��436.2��6  $��1��6  $��30,0,0,0q�6%  ��6�   Z�  �� SelectionBrush 6�   Z�  �� SelectionTextBrush 6�   Z� .��68  ��5y      �� 5z       �� ImageSource$ /icono_iniciar_sesion.png��6    j� Stretch$
 None=�6E    j� 
AlignmentX$
 Left=�5{   !   5|      .��5}   "   5~      �� 5�   
   ���	#FF00AF00$��2q�6)   $ 6��6=   $��252,334,246,126q�6N   5�      �� 5�   
   -   5        $ contrasenia_txt��5�      #���  6+   $��Center=�6V   $��262,328,256,124q�6x   $ IBeam��6�   $	��436��6�   $��60��6�   $��30,0,0,0q�6�   $��18(�6   6�   Z�  6�   Z� ��6  Z� .��6)  ��5�      �� 5�      $
 None=�6   $
 Left=�5�      $ /icono_contrasena.png��6'   .��5�   "   5�      G� 5�   
   -   5         G�Name$ contrasenia_show��5�   ?   #���  6   $
��Left=�6Y   $��Center=�6u   $��263,328,0,0q�6�   $	��Top=�6�   $	��436��6�   $��60��6�   $��30,0,0,0q�6  $��18(�6>   G� SelectionBrush 6�   Z� ��6�   Z�  G� SelectionTextBrush 6   Z� ��5�      �� 5�      $
 None=�6   $
 Left=�5�   
   $ /icono_contrasena.png��6    j� TileMode$
 None=�6@     j� ViewboxUnits$  RelativeToBoundingBox=�6P   ! j� ViewportUnits$! RelativeToBoundingBox=�6u   5�      �� 5�   
   -   5        " ��Name$" btnIniciarSesion��5�      $��Iniciar Sesion��6+   $
 Hand��6D   $��22(�6R   #��[  6`   $��370,423,410,36q�6�   ���	#FF00AF006�   �� 5�   
   $��Usuario��6   $��25(�6"   $
��Left=�60   $��248,171,0,0q�6K   $	��Top=�6`   $	��100��6x   $��43��6�   �� 5�   
   $��Contraseña��6   $��25(�6%   $
��Left=�63   $��248,282,0,0q�6N   $	��Top=�6c   $��43��6{   $	��135��6�   �� 5�   
   -   5        # ��Name$# ver_contraseña��5�   Y   $��Ver contraseña��6q   $
��Left=�6�   $��729,349,0,0q�6�   $	��Top=�6�   $��17��6�   $	��115��6�   ���	#FF00AF006�   5�      5�      