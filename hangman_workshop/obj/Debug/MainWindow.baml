   M S B A M L   `   `   `  ����K  Ghangman_workshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:hangman_workshophangman_workshop  5   	   !    hangman_workshop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:hangman_workshop     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��letterGokButton��5
      $	��gok��6)   $
��Left=�67   $��256,338,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5        $��
gokTextBox��5        �� 	MaxLength$ 1��6   $
��Left=�62   $��23��6M   $��101,334,0,0q�6Y    �� TextWrapping$
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ setWordTextBox��5      $
��Left=�6*   $��23��6E   $��101,191,0,0q�6Q   $
 Wrap=�6f   $��TextBox��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ setBoxButton��5      $	��set��6'   $
��Left=�65   $��256,190,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $��wordTextBlock��5      $
��Left=�6)   $��
197,77,0,0q�6D   $
��Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��134��6�   �� 5   
   -   5         ��Name$ lengthTextBlock��5      $
��Left=�6-   $��
442,77,0,0q�6H   $
��Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��134��6�   �� 5   
   -   5        $��hangManCanvas��5      $
��Left=�6&   $	��300��6A   $��
442,93,0,0q�6N   $	��Top=�6b   $	��300��6z   5      5      