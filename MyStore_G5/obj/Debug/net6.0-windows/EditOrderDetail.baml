   M S B A M L   `   `   `  ����E  AMyStore_G5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MyStore_G5
MyStore_G5  5   	        MyStore_G5.EditOrderDetail   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MyStore_G5     5   	     � Title$  EditOrderDetail��5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Order Detail ID:��6   $��0��6+   $��10q�68   �� 5   
   -   5         ��Name$ orderDetailIdTextBox��5      $��0��60   $��
100,0,10,0q�6=   ${�False��6Q   ��6c   �� *OrderDetailId+�� 5   
   $��	Order ID:��6   $��1��6$   $��10q�61   �� 5   
   -   5        $ orderIdTextBox��5      $��1��6*   $��
100,0,10,0q�67   ${�False��6K   ��6]   �� *	OrderId+�� 5   
   $��Product ID:��6   $��2��6&   $��10q�63   �� 5   
   -   5        $ productIdTextBox��5      $��2��6,   $��
100,0,10,0q�69   ${�False��6M   ��6_   �� *	ProductId+�� 5    
   $��Product Name:��6   $��3��6(   $��10q�65   �� 5!   
   -   5        $ productNameTextBox��5!      $��3��6.   $��
100,0,10,0q�6;   ${�False��6O   ��6a   �� *ProductName+�� 5#   
   $��	Quantity:��6   $��4��6$   $��10q�61   �� 5$   
   -   5        $ quantityTextBox��5$      $��4��6+   $��
100,0,10,0q�68   ��6L   �� *
Quantity+�� 5&   
   $��Unit Price:��6   $��5��6&   $��10q�63   �� 5'   
   -   5        $ unitPriceTextBox��5'      $��5��6,   $��
100,0,10,0q�69   ${�False��6h   ��6M   �� *	UnitPrice+6h   �� 5*   
   -   5        $
��Save��5*      $��9��6    $��512,40,93,66q�6-   6C   �� 5+   
   -   5        $��Cancel��5+      $��9��6"   $��145,36,456,65q�6/    J� RenderTransformOrigin$ 0.5,0.5&�6a   z�5,      V� 5-      .~�5.      �� �� 5/      �� 50       �� Angle$ -0.059Q�6&   T� 51      52      54      55      56      