   M S B A M L   `   `   `  ����D  @Persewaan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Persewaan.ViewPersewaan.View  5          Persewaan.View.Kendaraan   5      S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Persewaan.View     5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      ���	#FF424242  MaterialDesignFont#���  5	      .��5      � $
��1000��6   $	��600��6   $��45,0,0,0q�6%   .+�5   
   �� $��Pilih Jenis Kendaraan��6   $��34,89,760,482q�61   
�������$��
Montserrat)�6[   $��17(�6s   �� 5   
   $��	0,-55,0,0q�6   .+�5      �� -   5         ��Name$ 
txtnomesin��5   Q    % !MaterialDesignFloatingHintTextBox#��[ 6   $��372,81,212,10q�6e   $��18(�6|   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ No Mesin��6�   
�������6�   �� 5      -   5        $ txtnorangka��5   Q   #��[ 6   $��372,0,212,10q�6f   $��18(�6|   $ 	No Rangka��6�   
�������6�   �� 5      -   5        $ txtnopol��5   Q   #��[ 6   $��372,0,212,10q�6c   $��18(�6y   $ 	No Polisi��6�   
�������6�   �� 5      $��31,-62,815,0q�6   $	��116��6/   .+�5      	� -   5         	�Name$ rdbmotor��5       d� 	IsChecked$
 TrueY�60    	� 	GroupName$ 	Kendaraan��6A   $��23(�6W   
�������$��1,0,0,0q�6x   $��0q�6�   6�   �� 5      $��20(�6   $��Motor��6&   
�������$��	0,-24,0,0q�6I   $��Right=�6\   $	��126��6x   	� 5      -   5        $ rdbmobil��5      $ 	Kendaraan��60   $��23(�6F   
�������$��1,10,0,0q�6g   $��0q�6y   6�   �� 5      $��20(�6   $��Mobil��6&   
�������$��
28,-24,0,0q�6I   5      �� 5      -   5        $
 merk��5   Q   #��[ 6   $��372,-55,212,10q�6_   $��18(�6w   $
 Merk��6�   
�������6�   �� 5      -   5        $ harga_perhari��5   Q   #��[ 6   $��372,-2,212,10q�6h   $��18(�6   $ Harga Perhari (Rp)��6�   
�������6�   �� 5      .+�5       �� -   5         ��Name$
 Save��5       $	��150��6'   $
��Save��63   $��41,18,581,0q�6B   $��0q�6W   $	��Top=�6c   6{   �� 5!      -	   5        $
 Edit��5!      $	��150��6'   $
��Edit��63   $��0q�6B   $��338,-31,312,0q�6N   $	��Top=�6e   6}   �� 5"      -
   5        $ Delete��5"      $	��150��6)   $��Delete��65   $��595,-31,55,0q�6F   $��0q�6\   $	��Top=�6h   ���	#FF424242
�������6�   5#      �� 5%      $	��226��6   $��	24,0,54,0q�6&   .+�5&      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridKendaraan��5&   s   ��. $��Visible=�6@   DataGridCustomer��$��13,25,27,-45q�6�   $	��202��6�   ��6�   �� 	   Columns	 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn
   Header$
 No Mesin��6J      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *
no_mesin+6\     5)      $
 	No Rangka��6K   $	 200 6^    6-   �� *	no_rangka+6^     5*      $
 	No Polisi��6H   $	 100 6[    6-   �� *no_pol+6[     5+      $
 Jenis Kendaraan��6Q   $	 250 6j    6-   �� *jenis_kendaraan+6j     5,      $
 Merk Kendaraan��6P   $	 100 6h    6-   �� *merk_kendaraan+6h     5-      $
 Harga Perhari��6O   $	 100 6f    6-   �� *harga_perhari+6f     5.      $
 Id Admin��6J   $	 100 6\    6-   �� *
id_admin+6\   50      52      53      �� 54   
   $��	Kendaraan��6   $��28,24,630,528q�6%   $��
Montserrat)�6<   $
��Bold"�6T   $��35(�6f   
�������6t   55      56      