   M S B A M L   `   `   `  ����H  DProyectoFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProyectoFinalProyectoFinal  5   	       ProyectoFinal.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProyectoFinal     5   	   -   5          � Title$  Organizador de Libros��5   	   $	��450��6'   $	��800��64   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��16* �6   �� 5      $��4* �6   �� 5      $	��16* �6   �� 5      $��4* �6   �� 5      $	��16* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $	��20* �6   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   .+�5    
   �� -   5         ��Name$ laTitulo��5       $$��Libros por Editoriales y Autor��6"   $��0��6K   $��Center=�6[   $��7��6x   $��0��6�   $��20(�6�   
�������$��Center=�6�   �� 5!   
   -   5        $ laConsultaModifica��5!      $��Consulta / Modifica��6,   $��0��6J   $��Center=�6Z   $��7��6w   $��2��6�   $��16(�6�   
�������$��Center=�6�   �� 5"   
   -   5         ��Name$ btLibros��5"      $��Libros��6#   $��1��64   $��Stretch=�6D   $��4��6b   $��16(�6o   $��Stretch=�6}   6�   �� 5#   
   -   5        $ btLibrosEditorial��5#      $��Libros/Editorial��6,   $��1��6G   $��Stretch=�6W   $��6��6u   $��16(�6�   $��Stretch=�6�   6�   �� 5$   
   -   5        $ btEditoriales��5$      $��Editoriales��6(   $��3��6>   $��Stretch=�6N   $��4��6l   $��16(�6y   $��Stretch=�6�   6�   �� 5%   
   -   5        $ btSalir��5%      $��Salir��6"   $��3��62   $��Stretch=�6B   $��8��6`   $��16(�6m   $��Stretch=�6{   6�   �� 5&   
   -   5        $ 	btAutores��5&      $��Autores��6$   $��5��66   $��Stretch=�6F   $��4��6d   $��16(�6q   $��Stretch=�6   6�   �� 5'   
   -	   5        $ btLibrosAutores��5'      $��Libros/Autor��6*   $��5��6A   $��Stretch=�6Q   $��6��6o   $��16(�6|   $��Stretch=�6�   6�   �� 5(   
   -
   5        $ 
btAcercaDe��5(      $��	Acerca de��6%   $��5��69   $��Stretch=�6I   $��8��6g   $��16(�6t   $��Stretch=�6�   6�   �� 5)   
   -   5        $��
imgMostrar��5)      $��3��6"   $��1��62   $��
libros.jpg��6?   5*      5+      