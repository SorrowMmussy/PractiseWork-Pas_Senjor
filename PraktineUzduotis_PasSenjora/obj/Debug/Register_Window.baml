   M S B A M L   `   `   `  ����E  APasSenjora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PraktineUzduotis_PasSenjoraPraktineUzduotis_PasSenjora  5   	   1    +PraktineUzduotis_PasSenjora.Register_Window   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PraktineUzduotis_PasSenjora     5   	     � Title$  Uzsakymo registracija��5   	   $	��300��6'   $	��300��64   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DG_Register��5
      $��10,10,10,37q�6(      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Produktas��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 68      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *Name+6^     5      $ Kiekis��6%   $ * 65    6?   �� *Count+5      �� 5   
   -   5         ��Name$ 
CB_TableID��5      $��0,0,90,8q�6u   $��Right=�6�   $	��138��6�   $��25��6�   $��Bottom=�6�   ��6'   �� 	 �� Path$	 
FreeTables�
 �� SelectedItem
 6O   �� $	 TableID�6�   �� 5   
   -   5         ��Name$ L_Foodlabel��5      $��Stalas:��6%   $��Right=�67   $��
0,0,233,10q�6S   $��49��6g   $��23��6r   $��Bottom=�6~   �� 5   
   -   5         ��Name$ B_RegisterOK��5      $��Registruoti��6'   $��0,0,10,7q�6=   $��Right=�6O   $��75��6k   $��25��6v   $��Bottom=�6�   6�   5      5      