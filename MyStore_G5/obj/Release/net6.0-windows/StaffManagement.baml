   M S B A M L   `   `   `  ����   
MyStore_G5     MyStore_G5.StaffManagement   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  Staff Management��.���  � RowDefinitions �� $
��Auto ��� $��* �.+���  �� Orientation$ 
Horizontal=�$��0��$��10q�.+��� -   $��Add new��$��5q�$
��10,5q��� -    ��Name$ staffListView��$��1��$��10q� �� View �� .P��� $��ID�� �� Width$ 50�� �� DisplayMemberBinding �� *	StaffId+�� $
��Name��$	 150�� �� *Name+�� $��Password��$	 100�� �� *
Password+�� $
��Role��$	 100�� �� *Role+�� $��Actions��$	 150�� �� CellTemplate �� .R��� $ 
Horizontal=�.+��� -   $��Update��$��2q�$��5q��� -   $��Delete��$��2q�$��5q�