   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��logo.png��6   $	��100��6"   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5        $��IsLead��5   5   $��Все лиды��6   $��5q�6*   65   �� 5      -   5        $��IsActive��5   =   $��Обновить��6   6=   5      &   System.Windows.Controls.DataGrid  5   
   $��2��6      AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly . ��5      �� *Leads+ �� SelectedItem 5      �� *Lead+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Пользователь��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6_   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   ��  �� Path$ 
User.Login�6_     5      $ Телефон��6%   $	 * 6U   
 66   �� $ Phone�6U     5      $ Навыки��6%   $	 * 6]   
 65   �� $ SellTechniques�6]     5      $ Дата создания��6%   $	 * 6d   
 6<   �� $ CreateDateTime�6d   4  .System.Windows.Controls.DataGridCheckBoxColumn  5       $ Активность��6)   $	 * 6_   
 6=   �� $ IsActive�6_   5"      �� 5#   
   $��3��6   $ 
Horizontal=�6"   .+�5$      �� -   5        $��Информация��5$      
�������
����  �$
��Left=�6O   $��5q�6j   6u   �� 5%      -   5        $��Создать��5%      
�������
��� � �$
��Left=�6M   $��5q�6   �� 5&      -   5        $��Удалить��5&      
�������
���  ��$
��Left=�6K   $��5q�6f   6q   5'      5(      5)      