   M S B A M L   `   `   `  ����F  BBusSystemUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BusSystemUIBusSystemUI  5   	   "    BusSystemUI.EditTicketWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BusSystemUI     5   	     � Title$"  Chỉnh sửa thông tin vé��5   	   $	��480��6(   $	��800��65   .��5	      � .+�5
   
   � ���	#FFEEEEEE.+�5      �� -   5         ��Name$ 
titleLabel��5      $7��1HỆ THỐNG QUẢN LÝ XE BUS TP. HỒ CHÍ MINH��6(   $
��Left=�6Z   $��42��6u   $��	149,7,0,0q�6�   $	��Top=�6�   $	��536��6�   $��25(�6�    � Cursor$	 Pen��6�   �� 5      -   5         ��Name$ busImage��5      $
��Left=�6&   $��41��6A   $��	44,12,0,0q�6M   $	��Top=�6`   $��83��6x   $��/Asset 1.png��6�   �� 5      -   5        $ windowLabel��5      $"��CHỈNH SỬA THÔNG TIN VÉ��6)   $
��Left=�6J   $��32��6e   $��	20,60,0,0q�6q   $	��Top=�6�   $	��260��6�   $��18(�6�   $	 Pen��6�    J� RenderTransformOrigin$ 0.518,0.326&�6�   �� 5      $��Center=�6   $	��191��65   $��	0,106,0,0q�6B   
���   �$	��Top=�6d   $	��756��6|   ���	#FFD0D0D06�   �� 5      $��Mã vé��6   $
��Left=�6$   $��
71,130,0,0q�6?   $	��Top=�6S   $��83��6k   $
��Bold"�6v   �� 5      $
��Giá��6   $
��Left=�6"   $��
71,180,0,0q�6=   $	��Top=�6Q   $��83��6i   $
��Bold"�6t   �� 5      $��
Loại vé��6   $
��Left=�6&   $��
71,230,0,0q�6A   $	��Top=�6U   $��83��6m   $
��Bold"�6x   �� 5      $��Mã tuyến��6   $
��Left=�6'   $��436,130,0,0q�6B   $	��Top=�6W   $��83��6o   $
��Bold"�6z   $ 0.557,1.319&�6�   �� 5      $��Mã chuyến��6   $
��Left=�6(   $��436,180,0,0q�6C   $	��Top=�6X   $��93��6p   $
��Bold"�6{   $ 0.557,1.319&�6�   �� 5      $��Mã giao dịch��6   $
��Left=�6+   $��436,230,0,0q�6F   $	��Top=�6[   $��83��6s   $
��Bold"�6~   $ 0.557,1.319&�6�   �� 5      $
��Left=�6   $��159,134,0,0q�61   $��TextBox��6F    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��216��6�   �� 5      -   5         ��Name$ updateTicketIdTextBox��5      $
��Left=�65   $��159,134,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��216��6�   �� 5      -   5        $ updatePriceTicketTextBox��5      $
��Left=�68   $��159,184,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��216��6�   �� 5      -   5        $ updateTypeTicketTextBox��5      $
��Left=�67   $��159,234,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��216��6�   �� 5      -   5        $  updateRouteIdTicketTextBox��5      $
��Left=�6:   $��533,134,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��216��6�   �� 5      -   5        $ updateTripNoTicketTextBox��5      $
��Left=�69   $��533,184,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��216��6�   �� 5      -	   5        $" updatePaymentIdTicketTextBox��5      $
��Left=�6<   $��533,234,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��216��6�   �� 5      -
   5         ��Name$ submitButton��5      $��Xác nhận��6+   $
��Left=�6>   $��30��6Y   $��677,369,0,0q�6e   $	��Top=�6z   $	��101��6�   ���	#FFDDDDDD$
 Hand��6�   �� 5      -   5        $ returnButton��5      $��
Quay lại��6+   $
��Left=�6>   $��30��6Y   $��
20,371,0,0q�6e   $	��Top=�6y   $	��101��6�   $
 Hand��6�   5      5      5       