   M S B A M L   `   `   `  ����F  BAssignment5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment5Assignment5  5   	       Assignment5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment5     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z   ��5	      �� 5
   
    �� ImageSource$ /general_wallpaper.jpg��6    j� Stretch$ UniformToFill=�6:   .��5      � .+�5   
   �� $��Welcome to The Game!��6   $��Center=�6/   $��0,10,0,0q�6L   $	��Top=�6^   $��Broadway)�6v   $��24(�6�   �� 5   
   $8��2Please enter your name, age, and choose a gamemode��6   $��Center=�6M   $��0,47,0,0q�6j   $	��Top=�6|   $��18(�6�   �� 5   
   -   5         ��Name$ 
name_input��5      $��Center=�6&   $��	0,109,0,0q�6C    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��168��6�   $��16(�6�    � 
InputScope$ PersonalFullName��6�    �� 	MaxLength$ 29��6�   6�   �� 5   
   -   5        $ 	age_input��5      $��Center=�6%   $��	0,167,0,0q�6B   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   $��16(�6�   $ Number��6�   $ 2��6�   6�   �� 5   
   $��Name:��6   $
��Left=�6    $��255,105,0,0q�6;   $	��Top=�6P   $��16(�6h   ��6v   Z� �� 5   
   $
��Age:��6   $
��Left=�6   $��293,163,0,0q�6:   $	��Top=�6O   $��16(�6g   	� 5   
   -   5        	 	�Name$	 	add_radio��5      $	��Add��6)   $
��Left=�67   $��307,253,0,0q�6R   $	��Top=�6g   $��16(�6   
 d� 	IsChecked$

 TrueY�6�   	� 5   
   -   5        $	 divide_radio��5      $��Divide��6,   $
��Left=�6=   $��	406,0,0,0q�6X   $��Center=�6k   $��16(�6�   	� 5   
   -   5        $	 multiply_radio��5      $��Multiply��6.   $
��Left=�6A   $��	307,0,0,0q�6\   $��Center=�6o   $��16(�6�   	� 5   
   -   5        $	 subtract_radio��5      $��Subtract��6.   $
��Left=�6A   $��406,253,0,0q�6\   $	��Top=�6q   $��16(�6�   �� 5   
   $��
Game Modes��6   $��277,217,277,236q�6'   �� 5   
   -   5         ��Name$ start_button��5      $��Start Game!��6'   $��Center=�6=   $��	0,372,0,0q�6Z   $	��Top=�6m   $��32(�6�   ��5      �� 5      $ UniformToFill=�6   $ /sponge_not_cheese.jpg��65   5      �� 5   
   -   5         ��Name$ 
name_label��5      $�� ��6$   $��Center=�6/   $��0,79,0,0q�6L   $	��Top=�6^   $��19(�6�   
���  ����6v   Z� 6�   �� 5   
   -	   5        $ 	age_label��5      $�� ��6#   $��Center=�6.   $��	0,137,0,0q�6K   $	��Top=�6^   $��19(�6�   
���  ����6v   Z� 6�   5       5!      