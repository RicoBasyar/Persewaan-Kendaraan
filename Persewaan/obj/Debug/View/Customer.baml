   M S B A M L   `   `   `  ����D  @Persewaan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Persewaan.ViewPersewaan.View  5          Persewaan.View.Customer   5      S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Persewaan.View     5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      ���	#FF424242  MaterialDesignFont#���  5	      .��5      � $	��600��6   $��
32,0,-32,0q�6   .+�5   
   �� $��Customer��6   $��28,24,94,528q�6$   $��
Montserrat)�6:   $
��Bold"�6R   $��35(�6d   
�������6r   �� 5   
   $	��600��6   $
��1000��6"   .+�5      �� -   5         ��Name$ txtNIK��5       % !MaterialDesignFloatingHintTextBox#��[ 6&   $��34,84,715,10q�6a   $��18(�6w   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 NIK��6�   
�������6�   �� 5      -   5        $ 
txtNamaCus��5      #��[ 6*   $��34,20,715,10q�6e   $��18(�6{   $
 Nama��6�   
�������6�   �� 5      -   5        $ 
txtno_telp��5      #��[ 6*   $��362,-129,338,83q�6e   $��18(�6~   $ Nomor Telepone��6�   
�������6�   �� 5      -   5        $ 	txtAlamat��5      #��[ 6)   $��362,-56,338,10q�6d   $��18(�6|   $ Alamat��6�   
�������6�   �� 5      $��	-32,0,0,0q�6   .+�5      �� -   5         ��Name$
 Save��5      $	��150��6'   $
��Save��63   $��41,34,581,0q�6B   $��0q�6W   $	��Top=�6c   6{   �� 5      -   5        $ Delete��5      $	��150��6)   $��Delete��65   $��695,-31,155,0q�6F   $��0q�6]   $	��Top=�6i   ���	#FF424242
�������6�   �� 5      -   5        $
 Edit��5      $	��150��6'   $
��Edit��63   $��0q�6B   $��338,-31,312,0q�6N   $	��Top=�6e   6}   �� 5      $	��313��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridCustomer��5   w   ��. $��Visible=�6D   DataGridCustomer��$��68,20,71,-22q�6�   $	��279��6�   ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 NIK��6I      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6V   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *nik+6V     5       $
 Nama��6S   $	 200 6a   	 61   �� *nama_customer+6a     5!      $ 
No Telepon��6M   $	 100 6a   	 61   �� *	no_telp+6a     5"      $ Alamat��6L   $	 250 6\   	 61   �� *alamat+6\     5#      $ ID ADMIN��6N   $	 100 6`   	 61   �� *
id_admin+6`   5%      5&      5'      5(      5)      5*      