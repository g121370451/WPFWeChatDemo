﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFWeChatDemo.Controls;

namespace WPFWeChatDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LoginTypeButton_MouseMove(object sender, MouseEventArgs e)
        {
            LoginTypeButton? loginTypeButton = sender as LoginTypeButton;
            if (loginTypeButton.IsChecked != true)
            {
                loginTypeButton.ImageSourcePath = "pack://application:,,,/Assets/QQ_check.png";
            }
        }

        private void LoginTypeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            LoginTypeButton? loginTypeButton = sender as LoginTypeButton;

            if (loginTypeButton.IsChecked != true)
            {
                loginTypeButton.ImageSourcePath = "pack://application:,,,/Assets/QQ_not_check.png";
                loginTypeButton.Foreground = new SolidColorBrush(Color.FromRgb(0xB7, 0xB7, 0xB7));
            }
        }

        private void LoginTypeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            LoginTypeButton? loginTypeButton = sender as LoginTypeButton;
            loginTypeButton.IsChecked = true;
            loginTypeButton.Foreground = new SolidColorBrush(Color.FromRgb(0x11,0x91,0xff));
            loginTypeButton.ImageSourcePath = "pack://application:,,,/Assets/QQ_check.png";
        }
    }
}
