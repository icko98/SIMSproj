   M S B A M L   `   `   `  ����I  EZdravoHospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZdravoHospital.WindowsZdravoHospital.Windows  5   	   )    #ZdravoHospital.Windows.DoctorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ZdravoHospital.Windows     5   	     � Title$  DoctorWindow��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��60* �6   �� 5      $
��206* �6   �� 5      $
��267* �6   �� 5      $
��267* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��appTable��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $
��Left=�6�   $	��316��6�   $��	13,26,0,0q�6�   $	��Top=�6�   $	��762��6�   $��4��6�   $��4��6     AutoGenerateColumns .     
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .  ��6#   ��  �� Path$ Xapps�	 �� Mode$	 TwoWay=�
 �� SelectedItem
 6S   �� $ SelectedApp�$	 TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ 	PatientID��6%    68   �� *	PatientID+  5      $
 Date��6%    63   �� *Dt+  5      $ Duration��6%    67   �� *
Duration+5      �� 5    
   -   5        $	��Add��5       $
��Left=�6   $��	15,23,0,0q�6:   $��4��6M   $	��Top=�6Z   $	��111��6r   $��37��6�   $��1��6�   �� 5!   
   -   5        $
��Edit��5!      $
��Left=�6    $��	10,23,0,0q�6;   $��4��6N   $	��Top=�6[   $	��111��6s   $��37��6�   $��2��6�   �� 5"   
   -   5        $��Delete��5"      $
��Left=�6"   $��
206,23,0,0q�6=   $��4��6Q   $	��Top=�6^   $	��111��6v   $��37��6�   $��2��6�   $��2��6�   �� 5#   
   -   5        $
��File��5#      $
��Left=�6    $��	130,0,0,0q�6;   $��4��6N   $��Center=�6[   $	��111��6v   $��37��6�   $��3��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5$      V� 5%      .~�5&      �� �� 5'      �� 5(       �� Angle$ 0.577Q�6&   T� 5)      5*      5,      5.      5/      