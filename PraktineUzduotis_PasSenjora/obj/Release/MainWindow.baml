   M S B A M L   `   `   `  ���� E  APasSenjora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PraktineUzduotis_PasSenjoraPraktineUzduotis_PasSenjora  ,    &PraktineUzduotis_PasSenjora.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ;local)clr-namespace:PraktineUzduotis_PasSenjora       � Title$  Pas Senjora��$	��350��$	��525�� � 	Resources 5   /PraktineUzduotis_PasSenjora.OrderPriceConverter   OPConverter2   ,PraktineUzduotis_PasSenjora.TabNameConverter  TNConverter3   -PraktineUzduotis_PasSenjora.TabPriceConverter  TPConverter5   /PraktineUzduotis_PasSenjora.OrderStateConverter  OSConverter3   -PraktineUzduotis_PasSenjora.OrderTabConverter  OTConverter��%K   &	        &	      &	 
     &	      &	                .��� $��10q�.+�&   System.Windows.Controls.DataGrid  -   $��	DG_Orders��   AutoGenerateColumns .  $��0,0,0,34q�   
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Stalas��   Width5	  /System.Windows.Controls.DataGridLengthConverter$
 Auto	 1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding �� *	TableID+  $ Kaina��$
 Auto	  ��  �� 	Converter# [    $ Statusas��$ *	  �� # [ 	   RowDetailsTemplate	 �� .R�� $��0q�$��Disabled=�$��Stretch=�.+�   .  $
��Left=�$��0q� . ���� # [    $ 	Produktas��$
 Auto	 
   CanUserResize
 .   �� # [   $ Vieneto kaina��$
 Auto	 
 .   �� # [   $ Kiekis��$
 Auto	 
 .   �� *	FoodCount+�� -    ��Name$ 
B_Register��$��Registruoti užsakymą��$��0,0,10,0q�$��Right=�$	��131��$��29��$��Bottom=�