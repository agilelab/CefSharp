﻿using System.Windows;
using CefSharp.Wpf.Example.Views.Main;

namespace CefSharp.Wpf.Example
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var mainView = new MainView
            {
                DataContext = new MainViewModel()
            };

            Content.Content = mainView;
        }
    }
}
