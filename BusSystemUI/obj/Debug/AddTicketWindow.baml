   M S B A M L   `   `   `  ����F  BBusSystemUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BusSystemUIBusSystemUI  5   	   !    BusSystemUI.AddTicketWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BusSystemUI     5   	     � Title$  AddTicketWindow��5   	   $	��480��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � ���	#FFEEEEEE.+�5
   
   �� -   5         ��Name$ 
titleLabel��5
      $7��1HỆ THỐNG QUẢN LÝ XE BUS TP. HỒ CHÍ MINH��6$   $
��Left=�6V   $��42��6q   $��	149,7,0,0q�6}   $	��Top=�6�   $	��536��6�   $��25(�6�    � Cursor$	 Pen��6�   �� 5   
   -   5         ��Name$ busImage��5      $
��Left=�6"   $��41��6=   $��	44,12,0,0q�6I   $	��Top=�6\   $��83��6t   $��/Asset 1.png��6   �� 5   
   -   5        $ windowLabel��5      $��THÊM THÔNG TIN VÉ��6%   $
��Left=�6A   $��32��6\   $��	20,60,0,0q�6h   $	��Top=�6{   $	��180��6�   $��18(�6�   $	 Pen��6�    J� RenderTransformOrigin$ 0.518,0.326&�6�   �� 5   
   $��Center=�6   $	��191��61   $��	0,106,0,0q�6>   
���   �$	��Top=�6`   $	��756��6x   ���	#FFD0D0D06�   �� 5   
   $��Mã vé��6   $
��Left=�6    $��
71,130,0,0q�6;   $	��Top=�6O   $��83��6g   $
��Bold"�6r   �� 5   
   $
��Giá��6   $
��Left=�6   $��
71,180,0,0q�69   $	��Top=�6M   $��83��6e   $
��Bold"�6p   �� 5   
   $��
Loại vé��6   $
��Left=�6"   $��
71,230,0,0q�6=   $	��Top=�6Q   $��83��6i   $
��Bold"�6t   �� 5   
   $��Mã tuyến��6   $
��Left=�6#   $��436,130,0,0q�6>   $	��Top=�6S   $��83��6k   $
��Bold"�6v   $ 0.557,1.319&�6�   �� 5   
   $��Mã chuyến��6   $
��Left=�6$   $��436,180,0,0q�6?   $	��Top=�6T   $��93��6l   $
��Bold"�6w   $ 0.557,1.319&�6�   �� 5   
   $��Mã giao dịch��6   $
��Left=�6'   $��436,230,0,0q�6B   $	��Top=�6W   $��83��6o   $
��Bold"�6z   $ 0.557,1.319&�6�   �� 5   
   $
��Left=�6   $��159,134,0,0q�6-   $��TextBox��6B    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��216��6}   �� 5   
   -   5         ��Name$ addTicketIdTextBox��5      $
��Left=�6.   $��159,134,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��216��6�   �� 5   
   -   5        $ addPriceTicketTextBox��5      $
��Left=�61   $��159,184,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��216��6�   �� 5   
   -   5        $ addTypeTicketTextBox��5      $
��Left=�60   $��159,234,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��216��6�   �� 5   
   -   5        $ addRouteIdTicketTextBox��5      $
��Left=�63   $��533,134,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��216��6�   �� 5   
   -   5        $ addTripNoTicketTextBox��5      $
��Left=�62   $��533,184,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��216��6�   �� 5   
   -	   5        $ addPaymentIdTicketTextBox��5      $
��Left=�65   $��533,234,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��216��6�   �� 5   
   -
   5         ��Name$ submitButton��5      $��Xác nhận��6'   $
��Left=�6:   $��30��6U   $��673,398,0,0q�6a   $	��Top=�6v   $	��101��6�   $
 Hand��6�   �� 5   
   -   5        $ returnButton��5      $��
Quay lại��6'   $
��Left=�6:   $��30��6U   $��
18,398,0,0q�6a   $	��Top=�6u   $	��101��6�   $
 Hand��6�   5      5      