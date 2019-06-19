using System;
using System.Windows;
using WpfClientApp.Managers;

namespace WpfClientApp
{
    public partial class MainWindow : Window
    {
        ApiManagers api = new ApiManagers();
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

            UserInfo user = new UserInfo()
            {
                UserName = tbUserName.Text,
                Password = pbPassword.Password.ToString()
            };

            bool registration = (api.GetValue(user.UserName, user.Password));
            
            if(registration)
            {
                ChatWindow chatWindow = new ChatWindow();
                chatWindow.Show();
                this.Close();
            }                   
            else
            {
                MessageBox.Show("што то пошло не так");
            }             
        }

        private void Button_ClickRegistration(object sender, RoutedEventArgs e)
        {

        }
    }
}
