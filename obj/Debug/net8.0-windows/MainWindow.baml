   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   T PMovieCollectionTrackerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MovieCollectionTrackerApp.Models MovieCollectionTrackerApp.Models 5   	   [2clr-namespace:MovieCollectionTrackerApp.ViewModels$MovieCollectionTrackerApp.ViewModels 5	   	   *   $MovieCollectionTrackerApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   0sys&clr-namespace:System;assembly=mscorlib  5   	   :local.clr-namespace:MovieCollectionTrackerApp.Models  5   	   C
viewModels2clr-namespace:MovieCollectionTrackerApp.ViewModels  5	   	     � Title$  Movie Collection Tracker��5   	   $	��450��6*   $	��800��67    � 	Resources 5       S� 
MethodName S� 
ObjectTypeU QSystem.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a  System.Enum   
EnumValues S� MethodParameters M� TypeName��%z   &	        S� 5   
   $ 	GetValues��6   "  64    5      M� 5      $ local:MovieCategory��6   5      5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5#   
   �� $��Movie Collection Tracker��6   $��24(�5$      $
��Bold"�5%      $��Center=�5&      $��0,0,0,10q�5'      $��0��5(      �� 5+   
   $��0,0,0,10q�5-      $��1��5.      ��5+      �� *Movies+ �� SelectedItem 5,      �� *SelectedMovie+	 �� View	 5/      �� 50      .P�51      �� $��Title��6%   
 �� Width$	
 150��6[    �� DisplayMemberBinding 64   �� *Title+6[   �� 52      $��Category��6%   $	
 100��6a    67   �� *
Category+6a   �� 53      $��Director��6%   $	
 150��6a    67   �� *
Director+6a   �� 54      $
��Year��6%   $
 80��6`    63   �� *ReleaseYear+6`   �� 55      $��Rating��6%   $
 80��6]    65   �� *Rating+6]   56      58      � 5;   
   $��2��6   $��	0,10,0,10q�6    5<      �� 5=      $��1* �6#   �� 5>      $��1* �6#    5@      �� 5A      $
��Auto �6    �� 5B      $
��Auto �6    �� 5C      $
��Auto �6    �� 5D      $
��Auto �6    .+�5G      �� $��0��6   $��0��6#   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Title��5H      $��5q�5J      ��5I      �� *SelectedMovie.Title+ �� UpdateSourceTrigger$ PropertyChanged=�5J      �� 5K      $��1��6   $��0��6$   $ Category��5N       �� DisplayMemberPath$ .��5O      $��5q�5P      ��5L      �� 8  2MovieCollectionTrackerApp.ViewModels.MainViewModel   
Categories �� Source# Z  5M      �� *SelectedMovie.Category+5P      �� 5W      $��2��6   $��0��6#   $ Director��5X      $��5q�5Z      ��5Y      �� *SelectedMovie.Director+$ PropertyChanged=�5Z      �� 5\      $��0��6   $��1��6#   $
 Year��5]      $��5q�5_      ��5^      �� *SelectedMovie.ReleaseYear+$ PropertyChanged=�5_      �� 5a      $��1��6   $��1��6#   $ Rating��5b      $��5q�5d      ��5c      �� *SelectedMovie.Rating+$ PropertyChanged=�5d      5e      �� 5h   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��0,10,0,0q�6X   .+�5i      �� $	��Add��6   $��5q�6G   ��6#   �� *AddMovieCommand+6G   �� 5j      $
��Edit��6   $��5q�6I   ��6$   �� *EditMovieCommand+6I   �� 5k      $��Delete��6   $��5q�6M   ��6&   �� *DeleteMovieCommand+6M   �� 5l      $��View Statistics��6   $��Center=�5n      $��5q�5o      ��5m      �� *OpenStatisticsWindowCommand+5o      5p      5q      5r      