   M S B A M L   `   `   `  ����C  ?Database, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DatabaseDatabase  5   	       Database.TableCreation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Database     5   	     � Title$  TableCreation��5   	   $	��600��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ tableNameLabel��5
      $��Nom de la table��6(   $
��Left=�6B   $��45��6]   $��	46,18,0,0q�6i   $	��Top=�6|   $	��142��6�   $��14(�6�   $��Tahoma)�6�   �� 5   
   -   5         ��Name$ tableNameBox��5      $
��Left=�6(   $��45��6C   $��
292,18,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��187��6�   $��14(�6�   $��Tahoma)�6�   �� 5   
   -   5         ��Name$ 
validerBtn��5      $��Valider��6%   $
��Left=�67   $��52��6R   $��320,507,0,0q�6^   $	��Top=�6s   $	��180��6�   $��14(�6�   $��Tahoma)�6�   6�   �� 5   
   -   5        $ addColonneBtn��5      $��Ajout Colonne��6(   $
��Left=�6@   $��52��6[   $��
562,79,0,0q�6g   $	��Top=�6{   $	��180��6�   6�   �� 5   
   -   5        $ 
champLabel��5      $��Champ��6$   $
��Left=�64   $��52��6O   $��	46,79,0,0q�6[   $	��Top=�6n   $	��104��6�   $��14(�6�   $��Tahoma)�6�   �� 5   
   -   5        $ 	typeLabel��5      $
��Type��6#   $
��Left=�62   $��43��6M   $��
46,138,0,0q�6Y   $	��Top=�6m   $��80��6�    J� RenderTransformOrigin$ 0.489,-0.157&�6�   $��14(�6�   $��Tahoma)�6�   �� 5   
   -   5        $ champTxt��5      $
��Left=�6$   $��32��6?   $��
173,79,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��141��6�   $��14(�6�   $��Tahoma)�6�   �� 5   
   -   5         ��Name$ comboBoxType��5      $
��Left=�6)   $��173,138,0,0q�6D   $	��Top=�6Y   $	��120��6q   $��35��6�   �� 5   
   -	   5        $ keylabel��5      $��Cle Primaire��6"   $
��Left=�69   $��33��6T   $��
46,203,0,0q�6`   $	��Top=�6t   $	��104��6�   $��14(�6�   $��Tahoma)�6�   �� 5   
   -
   5        $ comboBoxKey��5      $
��Left=�6(   $��35��6C   $��173,203,0,0q�6O   $	��Top=�6d   $	��120��6|   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
72,271,0,0q�6@   $	��Top=�6T   $	��231��6l   $	��659��6y   5      5      