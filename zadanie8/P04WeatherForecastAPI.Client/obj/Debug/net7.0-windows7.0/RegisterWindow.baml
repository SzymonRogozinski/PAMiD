   M S B A M L   `   `   `  ����W  SP04WeatherForecastAPI.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:P04WeatherForecastAPI.ClientP04WeatherForecastAPI.Client  5   	   1    +P04WeatherForecastAPI.Client.RegisterWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:P04WeatherForecastAPI.Client     5   	     � Title$  Register��5   	   $	��250��6   $	��300��6'   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��110 �6   �� 5      $��* �6   .+�5   
   �� $��Email:��6   $��0��6!   $��0��6.   �� 5   
   -   5         ��Name$ EmailTextBox��5      $��0��6(   $��1��65   $��5q�6E   ��6P   �� *
User.Email+�� 5   
   $��	Password:��6   $��1��6$   $��0��61   �� 5   
   -   5        $ PasswordBox��5      $��1��6'   $��1��64   $��5q�6D   ��6O   �� *User.Password+�� 5   
   $��Confirm Password:��6   $��2��6,   $��0��69   �� 5   
   -   5        $ ConfirmPasswordTextBox��5      $��2��62   $��1��6?   $��5q�6O   ��6Z   �� *User.ConfirmPassword+�� 5!   
   $��	Username:��6   $��3��6$   $��0��61   �� 5"   
   -   5        $ UsernameBox��5"      $��3��6'   $��1��64   $��5q�6D   ��6O   �� *User.Username+�� 5$   
   $��4��67   $��2��6D   ��6   �� *MessageCommunicate+6D   �� 5&   
   $��Register��6   $��5��6H   $��1��6U   $��5q�6e   ��6$   �� *RegisterCommand+6e   5(      5)      