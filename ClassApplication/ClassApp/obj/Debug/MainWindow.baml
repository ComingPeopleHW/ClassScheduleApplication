   M S B A M L   `   `   `  ����C  ?ClassApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ClassAppClassApp  5   	       ClassApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ClassApp     5   	   -   5          �Name$  登录��5   	    � Title$ Class��5   	   $��355.224��6   $��508.329��6(    � 
ResizeMode$ CanMinimize=�68    � WindowStartupLocation$ CenterScreen=�6Q   .��5	      � $��10,0,3.6,7.6q�6   $	��318��6!   $��Bottom=�6.    � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ Lable1��5      $��	账号：��6    $
��Left=�6.   $��64��6I   $��	23,97,0,0q�6U   $	��Top=�6h   $	��120��6�   $��20(�6�   �� 5   
   -   5         ��Name$ TextBox1��5      $
��Left=�6$   $��35��6?   $��	88,97,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��335��6�   $��22(�6�   $��4q�6�   $��1��6�   .��6�    � 	Resources 5         	HelpBrush	 j� TileMode
 �� Opacity j� Stretch j� 
AlignmentX !� Visual��%�   &	        !� 5      $
	 None=�60   $	
 0.3Q�6@   $
 None=�6N   $
 Left=�6]    5      �� 5      $��请输入用户名��6%   5      5      .��6!   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      P� 5       P� Property � �� P� Value 62   Z� . �5      ��  �� Property � �� �� Value# [  6;   5      P� 5       � ��$  ��62   . �5      ��  � ��# [  6;   5      5!      .��5"      5#      �� 5$   
   -   5        $ Label2��5$      $��	密码：��6    $
��Left=�6.   $��69��6I   $��
23,170,0,0q�6U   $	��Top=�6i   $	��120��6�   $��20(�6�   �� 5%   
   -   5         ��Name$ loginButton��5%      $��登录��6&   $
��Left=�63   $��58��6N   $��148,238,0,0q�6Z   $	��Top=�6o   $	��202��6�   $��36(�6�    J� Opacity$	 0.8Q�6�   ���	#FF5FCCF4���	#FF3834CB���	#FF36823A �� 	IsDefault . 6  �� 5&   
   $��Student schedule��6   $
��Left=�6+   $��62��6F   $��
111,10,0,0q�6R   $	��Top=�6f   $	��275��6~   $��36(�6�   $��Impact)�6�   $��Center=�6�   $��Center=�6�    J� RenderTransformOrigin$ 0.339,0.504&�6�   G� 5'   
   -   5         G�Name$ PasswordBox��5'      $
��Left=�6+   $��35��6F   $��
88,166,0,0q�6R   $	��Top=�6f   $	��335��6~   $��4q�6�   $��22(�6�   $��2��6�   �� 5(   
   -   5        $ registeredButton��5(      $��注册��6+   $
��Left=�68   $��35��6S   $��
428,97,0,0q�6_   $	��Top=�6s   $��50��6�   $��0q�6�   $��18(�6�   
�������
�������6�   5)      5*      