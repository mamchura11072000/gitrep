   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Вход��5
   	   $	��450��6   $��309.343��6#   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��logo.png��6   $	��100��6"   $��0��6.   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��1��6I   .+�5      �� $��
Логин��6   $��20(�6%   $��5q�63   �� 5      -   5        $	��TX1��5      $	��235��5      $��20(�5      5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��2��6I   .+�5      �� $��Пароль��6   $��20(�6&   $��5q�64   G� 5      -   5        $	��TX2��5      $	��223��5      $��20(�6&   5      5      �� 5   
   -   5        $��3��5      $��
Войти��6   
�������
��� � �$��5q�6T   $��20(�6_   6m   5       5!      