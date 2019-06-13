﻿using System.Windows;
using WpfClientApp.Managers;

namespace WpfClientApp
{  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool isConnected = false;

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (isConnected)
            {
                Disconnected();
            }
            else
            {
                Connected();
            }
        }
        public void Connected()
        {
            UserInfo user = new UserInfo()
            {
                UserName = tbUserName.Text
            };
            ApiManagers api = new ApiManagers();
            tbUserName.IsEnabled = false;
            btnConnect.Content = "Disconnect";
            if (!isConnected)
            {
                isConnected = true;
            }
        }
        public void Disconnected()
        {
            btnConnect.Content = "Connect";
            tbUserName.IsEnabled = true;
            if (isConnected)
            {
                isConnected = false;
            }
        }
        private void Button_ClickConnect(object sender, RoutedEventArgs e)
        {
            ChatWindow chatWindow = new ChatWindow();
            chatWindow.Show();
            this.Close();
        }
    }
}