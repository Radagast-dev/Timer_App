   M S B A M L   `   `   `  ����D  @Timer_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Timer_App	Timer_App  5   	       Timer_App.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Timer_App     5   	     � Title$  Timer��5   	   $	��275��6   $	��400��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U   
������� � Icon$L FC:\Users\Radagast\source\repos\Timer_App.git\Ressources\bttf2_icon.ico��6}   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��0��6   $
��Left=�6+   $��	160,0,0,0q�6F   $��Center=�6Y   $��24��6t   $��40��6�   
�������6�   �� 5   
   -   5         ��Name$ startButton��5      $��Start��6&   $
��Left=�66   $��
75,194,0,0q�6Q   $	��Top=�6e   $��46��6}   6�   �� 5   
   -   5        $ 
stopButton��5      $
��Stop��6%   $
��Left=�64   $��253,194,0,0q�6O   $	��Top=�6d   $��46��6|   6�   �� 5   
   -   5        $ secLabel��5      $��Seconds��6"   $
��Left=�64   $��	205,0,0,0q�6O   $��Center=�6b   $��24��6}   �� 5   
   -   5        $ inputSecLabel��5      $��Input Seconds��6'   $
��Left=�6?   $��204,152,0,0q�6Z   $	��Top=�6o   $��28��6�   �� 5   
   -   5        $ setInput��5      $��	Set input��6#   $
��Left=�67   $��160,194,0,0q�6R   $	��Top=�6g   6   �� 5   
   -   5         ��Name$ inputBox��5      $
��Left=�6$   $��160,152,0,0q�6?   $�� ��6T    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $��39��6�   $��22��6�   
�������6�   �� 5   
   -   5         ��Name$ countUp��5      $��Count up��6$   $
��Left=�67   $��63,0,0,0q�6R   $��Center=�6d   6   �� 5   
   -	   5        $ 	countDown��5      $��
Count down��6&   $
��Left=�6;   $��
63,156,0,0q�6V   $	��Top=�6j   $��18��6�   r� 5   
   -
   5        	 r�Name$	 bttf_time_machine_gif��5      $��120,6,148,145q�66   
 r� Stretch$

 Fill=�6M    r� Source$S MC:\Users\Radagast\source\repos\Timer_App.git\Ressources\bttf_time_machine.gif?�6\    r� LoadedBehavior$
 Play=�6�    r� UnloadedBehavior$ Manual=�6�   6�   r� 5   
   -   5        $	 bttf_theme_song��5      $Q KC:\Users\Radagast\source\repos\Timer_App.git\Ressources\bttf_theme_song.wav?�60    r� Volume$
 0.01Q�6�   $
 Play=�6�   $ Manual=�6�   6�   5      5      