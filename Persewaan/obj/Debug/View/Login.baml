   M S B A M L   `   `   `  ����D  @Persewaan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Persewaan.ViewPersewaan.View  5   	       Persewaan.View.Login   5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Persewaan.View     5   	      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5	       � Title$ Login��5   	   $	��400��6   $	��350��6$    � WindowStyle$
 None=�60    � WindowStartupLocation$ CenterScreen=�6C    � 
ResizeMode$ NoResize=�6h   .��5      � .+�5   
   �� -   5        $	��251��5      $	��Top=�6!   $��0,-9,0,0q�69   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF4486F9��6#   	 � Offset$	 0.402Q�65   � 5      $ White��6#   $	 1Q�61   5      5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H   
 �� RadiusY$
 10��6V    �� RadiusX$ 10��6c   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5       � 5!   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5"      �� $��Login to Account��6   $��
41,60,39,0q�6/   ���	#FF4486F9$��21(�6Z   $��
Montserrat)�6h   $��42��6�   $
��Bold"�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5#      $��Center=�6   $��42,86,44,40q�64   .+�5$      �� -   5         ��Name$ txtNama��5$      $��0,10,0,4q�6+   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��6=    % !MaterialDesignFloatingHintTextBox#��[ 6g   $��
Montserrat)�6�   $��13(�6�   ���	#FF2152A66�   G� 5%      -   5         G�Name$ pwdbox��5%      $
��0,10q�6.   $ Password��6<    ) %MaterialDesignFloatingHintPasswordBox#��[ 6f   $��
Montserrat)�6�   $��13(�6�   ���	#FF2152A66�   5&      5'      �� 5(   
   -   5         ��Name$ Tombol��5(      $	��158��6!   $��Center=�6-   $��Bottom=�6J   $��
96,0,96,64q�6e   $��	L O G I N��6y   ���	#FF4486F9
����������	#FF4486F9$��15q�6�   $��34��6�   $��
Montserrat)�6  $
��Bold"�6  $��15(�6/  �� 5)   
   $��Version 0.0.1��6   $��Center=�6)   $��Bottom=�6F   $��135,0,138,25q�6a   ���	#FF4486F9 � Cursor$
 Hand��6�   $��77��6�   $��
Montserrat)�6�   $��11(�6�   �� 5*   
   $��
0,-3,0,265q�6   $ 0.5,0.5&�6)   .+�5+      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Circle=�6&   $��Center=�64   $��Center=�6O   $��85,8,85,331q�6l   $	��136��6�   $	��180��6�   $ 0.5,0.5&�6�   ���	#FF4486F96�     5,      $ 
UserCircle=�6&   $��Center=�68   $��Center=�6S   $��97,-490,97,310q�6p   $	��119��6�   $	��156��6�   ��5-      �� 5.       �� Color$ White��6&   50      51      52      53      