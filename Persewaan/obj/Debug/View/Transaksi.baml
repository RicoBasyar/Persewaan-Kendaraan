   M S B A M L   `   `   `  ����D  @Persewaan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Persewaan.ViewPersewaan.View  5          Persewaan.View.Transaksi   5      S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Persewaan.View     5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      ���	#FF424242  MaterialDesignFont#���  5	      .��5      � $	��600��6   $
��1000��6   $��45,0,0,0q�6%   .+�5   
   �� .+�5      �� .+�5      �� -   5         ��Name$ 	txtidsewa��5   U    % !MaterialDesignFloatingHintTextBox#��[ 6   $��53,50,404,10q�6h   $��23(�6~   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ No Transaksi��6�   
�������6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dtpTanggalambil��5         Text$ Tanggal Ambil��66   $ Tanggal Ambil��6K   
�������$��23(�6�   $��	53,15,0,0q�6�   $	��309��6�   $
��Left=�6�     5      -   5        $ dtpTanggalpinjam��5      $ Tanggal Transaksi��67   $ Tanggal Kembali��6P   
�������$��23(�6�   $��	53,15,0,0q�6�   $	��309��6�   $
��Left=�6�   �� 5      -   5        $ txtnik��5   U   #��[ 6   $��53,15,404,10q�6e   $��23(�6{   $	 NIK��6�   
�������6�   �� 5      -   5        $ 
txtnomesin��5   U   #��[ 6   $��53,15,404,10q�6i   $��23(�6   $ No Pol��6�   
�������6�   5      �� 5      .+�5      �� -   5         ��Name$
 Save��5      $	��150��6'   $
��Save��63   $��41,18,581,0q�6B   $��0q�6W   $	��Top=�6c   6{   �� 5      -   5        $
 Edit��5      $	��150��6'   $
��Edit��63   $��0q�6B   $��338,-31,312,0q�6N   $	��Top=�6e   6}   �� 5      -   5        $ Delete��5      $	��150��6)   $��Delete��65   $��595,-31,55,0q�6F   $��0q�6\   $	��Top=�6h   ���	#FF424242
�������6�   5      5      �� 5    
   $	��200��6   $��	24,0,54,0q�6"   $��Bottom=�65   .+�5!      &   System.Windows.Controls.DataGrid  -	   5          Name$ DataGridTransaksi��5!   o   ��. $��Visible=�6<   DataGridCustomer��$��13,25,27,-45q�6�   $	��166��6�   ��6�   ��    Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Kode Transaksi��6J   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *id_transaksi+6b     5$      $	 ID admin��6F   $	
 200 6X    6)   �� *
id_admin+6X     5%      $	 	No Polisi��6D   $	
 100 6W    6)   �� *no_pol+6W     5&      $	 Tanggal Ambil��6G   $	
 250 6^    6)   �� *	tgl_ambil+6^     5'      $	 Tanggal Kembali��6I   $	
 100 6b    6)   �� *tgl_kembali+6b     5(      $		 NIK��6A   $	
 100 6N    6)   �� *nik+6N   5*      5+      5,      5-      