   M S B A M L   `   `   `  ����@  <Glina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Glina.ViewsGlina.Views  5      #    Glina.Views.AuthorizationView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      +viewsclr-namespace:Glina.Views     5      
������ $	��650��5      $
��1080��5	        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $R Lpack://application:,,,/Styles/AuthorisationView/AuthorisationViewStyles.xaml?�5      �� 5      $P Jpack://application:,,,/Styles/RegistrationView/RegistrationViewStyles.xaml?�5      %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��1.25* �6   .+�5!   
   ��  �� CornerRadius$ 	10 0 0 10��6   ��5"      �� 5#       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5$      �  � Color$ #1C1D21��6#    � Offset$ 0Q�63   5%      ._�5(      �� $2��,../Assets/AuthorisationWindow/LoginInput.png��6   $��89,157,217,391q�6J   5)      �� 5+   
   $��74,290,135,315q�6   $ 5��6)   ._�5,      � $	��7 9q�6    5-      �� 5.      $
��auto �6'   �� 5/      $��* �6'   .+�52      �� -   5        	 ��Name$	 	textLogin��52      $��
Логин��53         TextHint#��[  54      $��2��55      $��	10,0,22,0q�56      �� 57      -   5        $��txtLogin��57      $��2��58        TextBox#��[ 59      $��	10,0,10,0q�5:      5;      5<      �� 5>   
   $��74,335,135,273q�6   $ 5��6)   ._�5?      � $��7,9,30,9q�6    5@      �� 5A      $
��auto �6'   �� 5B      $��* �6'   .+�5E      �� -   5        $	 textPassword��5E   5   
������ $��Пароль��5F      #��[  5G      $��10,0,0,0q�5H      $��1��6.   �� 5I      -   5        
 ��Name$
 txtBox��5I      #��[ 5J      $��2��5K      $��
10,0,-14,0q�5L      G� 5M      -   5         G�Name$ txtPassword��5M      #��[ 5N      $��2��5O      $��
10,0,-14,0q�5P      5Q      5R      �� 5T   
   -   5         ��Name$ visiblePass��5T      $��302,346,158,288q�6&     IconsButton#��[ 5U      $��20��66   $��20��6A   .��5V      �� $0��*../Assets/AuthorisationWindow/hidePass.png��6   5W      �� 5Y   
   -   5        $ 
hiddenPass��5Y      $y�Hidden=�6%   $��302,346,158,288q�69   #��[ 5Z      $��20��66   $��20��6A   .��5[      �� $+��%../Assets/AuthorisationWindow/Eye.png��6   5\      �� 5^   
   ._�5_      �� $��89,390,300,242q�6     ForgetPassButton#��[ 5`      $ ��Забыли пароль?��6?   5a      �� 5c   
   $��
Войти��6     EntryButton#��[ 6!   $��86,433,155,185q�5d      �� 5f   
   $-��'../Assets/AuthorisationWindow/noAcc.png��6   $��89,553,320,77q�6A   �� 5h   
   $��Создать��5i      $��Registration��5k      $��240,545,163,70q�5l        CreateButton#��[ 5m      ��5j      �� *NavigateCommand+5m      "   Glina.Views.RightRegLogPanel  5p   
   $��1��6!   5r      5u      