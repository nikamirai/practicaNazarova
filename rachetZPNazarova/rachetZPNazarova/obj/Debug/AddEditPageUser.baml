   M S B A M L   `   `   `  ����K  GrachetZPNazarova, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:rachetZPNazarovarachetZPNazarova  5   	   &     rachetZPNazarova.AddEditPageUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:rachetZPNazarova     5   	     � Title$  AddEditPageUser��5   	   $	��600��6!   $	��500��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��0��6   $��3��6   .+�5      �� $��Resourse/fon.png��6   $��UniformToFill=�6.   6H   5      �� 5   
   $��Фамилия��6   $��1��6#   $��20(�60   $��Center=�6>   $��Center=�6[   6x   �� 5   
   $��20(�6/   $��1��6=   $��1��6M    �� TextAlignment$ Center=�6Z   $��Center=�6q   ��6   �� *SurnameUser+6�   �� 5   
   $��Имя��6   $��2��6   $��20(�6,   $��Center=�6:   $��Center=�6W   6t   �� 5   
   $��20(�6,   $��1��6:   $��2��6J   $ Center=�6W   $��Center=�6n   ��6   �� *
NameUser+6�   �� 5!   
   $��
Логин��6   $��3��6!   $��20(�6.   $��Center=�6<   $��Center=�6Y   6v   �� 5"   
   $��20(�6)   $��1��67   $��3��6G   $ Center=�6T   $��Center=�6k   ��6   �� *Login+6�   �� 5$   
   $��Пароль��6   $��4��6"   $��20(�6/   $��Center=�6=   $��Center=�6Z   6w   �� 5%   
   $��20(�6,   $��1��6:   $��4��6J   $ Center=�6W   $��Center=�6n   ��6   �� *
Password+6�   �� 5'   
   $��Тип��6   $��5��6   $��20(�6,   $��Center=�6:   $��Center=�6W   6t   �� 5(   
   $��20(�6.   $��1��6<   $��5��6L   $ Center=�6Y   $��Center=�6p   ��6   �� *
IDTypeUser+6�   �� 5*   
   -   5        $��6��5*      $��Добавить��6   $��20(�61   $	��120��6?   $��50��6K   
��� � �$
��Bold"�6j    � 	Resources 5+       �� 
TargetType �� Property �� Value��%c   '��       �� 5,      " ��6   .�5-      ��  �@��CornerRadius$ 5��65   6A   5.      5/      50      �� 51   
   -   5        $��6��51      $��1��6   $��Отмена��6.   $��20(�6?   $	��120��6M   $��50��6Y   
������� 52      ��%c   '��       �� 53      " ��6   .�54      ��  �@��CornerRadius$ 5��65   6A   55      56      57      � 58   
   $��11��6   $��3��6   .+�59      �� $��Resourse/fon.png��6   $��UniformToFill=�6.   6H   5:      5;      5<      