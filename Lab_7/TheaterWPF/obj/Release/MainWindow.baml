   M S B A M L   `   `   `  ���� E  ATheaterWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TheaterWPF
TheaterWPF      TheaterWPF.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TheaterWPF     -     �Name$  TheaterWindow�� � Title$ 
Театр��$	��492��$	��800�� � 
ResizeMode$ NoResize=� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%�  '��       '�� �     �� " ��.���  � ��$ GT Walsheim Pro)���  � ��$ 16(���  � ��$ Center=���  � ��$ Center=���  � ��$ 32���� " ��.���  �@�Cursor$
 Hand����  � ��$ GT Walsheim Pro)���  � ��$ 16(���  � ��$ Center=���  � ��$ Center=���  � ��$ 40����  � �� �	#FF004E90��  � �� �	#ffffffff��  � �� Z� ��  � ��$	 180�� P�  � {�	 .  . ���  � ��
 �����.��� -   
 �Name$
 bodyGrid��
�������.+�� -   $
 
headerGrid��$��	0,0,0,330q�$��2��.+��� -    ��Name$ headlineLable��$��THEATER��$
��Left=�$��10,0,0,0q�$	��Top=� J� RenderTransformOrigin$ -6.605,-0.038&�$��46(�$��Impact)��� -   $ sectionLable��$��ГЛАВНОЕ МЕНЮ��$
��Left=�$��	10,53,0,0q�$	��Top=�$��GT Walsheim Pro)�$��16(����	#FF6D0085�� -   $ performancesLable��$��СПЕКТАКЛИ��$
��Left=�$��
333,22,0,0q�$	��Top=�$��GT Walsheim Pro)�$��24(��� -   $ clientsLable��$��КЛИЕНТЫ��$
��Left=�$��
495,22,0,0q�$	��Top=�$��GT Walsheim Pro)�$��24(��� -    ��Name$ 
menuButton��
�������
���   �$��МЕНЮ��$
��Left=�$��
243,21,0,0q�$	��Top=�$��85��$��24(�� -	   $
 contentGrid��$��0,96,0,0q� � ColumnDefinitions �� $
��101* ��� $
��296* �.+��� $��Center=�$��0��$��4,0,10,0q�$	��Top=�$	��188��.+��� -
   $ addPerformanceButton��$)��#ДОБАВИТЬ СПЕКТКАЛЬ���� -   $ buyTicketButton��$��КУПИТЬ БИЛЕТ�����	#FF01BA76�� -   $ clientListButton��$��КЛИЕНТЫ�����	#FF6D0085�� -   $ performanceListButton��$��СПЕКТАКЛИ�����	#FF6D0085�� -   $ orderListButton��$!��СПИСОК ЗАКАЗОВ�����	#FF6D0085�� -   $ deleteTicketButton��$��ВЕРНУТЬ БИЛЕТ��
���  ���� -   $ deletePerformanceButton��$'��!УДАЛИТЬ СПЕКТАКЛЬ��
���  �� � -     �Name$ 	viewFrame��  � NavigationUIVisibility$ Hidden=�$��0,0,0,0q�$��1��