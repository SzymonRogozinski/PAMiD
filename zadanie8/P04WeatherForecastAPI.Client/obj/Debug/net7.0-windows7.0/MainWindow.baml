   M S B A M L   `   `   `  ����W  SP04WeatherForecastAPI.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:P04WeatherForecastAPI.ClientP04WeatherForecastAPI.Client  5   	   a5clr-namespace:P04WeatherForecastAPI.Client.ViewModels'P04WeatherForecastAPI.Client.ViewModels  5   	   -    'P04WeatherForecastAPI.Client.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:P04WeatherForecastAPI.Client     5   	   JboxTexts5clr-namespace:P04WeatherForecastAPI.Client.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��500��6   $	��600��6)    � 	Resources 5
         boolToVisConv  mainButtonStyle �� 
TargetType �� Property �� Value  mainLabelStyle��%�  &	        &	      &	 �     �� 5   
   6@   �� 5   
   " ��6(   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 10q�6(   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 ��ح�6+   �� 5       � ��
 ��  �6+   5      �� 5   
   " ��6'   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ Center=�64   �� 5       � ��
 �  ��6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��500 �6    � ColumnDefinitions 5   
   �� 5       $	��200 �6   �� 5!      $	��200 �6   �� 5"      $	��200 �6   .+�5&   
   �� $��0��6   $��0��6%   $��10q�62   .+�5'      �� $��Login��6   #��[ 6F   ��6%   �� *LoginCommand+6r   5(      �� 5*   
   $��1��6   $��0��6%   $��10q�62   .+�5+      �� $��Center=�6   $��Hello��68   6K   �� 5,      $��Center=�6   ��68   �� *Authorized.HelloMessage+6g   5-      �� 5/   
   $��2��6   $��0��6%   $��10q�62   .+�50      �� $��Center=�6   $��Secret message is��68   6W   �� 51      $��Center=�6   ��68   �� *Authorized.Secret+6a   52      �� 55   
   $��0��6   $��1��6%   $��10q�62   .+�56      �� $��
Load books��6   #��[ 6R   ��6*   �� *LoadAllBooksCommand+6~   �� 57      $��Center=�6   $��
Book list:��68   6P   �� 58      -   5         ��Name$ lbData��58       �� DisplayMemberPath$ Title��6j   $��0,10,0,0q�6�   ��6&   �� *books+	 �� SelectedItem	 6D   �� *SelectedBook+6�   59      �� 5:   
   $��1��6   $��1��6%   $��10q�62   .+�5;      �� $��Center=�6   $��Details��69   6N   �� 5<      $��Center=�6   $
��Name��69   $��30��6H   6V   �� 5=      -   5        
 ��Name$
 lblBookName��5=      $��30��6)   ��65   �� *DetailedBook.name+6]   �� 5>      $��Center=�6   $��Author��69   $��30��6J   6X   �� 5?      -   5        $
 lblBookAuthor��5?      $��30��6+   ��67   �� *DetailedBook.author+6a   �� 5@      $��Center=�6   $��Pages��69   $��30��6I   6W   �� 5A      -   5        $
 lblBookPages��5A      $��30��6*   ��66   �� *DetailedBook.pages+6_   �� 5B      $��Center=�6   $��Genres��69   $��30��6J   6X   �� 5C      -   5        $ lbBookGenre��5C      ��6+   �� *DetailedBook.genres+6Y   �� 5D      -   5         ��Name$ 	btnRemove��5D      $��Remove��6(   ��69   �� *RemoveBookCommand+6a   5E      �� 5F   
   $��2��6   $��1��6%   $��10q�62   .+�5G      �� $��Center=�6   $��
Add/Modify��69   $��30��6N   6\   �� 5H      $��Center=�6   $
��Name��69   $��30��6H   6V   �� 5I      -   5         ��Name$ txtNewBookName��5I      $��30��6.   6=   �� 5J      $��Center=�6   $��Author��69   $��30��6J   6X   �� 5K      -   5        $ txtNewBookAuthor��5K      $��30��60   6>   �� 5L      $��Center=�6   $��Pages��69   $��30��6I   6W   �� 5M      -	   5        $ txtNewBookPages��5M      $��30��6/   6=   �� 5N      $��Center=�6   $��Genres��69   $��30��6J   6X   �� 5O      -
   5        $ txtNewBookGenre��5O      $��30��6/   6=   �� 5P      -   5        $ btnAdd��5P      $	��Add��6%   ��63   �� *AddBookCommand+6X   �� 5Q      -   5        $ btnMod��5Q      $��Modify��6%   ��66   �� *UpdateBookCommand+6^   5R      5S      5T      