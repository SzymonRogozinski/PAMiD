   M S B A M L   `   `   `  ����W  SP04WeatherForecastAPI.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:P04WeatherForecastAPI.ClientP04WeatherForecastAPI.Client  5   	   a5clr-namespace:P04WeatherForecastAPI.Client.ViewModels'P04WeatherForecastAPI.Client.ViewModels  5   	   -    'P04WeatherForecastAPI.Client.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:P04WeatherForecastAPI.Client     5   	   JboxTexts5clr-namespace:P04WeatherForecastAPI.Client.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��400��6   $	��600��6)    � 	Resources 5
         boolToVisConv  mainButtonStyle �� 
TargetType �� Property �� Value  mainLabelStyle��%�  &	        &	      &	 �     �� 5   
   6@   �� 5   
   " ��6(   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 10q�6(   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 ��ح�6+   �� 5       � ��
 ��  �6+   5      �� 5   
   " ��6'   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ Center=�64   �� 5       � ��
 �  ��6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��500 �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       $	��200 �6   �� 5!      $	��200 �6   .+�5$   
   �� $��0��6   $��10q�6%   .+�5%      �� $��
Load books��6   #��[ 6R   ��6*   �� *LoadAllBooksCommand+6~   �� 5&      $��Center=�6   $��
Book list:��68   6P   �� 5'      -   5         ��Name$ lbData��5'       �� DisplayMemberPath$ Title��6j   $��0,10,0,0q�6�   ��6&   �� *books+	 �� SelectedItem	 6D   �� *SelectedBook+6�   5(      �� 5)   
   $��1��6   $��10q�6%   .+�5*      �� $��Center=�6   $��Details��69   6N   �� 5+      $��Center=�6   $
��Name��69   $��30��6H   6V   �� 5,      -   5        
 ��Name$
 lblBookName��5,      $��30��6)   ��65   �� *DetailedBook.name+6]   �� 5-      $��Center=�6   $��Author��69   $��30��6J   6X   �� 5.      -   5        $
 lblBookAuthor��5.      $��30��6+   ��67   �� *DetailedBook.author+6a   �� 5/      $��Center=�6   $��Pages��69   $��30��6I   6W   �� 50      -   5        $
 lblBookPages��50      $��30��6*   ��66   �� *DetailedBook.pages+6_   �� 51      $��Center=�6   $��Genres��69   $��30��6J   6X   �� 52      -   5        $ lbBookGenre��52      ��6+   �� *DetailedBook.genres+6Y   �� 53      -   5         ��Name$ 	btnRemove��53      $��Remove��6(   ��69   �� *RemoveBookCommand+6a   54      �� 55   
   $��2��6   $��10q�6%   .+�56      �� $��Center=�6   $��
Add/Modify��69   $��30��6N   6\   �� 57      $��Center=�6   $
��Name��69   $��30��6H   6V   �� 58      -   5         ��Name$ txtNewBookName��58      $��30��6.   6=   �� 59      $��Center=�6   $��Author��69   $��30��6J   6X   �� 5:      -   5        $ txtNewBookAuthor��5:      $��30��60   6>   �� 5;      $��Center=�6   $��Pages��69   $��30��6I   6W   �� 5<      -	   5        $ txtNewBookPages��5<      $��30��6/   6=   �� 5=      $��Center=�6   $��Genres��69   $��30��6J   6X   �� 5>      -
   5        $ txtNewBookGenre��5>      $��30��6/   6=   �� 5?      -   5        $ btnAdd��5?      $	��Add��6%   ��63   �� *AddBookCommand+6X   �� 5@      -   5        $ btnMod��5@      $��Modify��6%   ��66   �� *UpdateBookCommand+6^   5A      5B      5C      