   M S B A M L   `   `   `  ���� H  DMySQLToCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MySQLToCSharp.ViewModelMySQLToCSharp.ViewModel      MySQLToCSharp.MainWindow   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ;	viewmodel%clr-namespace:MySQLToCSharp.ViewModel       � Title$!  MySQL Table To CSharp Model��$	��320��$	��300�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� $��0��$��10,10,10,10q� � ColumnDefinitions �� $
��Auto ��� $��* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* �.+��� .��IP:�� $��1��$��0,0,0,10q����� *IP+�� $��1��.��Port:�� $��1��$��1��$��0,0,0,10q����� *Port+�� $��2��.��	Database:�� $��2��$��1��$��0,0,0,10q����� *
Database+�� $��3��.��UID:�� $��3��$��1��$��0,0,0,10q����� *UID+�� $��4��.��	Password:�� $��4��$��1��$��0,0,0,10q����� *
Password+�� $��5��.��
Charset:�� $��5��$��1��$��0,0,0,10q����� *	Charset+�� $��6��.��
Namespace:�� $��6��$��1��$��0,0,0,10q����� *ModelNamespace+�� $��7��.��Save Folder:� $��7��$��1��$��0,0,0,10q� �� $��* ��� $
��auto �.+��� ���� *
SaveFolder+�� $��1��$��Choose a folder������ *CommandOpenSaveFolder+�� $��8��$��2��$��Generate Class������ *CommandGenerateClass+