   M S B A M L   `   `   `  ����F  BAssignment2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment2Assignment2  5   	       Assignment2.Show_Json   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment2     5   	     � Title$
  JSON��5   	   $	��530��6   $	��815��6#    � WindowStartupLocation$ CenterScreen=�6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��55* �6   �� 5      $	��55* �6   �� 5      $
��210* �6   �� 5      $
��210* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��154* �6   �� 5      $
��429* �6   �� 5      $
��120* �6   .+�5   
   �� 
���   �$��1q�6%   $��Center=�69   $��34��6V   $��Center=�6b   $	��155��6}   �� 5   
   $
��JSON��6   $��Center=�6    $��Center=�6;   
���   �$��20(�6k   $
��Bold"�6y   $��28��6�   $��53��6�   �� 5   
   -   5        $��3��5      $
��Home��6!   $��Center=�60   $��34��6M   $��Center=�6Y   $	��116��6t   $��20(�6�   �� 5   
   -   5         ��Name$ FileJson��5      $��Center=�6$   $��1��6F   $��0��6S   $��3��6c   $
��Left=�6w   $��31��6�    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��641��6�   $��12,0,0,0q�6�   �� 5   
   -   5        $��2��5      $��1��6!   $��Center=�6.   $��Center=�6R   $	��***��6t   $��Center=�6�   $��30��6�   $��Center=�6�   $	��117��6�   $��16(�6�    J� RenderTransformOrigin$ 0.322,0.644&�6�   �� 5    
   
���   �$��1q�6%   $
��Left=�69   $	��186��6T   $��Center=�6a   $	��643��6|   $��2��6�   $��2��6�   $��10,0,0,0q�6�   ._�5!      �� -   5        $ txtJsonData��5!      $��9,9,9,9q�6+   $
 Wrap=�6<   " �� VerticalScrollBarVisibility$
 Auto=�6v   $ �� HorizontalScrollBarVisibility$
 Auto=�6�   5"      �� 5$   
   -   5        $��2��5$      $��Create��6!   $��Center=�62   $��34��6O   $	��Top=�6[   $	��116��6s   $��20(�6�   $��0,10,0,0q�6�   $��2��6�   ���	#FF00FC066�   �� 5&   
   -   5        $��2��5&      $
��Read��6!   $��Center=�60   $��34��6M   $	��Top=�6Y   $	��116��6q   $��20(�6�   $��0,58,0,0q�6�   $��2��6�   ���	#FF003EFF
�������6�   �� 5(   
   -   5        $��2��5(      $��Delete��6!   $��Center=�62   $��34��6O   $	��Top=�6[   $	��116��6s   $��20(�6�   $��	0,109,0,0q�6�   $��2��6�   
���  ��
�������6�   �� 5*   
   -   5        $��2��5*      $
��Save��6!   $��Center=�60   $��34��6M   $	��Top=�6Y   $	��116��6q   $��20(�6�   $��	0,160,0,0q�6�   $��2��6�   ���	#FFF6BF126�   &   System.Windows.Controls.DataGrid  5,   
   -	   5        	  Name$	 dataGridJson��5,      $��Center=�6)   $	��183��6F   $��Center=�6S   $	��792��6n   
   AutoGenerateColumns$

 True��6z   $��3��6�   $��3��6�   5.      5/      