   M S B A M L   `   `   `  ����F  BBusSystemUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BusSystemUIBusSystemUI  5   	   !    BusSystemUI.EditRouteWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BusSystemUI     5   	     � Title$&   Chỉnh sửa thông tin tuyến��5   	   $��468.361��6+   $��759.5��6<    � WindowStartupLocation$ CenterScreen=�6J   .��5	      � .+�5
   
   � ���	#FFEEEEEE.+�5      �� -   5         ��Name$ 
titleLabel��5      $7��1HỆ THỐNG QUẢN LÝ XE BUS TP. HỒ CHÍ MINH��6(   $
��Left=�6Z   $��42��6u   $��	149,7,0,0q�6�   $	��Top=�6�   $	��536��6�   $��25(�6�    � Cursor$	 Pen��6�   �� 5      -   5         ��Name$ busImage��5      $
��Left=�6&   $��41��6A   $��	44,12,0,0q�6M   $	��Top=�6`   $��83��6x   $��/Asset 1.png��6�   �� 5      -   5        $ windowLabel��5      $&�� CHỈNH SỬA THÔNG TIN TUYẾN��6)   $
��Left=�6M   $��32��6h   $��	20,60,0,0q�6t   $	��Top=�6�   $	��270��6�   $��18(�6�   $	 Pen��6�    J� RenderTransformOrigin$ 0.518,0.326&�6�   �� 5      $��Center=�6   $	��191��65   $��24,106,31,0q�6B   
���   �$	��Top=�6f   $	��697��6~   ���	#FFD0D0D06�   �� 5      $��route id��6   $
��Left=�6'   $��
71,130,0,0q�6B   $	��Top=�6V   $��83��6n   $
��Bold"�6y   �� 5      $��distance��6   $
��Left=�6'   $��
71,180,0,0q�6B   $	��Top=�6V   $��83��6n   $
��Bold"�6y   �� 5      $��employee id��6   $
��Left=�6*   $��
71,230,0,0q�6E   $	��Top=�6Y   $��83��6q   $
��Bold"�6|   �� 5      $
��Left=�6   $��159,134,0,0q�61   $��TextBox��6F    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��216��6�   �� 5      -   5         ��Name$ routeIdTextBox��5      $
��Left=�6.   $��159,134,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��216��6�   �� 5      -   5        $ distanceTextBox��5      $
��Left=�6/   $��159,184,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��216��6�   �� 5      -   5        $ employeeIdTextBox��5      $
��Left=�61   $��159,234,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��216��6�   �� 5      -   5         ��Name$ submitButton��5      $��Xác nhận��6+   $
��Left=�6>   $��30��6Y   $��620,377,0,0q�6e   $	��Top=�6z   $	��101��6�   ���	#FFDDDDDD$
 Hand��6�   �� 5      -   5        $ returnButton��5      $��
Quay lại��6+   $
��Left=�6>   $��30��6Y   $��
24,377,0,0q�6e   $	��Top=�6y   $	��101��6�   $
 Hand��6�   5      5      5      