   M S B A M L   `   `   `  ����I  EZdravoHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZdravoHospital.WindowsZdravoHospital.Windows  5   	   -    'ZdravoHospital.Windows.RelocationWIndow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ZdravoHospital.Windows     5   	     � Title$  RelocationWIndow��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��relocateEquipmentTable��5
         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $
��Left=�6�   $	��316��6�   $��	13,26,0,0q�6�   $	��Top=�6�   $	��762��6  $��4��6!  $��4��66     AutoGenerateColumns .     
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .  ��61   ��  �� Path$ RelocateEquipment� �� Mode$ TwoWay=� �� SelectedItem 6m   �� $ SelectedRelocateEquipment�$ TwoWay=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $
 Quantity��6%    67   �� *
Quantity+  5      $
 
NextRoomId��6%    69   �� *
NextRoomId+  5      $

 Date��6%      Width$ * 6L    63   �� *Date+6L   5      �� 5   
   -   5         ��Name$ Relocate��5      $��Relocate��6#   $
��Left=�66   $��19��6Q   $��323,382,0,0q�6]   $	��Top=�6r   $	��124��6�   6�   5      5      