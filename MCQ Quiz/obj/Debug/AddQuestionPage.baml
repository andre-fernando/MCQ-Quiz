   M S B A M L   `   `   `  ����C  ?MCQ Quiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MCQ_QuizMCQ_Quiz  5          MCQ_Quiz.AddQuestionPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:MCQ_Quiz     5        N� Title$  AddQuextionPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $	��tbQ��5      $��
Question :��6   $��0��61   $��Center=�6>   $
��Left=�6Y   $��20,0,0,0q�6t   �� 5   
   -   5        $��tboxQ��5      $��0��6   $��Center=�6,   $
��Left=�6G   $��90,0,0,0q�6b   $��30��6t   $	��480��6�   �� 5   
   -   5        $	��tbA��5      $��
Option A :��6   $��1��61   $��Center=�6>   $
��Left=�6Y   $��20,0,0,0q�6t   �� 5   
   -   5        $��tboxA��5      $��1��6   $��Center=�6,   $
��Left=�6G   $��90,0,0,0q�6b   $��30��6t   $	��400��6�   �� 5   
   -   5        $	��tbB��5      $��
Option B :��6   $��2��61   $��Center=�6>   $
��Left=�6Y   $��20,0,0,0q�6t   �� 5   
   -   5        $��tboxB��5      $��2��6   $��Center=�6,   $
��Left=�6G   $��90,0,0,0q�6b   $��30��6t   $	��400��6�   �� 5   
   -   5        $	��tbC��5      $��
Option C :��6   $��3��61   $��Center=�6>   $
��Left=�6Y   $��20,0,0,0q�6t   �� 5   
   -   5        $��tboxC��5      $��3��6   $��Center=�6,   $
��Left=�6G   $��90,0,0,0q�6b   $��30��6t   $	��400��6�   �� 5!   
   -	   5        $	��tbD��5!      $��
Option D :��6   $��4��61   $��Center=�6>   $
��Left=�6Y   $��20,0,0,0q�6t   �� 5"   
   -
   5        $��tboxD��5"      $��4��6   $��Center=�6,   $
��Left=�6G   $��90,0,0,0q�6b   $��30��6t   $	��400��6�   �� 5$   
   -   5        $	��tbS��5$      $��
Solution :��6   $��5��61   $��Center=�6>   $
��Left=�6Y   $��20,0,0,0q�6t   �� 5%   
   -   5        $��tboxS��5%      $��5��6   $��Center=�6,   $
��Left=�6G   $��90,0,0,0q�6b   $��30��6t   $	��400��6�   �� 5'   
   $��6��6    �� Orientation$ 
Horizontal=�6"   .+�5(   
   �� -   5        $��btnAdd��5(      $	��Add��6   $��6��6-   $��25��6:   $��50��6F   $
��Left=�6Q   $��10,0,0,0q�6l   6~   �� 5)   
   -   5        $��btnClear��5)      $��Clear��6!   $��6��61   $��25��6>   $��50��6J   $
��Left=�6U   $��10,0,0,0q�6p   6�   �� 5*   
   -   5        $��btnEdit��5*      $
��Edit��6    $��6��6/   $��25��6<   $��50��6H   $
��Left=�6S   $��10,0,0,0q�6n   6�   �� 5+   
   -   5        $��btnFile��5+      $��Add from file��6    $��6��68   $��25��6E   $
��Auto��6Q   $��5,0,5,0q�6^   $
��Left=�6p   $��10,0,0,0q�6�   6�   �� 5,   
   -   5        $��btnSaveFile��5,      $��Save to File��6$   $��6��6;   $��25��6H   $
��Auto��6T   $��5,0,5,0q�6a   $
��Left=�6s   $��10,0,0,0q�6�   6�   �� 5-   
   -   5        $��btnHelp��5-      $
��Help��6    $��6��6/   $��25��6<   $
��Auto��6H   $��5,0,5,0q�6U   $
��Left=�6g   $��10,0,0,0q�6�   6�   �� 5.   
   -   5        $��btnDone��5.      $
��Done��6    $��6��6/   $��25��6<   $��50��6H   $
��Left=�6S   $��	130,0,0,0q�6n   6�   5/      50      51      