   M S B A M L   `   `   `  ����F  BAssignment5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment5Assignment5  5   	       Assignment5.GameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment5     5   	     � Title$  
GameWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z   ��5	      �� 5
   
    �� ImageSource$ /road_wallpaper.jpg��6    j� Stretch$ UniformToFill=�67   .��5      � .+�5   
   �� -   5         ��Name$ game_type_label��5      $��Default��6)   $
��Left=�6;   $��	10,10,0,0q�6V   $	��Top=�6i   $��32(�6�   $��Cooper Black)�6�   �� 5   
   -   5         ��Name$ ready_button��5      $��
I'm Ready!��6'   $��Center=�6<   $��0,22,0,0q�6Y   $	��Top=�6k   $��32(�6�   ��5      �� 5      $ /sponge_not_cheese.jpg��6   $ UniformToFill=�6B   5      �� 5   
   -   5        $ countdown_label��5      $�� ��6)   $��Center=�64   $��0,91,0,0q�6Q   $	��Top=�6c    J� RenderTransformOrigin$ -0.093,1.853&�6{   $��64(�6�   $��Cooper Black)�6�   �� 5   
   -   5        $ second_number_label��5      $�� ��6-   $��Center=�68   $	��Top=�6U   $��	0,134,0,0q�6m   $��Cooper Black)�6�   $��64(�6�   �� 5   
   -   5        $ first_number_label��5      $�� ��6,   $
��Left=�67   $	��Top=�6R   $��163,134,0,0q�6j   $��Cooper Black)�6   $��64(�6�   �� 5   
   -   5        $ operator_label��5      $�� ��6(   $
��Left=�63   $	��Top=�6N   $��269,138,0,0q�6f   $��Cooper Black)�6{   $��64(�6�   �� 5   
   -   5        $ equality_label��5      $�� ��6(   $
��Left=�63   $	��Top=�6N   $��458,134,0,0q�6f   $��Cooper Black)�6{   $��64(�6�   �� 5   
   -   5         ��Name$ 
answer_box��5      $
��Left=�6&   $��536,142,0,0q�6A   $�� ��6V   	 �� TextWrapping$
	 Wrap=�6^   $	��Top=�6r   $��99��6�   $��64(�6�   $��Cooper Black)�6�   
 �� TextAlignment$
 Center=�6�    �� 	MaxLength$ 2��6�   $y�Hidden=�6  �� 5   
   -	   5        $ timer_label��5      $��Time: 0 seconds��6%   $��Center=�6?   $��	0,364,0,0q�6\   $	��Top=�6o   $��32(�6�   $��Cooper Black)�6�   �� 5   
   $'��!Press ENTER to submit your answer��6   $��Center=�6<   $��0,65,0,0q�6Y   $	��Top=�6k   �� 5   
   -
   5        $ feedback_label��5      $�� ��6(   $��Center=�63   $��	0,239,0,0q�6P   $	��Top=�6c   $��32(�6{   $��Cooper Black)�6�   �� 5   
   -   5        $ quit_button��5      $
��Quit��6&   $
��Left=�65   $��
11,351,0,0q�6P   $	��Top=�6d   $��32(�6|   ��5      �� 5      $ /sponge_not_cheese.jpg��6   $ UniformToFill=�6B   5       �� 5!   
   -   5        $ submit_button��5!      $��Submit��6(   $
��Left=�69   $��662,156,0,0q�6T   $	��Top=�6i   $��32(�6�   $y�Hidden=�6�   ��5"      �� 5#      $ /sponge_not_cheese.jpg��6   $ UniformToFill=�6B   5%      5'      5(      