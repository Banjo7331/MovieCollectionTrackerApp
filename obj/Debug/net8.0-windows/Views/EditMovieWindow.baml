   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   T PMovieCollectionTrackerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MovieCollectionTrackerApp.Models MovieCollectionTrackerApp.Models 5   	   [2clr-namespace:MovieCollectionTrackerApp.ViewModels$MovieCollectionTrackerApp.ViewModels 5   	   5   /MovieCollectionTrackerApp.Views.EditMovieWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   0sys&clr-namespace:System;assembly=mscorlib  5   	   :local.clr-namespace:MovieCollectionTrackerApp.Models  5   	   C
viewModels2clr-namespace:MovieCollectionTrackerApp.ViewModels  5   	     � Title$  
Edit Movie��5   	   $	��300��6   $	��400��6)    � 	Resources 5	       S� 
MethodName S� 
ObjectTypeU QSystem.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a  System.Enum   
EnumValues S� MethodParameters M� TypeName��%z   &	        S� 5
   
   $ 	GetValues��6   "  64    5      M� 5      $ local:MovieCategory��6   5      5      .��5      � .+�5   
   �� $��10q�6   .+�5      �� $��
Edit Movie��6   $��20(�6*   $��Center=�68   $��0,0,0,10q�6U   �� 5      $��5q�6R   ��6   �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=�6R   �� 5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Category��5       �� DisplayMemberPath$ .��5      $��5q�5      ��5      �� 8  2MovieCollectionTrackerApp.ViewModels.MainViewModel	   
Categories
 �� Source#
 Z	  �� SelectedItem 5      �� *
Category+$ PropertyChanged=�5      �� 5      $��5q�6U   ��6   �� *
Director+$ PropertyChanged=�6U   �� 5      $��5q�6X   ��6   �� *ReleaseYear+$ PropertyChanged=�6X   �� 5       $��5q�6S   ��6   �� *Rating+$ PropertyChanged=�6S   �� 5"      -   5        $
��Save��5"      $��Center=�6=   $��10q�6Z   5#      5$      5%      