   M S B A M L   `   `   `  ����H  DMySQLToCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MySQLToCSharp.ViewModelMySQLToCSharp.ViewModel  5   	       MySQLToCSharp.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;	viewmodel%clr-namespace:MySQLToCSharp.ViewModel     5   	     � Title$!  MySQL Table To CSharp Model��5	   	   $	��320��6-   $	��300��6:    � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterScreen=�6\   .��5
      � $��0��6   $��10,10,10,10q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� .��6   IP:6   �� 5   
   $��1��6   $��0,0,0,10q�67   ��6"   �� *IP+67   �� 5   
   $��1��6   .��6   Port:6$   �� 5   
   $��1��6   $��1��6   $��0,0,0,10q�6E   ��6/   �� *Port+6E   �� 5   
   $��2��6   .��6   	Database:6(   �� 5    
   $��2��6   $��1��6   $��0,0,0,10q�6I   ��6/   �� *
Database+6I   �� 5!   
   $��3��6   .��6   UID:6#   �� 5"   
   $��3��6   $��1��6   $��0,0,0,10q�6D   ��6/   �� *UID+6D   �� 5#   
   $��4��6   .��6   	Password:6(   �� 5$   
   $��4��6   $��1��6   $��0,0,0,10q�6I   ��6/   �� *
Password+6I   �� 5%   
   $��5��6   .��6   
Charset:6'   �� 5&   
   $��5��6   $��1��6   $��0,0,0,10q�6H   ��6/   �� *	Charset+6H   �� 5'   
   $��6��6   .��6   
Namespace:6)   �� 5(   
   $��6��6   $��1��6   $��0,0,0,10q�6O   ��6/   �� *ModelNamespace+6O   �� 5)   
   $��7��6   .��6   Save Folder:6+   � 5*   
   $��7��6   $��1��6   $��0,0,0,10q�6,    5+      �� 5,      $��* �6#   �� 5-      $
��auto �6#   .+�5/      �� ��6   �� *
SaveFolder+�� 50      $��1��6   $��Choose a folder��6P   ��6%   �� *CommandOpenSaveFolder+6P   51      �� 52   
   $��8��6   $��2��6G   $��Generate Class��6[   ��6   �� *CommandGenerateClass+6[   53      54      