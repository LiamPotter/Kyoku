   M S B A M L   `   `   `  ����K  GKyokuMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KyokuMusicPlayerKyokuMusicPlayer  5   	        KyokuMusicPlayer.Greetings   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:KyokuMusicPlayer     5   	   -   5          �Name$  Greeting_Window��5   	    � Title$ 	Greetings��5   	   $	��450��6   $	��800��6(   $	��750��64   $	��425��6C    � 	Resources 5	         MainTextColor �� Color��%-   &	        �� 5
   
   $ 	#FFF1F1F1��60   5      ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ 	#FF333340��6   � 5      $ 	#FF24242C��6    � Offset$ 1Q�6-   5      .��5      � .+�5   
   �� $��Center=�6   $��0,50,0,0q�61   $
��Wrap=�6C   $P��JHi there! Before we continue, please select the color theme you like best.��6W   $	��Top=�6�   #���   6�   $��20(�6�   	� 5   
   -   5        	 	�Name$	 Light_Theme_Button��5      $��Light��62   $��Center=�6B   $��-300,200,0,0q�6_   $	��Top=�6u   #���   6�   $��18(�6�   $��60��6�   $��25��6�   #���   6  	� 5   
   -   5        $	 Dark_Theme_Button��5      $
��Dark��61   $��Center=�6@   $��300,200,0,0q�6]   $	��Top=�6r   #���   6�   $��18(�6�   $��60��6�   $��25��6�   �� 5   
   -   5        
 ��Name$
 Continue_Button��5      $��Continue��6*   $��Center=�6=   $��311,345,311,45q�6Z   $��Center=�6r   $	��170��6�   $��18(�6�   $��30��6�   5      5      