   M S B A M L   `   `   `  ����F  BBusSystemUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BusSystemUIBusSystemUI  5   	       BusSystemUI.EditBusWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BusSystemUI     5   	     � Title$  EditBusWindow��5   	   $	��450��6   $	��800��6,    � WindowStartupLocation$ CenterScreen=�68   .��5	      � .+�5
   
   �� -   5         ��Name$ 
titleLabel��5
      $7��1HỆ THỐNG QUẢN LÝ XE BUS TP. HỒ CHÍ MINH��6$   $
��Left=�6V   $��42��6q   $��	149,7,0,0q�6}   $	��Top=�6�   $	��536��6�   $��25(�6�    � Cursor$	 Pen��6�   �� 5   
   -   5         ��Name$ busImage��5      $
��Left=�6"   $��41��6=   $��	44,12,0,0q�6I   $	��Top=�6\   $��83��6t   $��/Asset 1.png��6   �� 5   
   -   5        $ titleLabel_Copy��5      $%��CHỈNH SỬA THÔNG TIN XE BUS��6)   $
��Left=�6N   $��32��6i   $��	20,60,0,0q�6u   $	��Top=�6�   $	��301��6�   $��18(�6�   $	 Pen��6�    J� RenderTransformOrigin$ 0.518,0.326&�6�   �� 5   
   $��Center=�6   $	��168��61   $��	0,106,0,0q�6>   
���   �$	��Top=�6`   $	��756��6x   ���	#FFD0D0D06�   �� 5   
   $��	LOẠI XE��6   $
��Left=�6"   $��
71,130,0,0q�6=   $	��Top=�6Q   $��83��6i   $
��Bold"�6t   �� 5   
   $��BIỂN SỐ��6   $
��Left=�6"   $��
71,180,0,0q�6=   $	��Top=�6Q   $��83��6i   $
��Bold"�6t   �� 5   
   $��SỐ CHỖ NGỒI��6   $
��Left=�6&   $��
60,230,0,0q�6A   $	��Top=�6U   $��92��6m   $
��Bold"�6x   �� 5   
   $
��Left=�6   $��159,134,0,0q�6-   $��TextBox��6B    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��216��6}   �� 5   
   -   5         ��Name$ typeBusTextBox��5      $
��Left=�6*   $��159,134,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��216��6�   �� 5   
   -   5        $ licenseNoTextBox��5      $
��Left=�6,   $��159,184,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��216��6�   �� 5   
   -   5        $ NoSeatTextBox��5      $
��Left=�6)   $��159,234,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��216��6�   �� 5   
   -   5         ��Name$ submitBusButton��5      $��Xác nhận��6*   $
��Left=�6=   $��30��6X   $��677,354,0,0q�6d   $	��Top=�6y   $	��101��6�   ���	#FFDDDDDD$
 Hand��6�   �� 5   
   -   5        $ returnBusButton��5      $��
Quay lại��6*   $
��Left=�6=   $��30��6X   $��
20,354,0,0q�6d   $	��Top=�6x   $	��101��6�   $
 Hand��6�   5      5      