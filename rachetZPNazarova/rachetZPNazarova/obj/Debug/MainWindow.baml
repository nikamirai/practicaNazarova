   M S B A M L   `   `   `  ����K  GrachetZPNazarova, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:rachetZPNazarovarachetZPNazarova  5   	   !    rachetZPNazarova.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:rachetZPNazarova     5   	     � Title$   Вход в систему��5   	   $	��500��6    $	��500��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��0��6   $��2��6   .+�5      �� $��Resourse/fon.png��6   $��UniformToFill=�6.   6H   5      �� 5   
   $��Введите логин��6   $��1��6)   $��2��66   $��20(�6J   $��Center=�6X   $��Center=�6u   6�   �� 5   
   -   5         ��Name$ tbLogin��5       $��20(�6   $��2��61   $��2��6>   $	��300��6R   $��40��6^   6l   �� 5   
   $!��Введите пароль��6   $��3��6*   $��2��67   $��20(�6K   $��Center=�6Y   $��Center=�6v   6�   �� 5   
   -   5        $ 
tbPassword��5       $��20(�6   $��4��64   $��2��6A   $	��300��6U   $��40��6a   6o   �� 5    
   -   5        
�������$��5��5    D   $��2��6Q   $��
Войти��6e   
���   �$
��Bold"�6�   $��20(�6�   $	��120��6�   $��40��6�    � 	Resources 5!       �� 
TargetType �� Property �� Value��%d   '��       �� 5"      " ��6   .�5#      ��  �@��CornerRadius$ 10��65   6B   5$      5%      5&      �� 5'   
   $��6��6   $��2��6!   $��Center=�65   $��20(�6R   $��Center=�6`   $��или��6{   6�   �� 5(   
   -   5        
��� � �$��7��5(   C   $��2��6P   $*��$Зарегистрироваться��6d   
�������$
��Bold"�6�   $��20(�6�   $	��220��6�   $��40��6�   $��Center=�6�    5)      ��%d   '��       �� 5*      " ��6   .�5+      ��  �@��CornerRadius$ 10��65   6B   5,      5-      5.      � 5/   
   $��8��6   $��2��6   .+�50      �� $��Resourse/fon.png��6   $��UniformToFill=�6.   6H   51      52      53      