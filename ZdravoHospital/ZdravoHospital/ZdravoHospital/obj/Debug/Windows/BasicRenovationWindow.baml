   M S B A M L   `   `   `  ����I  EZdravoHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZdravoHospital.WindowsZdravoHospital.Windows  5   	   2    ,ZdravoHospital.Windows.BasicRenovationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ZdravoHospital.Windows     5   	     � Title$  BasicRenovationWindow��5   	   $	��450��6'   $	��800��64   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��basicRenovationTable��5
         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $
��Left=�6�   $	��316��6�   $��	13,26,0,0q�6�   $	��Top=�6�   $	��762��6  $��4��6  $��4��60     AutoGenerateColumns .     
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .  ��6/   ��  �� Path$ BasicRenovation� �� Mode$ TwoWay=� �� SelectedItem 6i   �� $ SelectedBasicRenovation�$ TwoWay=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 RoomId��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *RoomId+  5      $
 	StartDate��6%    68   �� *	StartDate+  5      $
 EndDate��6%    66   �� *	EndDate+  5      $
 Description��6%      Width$ * 6Z    6:   �� *Description+6Z   5      �� 5   
   -   5         ��Name$ ScheduleRenovation��5      $��Schedule Renovation��6-   $
��Left=�6K   $��19��6f   $��323,382,0,0q�6r   $	��Top=�6�   $	��124��6�   6�   5      5      