   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   !localclr-namespace:Library  5   	      
Background#���   5	   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��
LanguageBt��5       
 Button#���  6#   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��6I   $��2��6w   $��0��6�   $��50��6�   $��	10,0,10,0q�6�   #���  6�   .��5      �� -   5        $��LanguageImg��5      $��50��6'   $��Center=�63   $��img\russia.png��6N   5      �� 5   
   -   5        $��ThemesBt��5      #���  6!   $ 10��6G   $��3��6v   $��0��6�   $��50��6�   $��	10,0,10,0q�6�   #���  6�   .��5      �� -   5        $��	ThemesImg��5      $��35��6%   $��img\blue.png��61   5       �� 5!   
    �� Padding$ 5q�6     Font#���  6      	TextBlock#���  6D   $��1��6m   $��2��6}   $��2��6�     TextBox1#���  6�   $
��18pt(�6�   $��Center=�6�   $��10,0,0,0q�6�   �� 5"   
   -   5        $��TextTbx��5"   ]   #���  6     TextBox#���  66   $��3��6l   $��3��6�   $��10,10,10,10q�6�   $��1��6�     Hint)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6�   $
��14pt(�6�   $��5q�6�   �� 5#   
   -   5        $��nameTbk��5#   a   #���  6   #���  68    	 Title#���  6p   $
��20pt(�6�   $��Center=�6�   $��Center=�6�   $��0��6�   $
��Bold"�6�   �� 5$   
   -   5        $��AddBt��5$   [   #���  6   #���  65     Add#���  6h   $��1��6�   $��7��6�   $
��12pt(�6�   $��50��6�   #���  6�   �� 5%   
   -   5        $��EditBt��5%   [   #���  6   #���  65   $��2��6i    	 Edit#��� 	 6y   $��7��6�   $
��12pt(�6�   $��50��6�   #���  6�   �� 5&   
   -	   5        $��RemoveBt��5&   [   #���  6   #���  65   $��3��6k   $��7��6{    

 Remove#��� 
 6�   $
��12pt(�6�   $��50��6�   #���  6�   �� 5'   
   -
   5        $��listbox��5'   \   #���  6   #���  66   $��7��6k   $��0��6|   $
��10pt(�6�   $��0,62,5,0q�6�   5(      5)      