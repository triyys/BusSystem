   M S B A M L   `   `   `  ����F  BBusSystemUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BusSystemUIBusSystemUI  5   	        BusSystemUI.AddRouteWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BusSystemUI     5   	     � Title$  AddRouteWindow��5   	   $	��480��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69   .��5	      � ���	#FFEEEEEE$��0,0,0,1q�6"   .+�5
   
   �� -   5         ��Name$ 
titleLabel��5
      $7��1HỆ THỐNG QUẢN LÝ XE BUS TP. HỒ CHÍ MINH��6$   $
��Left=�6V   $��42��6q   $��	149,7,0,0q�6}   $	��Top=�6�   $	��536��6�   $��25(�6�    � Cursor$	 Pen��6�   �� 5   
   -   5         ��Name$ busImage��5      $
��Left=�6"   $��41��6=   $��	44,12,0,0q�6I   $	��Top=�6\   $��83��6t   $��/Asset 1.png��6   �� 5   
   -   5        $ windowLabel��5      $��THÊM TUYẾN��6%   $
��Left=�6:   $��32��6U   $��	20,60,0,0q�6a   $	��Top=�6t   $	��160��6�   $��18(�6�   $	 Pen��6�    J� RenderTransformOrigin$ 0.518,0.326&�6�   �� 5   
   $��Center=�6   $	��191��61   $��	0,106,0,0q�6>   
���   �$	��Top=�6`   $	��756��6x   ���	#FFD0D0D06�   �� 5   
   $��route id��6   $
��Left=�6#   $��
71,130,0,0q�6>   $	��Top=�6R   $��83��6j   $
��Bold"�6u   �� 5   
   $��distance��6   $
��Left=�6#   $��
71,180,0,0q�6>   $	��Top=�6R   $��83��6j   $
��Bold"�6u   �� 5   
   $��employee id��6   $
��Left=�6&   $��
71,230,0,0q�6A   $	��Top=�6U   $��83��6m   $
��Bold"�6x   �� 5   
   $��	last name��6   $
��Left=�6$   $��436,130,0,0q�6?   $	��Top=�6T   $��83��6l   $
��Bold"�6w   $ 0.557,1.319&�6�   �� 5   
   $��
first name��6   $
��Left=�6%   $��436,180,0,0q�6@   $	��Top=�6U   $��93��6m   $
��Bold"�6x   $ 0.557,1.319&�6�   �� 5   
   $��email��6   $
��Left=�6    $��436,230,0,0q�6;   $	��Top=�6P   $��83��6h   $
��Bold"�6s   $ 0.557,1.319&�6�   �� 5   
   $
��Left=�6   $��159,134,0,0q�6-   $��TextBox��6B    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��216��6}   �� 5   
   -   5         ��Name$ routeIdTextBox��5      $
��Left=�6*   $��159,134,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��216��6�   �� 5   
   -   5        $ distanceTextBox��5      $
��Left=�6+   $��159,184,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��216��6�   �� 5   
   -   5        $ employeeIdTextBox��5      $
��Left=�6-   $��159,234,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��216��6�   �� 5   
   -   5        $ lastNameTextBox��5      $
��Left=�6+   $��533,134,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��216��6�   �� 5   
   -   5        $ firstNameTextBox��5      $
��Left=�6,   $��533,184,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��216��6�   �� 5   
   -	   5        $ emailTextBox��5      $
��Left=�6(   $��533,234,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��216��6�   �� 5   
   -
   5         ��Name$ submitButton��5      $��Xác nhận��6'   $
��Left=�6:   $��30��6U   $��673,398,0,0q�6a   $	��Top=�6v   $	��101��6�   $
 Hand��6�   �� 5   
   -   5        $ returnButton��5      $��
Quay lại��6'   $
��Left=�6:   $��30��6U   $��
18,398,0,0q�6a   $	��Top=�6u   $	��101��6�   $
 Hand��6�   5      5      