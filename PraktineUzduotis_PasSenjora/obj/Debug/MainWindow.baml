   M S B A M L   `   `   `  ����E  APasSenjora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PraktineUzduotis_PasSenjoraPraktineUzduotis_PasSenjora  5   	   ,    &PraktineUzduotis_PasSenjora.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PraktineUzduotis_PasSenjora     5   	     � Title$  Pas Senjora��5   	   $	��350��6   $	��525��6*    � 	Resources 5	      5   /PraktineUzduotis_PasSenjora.OrderPriceConverter   OPConverter2   ,PraktineUzduotis_PasSenjora.TabNameConverter  TNConverter3   -PraktineUzduotis_PasSenjora.TabPriceConverter  TPConverter5   /PraktineUzduotis_PasSenjora.OrderStateConverter  OSConverter3   -PraktineUzduotis_PasSenjora.OrderTabConverter  OTConverter��%�   &	        &	      &	 &     &	 9     &	 L       5
   
   6$     5   
   6!     5   
   6"     5   
   6$     5   
   6"   5      .��5      � $��10q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	DG_Orders��5         AutoGenerateColumns .  $��0,0,0,34q�6@      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Stalas��6%      Width5	  /System.Windows.Controls.DataGridLengthConverter$
 Auto	 6Q   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 65   �� *	TableID+6Q     5      $ Kaina��6%   $
 Auto	 6o    64   ��  �� 	Converter# [  6o     5      $ Statusas��6%   $ *	 6r    67   �� # [ 6r   	   RowDetailsTemplate	 5      �� 5      .R�5      � $��0q�6   $��Disabled=�6&   $��Stretch=�6Z   .+�5          .  $
��Left=�6~   $��0q�6�    . ��6?   �� # [  5!        5"   "   $ 	Produktas��65   $
 Auto	 6�   
   CanUserResize
 .   6H   �� # [ 6�     5#   "   $ Vieneto kaina��65   $
 Auto	 6�   
 .   6L   �� # [ 6�     5$   "   $ Kiekis��65   $
 Auto	 6c   
 .   6E   �� *	FoodCount+6p   5'      5)      5*      5-      �� 5.   
   -   5         ��Name$ 
B_Register��5.      $��Registruoti užsakymą��6%   $��0,0,10,0q�6D   $��Right=�6o   $	��131��6�   $��29��6�   $��Bottom=�6�   5/      50      