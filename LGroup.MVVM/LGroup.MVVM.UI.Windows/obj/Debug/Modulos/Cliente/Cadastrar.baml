   M S B A M L   `   `   `  ����P  LLGroup.MVVM.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null|Rclr-namespace:LGroup.MVVM.ViewModel.Modulos.Cliente;assembly=LGroup.MVVM.ViewModel%LGroup.MVVM.ViewModel.Modulos.Cliente  5   	    LGroup.MVVM.UI.Windows6   0LGroup.MVVM.UI.Windows.Modulos.Cliente.Cadastrar   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   fClienteRclr-namespace:LGroup.MVVM.ViewModel.Modulos.Cliente;assembly=LGroup.MVVM.ViewModel     5   	     � Title$  	Cadastrar��5   	   $��279.699��6   $	��300��6,    � DataContext 5      >   8LGroup.MVVM.ViewModel.Modulos.Cliente.CadastrarViewModel  5   
   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��28* �6   �� 5      $	��45* �6   .+�5   
   �� $
��Nome��6   $
��Left=�6   $��	33,26,0,0q�6:   $	��Top=�6M   �� 5   
   $��E-Mail��6   $
��Left=�6!   $��	33,81,0,0q�6<   $	��Top=�6O   �� 5   
   $��
Nascimento��6   $
��Left=�6%   $��
33,137,0,0q�6@   $	��Top=�6T   �� 5   
   $
��Left=�6   $��23��6-   $��2.835,26,0,0q�69    �� TextWrapping$
 Wrap=�6O   $	��Top=�6�   $	��120��6�   $��1��6�   ��6c   �� *Cliente.Nome+6�   �� 5   
   $
��Left=�6   $��23��6-   $��2.835,81,0,0q�69   $
 Wrap=�6O   $	��Top=�6�   $	��120��6�   $��1��6�   ��6c   �� *Cliente.Email+6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��2.835,139,0,0q�60   $	��Top=�6G   $��1��6_      SelectedDate 6o   �� *Cliente.DataNascimento+�� 5   
   $��Limpar��6   $
��Left=�6"   $��
57,202,0,0q�6=   $	��Top=�6Q   $��75��6i   $��2��6t   ��6�   �� *ClickLimpar+�� 5   
   $��	Cadastrar��6   $
��Left=�6%   $��64.835,202,0,0q�6@   $	��Top=�6X   $��75��6p   $��1��6{   ��6�   �� *ClickCadastrar+5      5      