using System;
using System.Windows;
using WpfClientApp.Managers;

namespace WpfClientApp
{
    public partial class MainWindow : Window
    {
        ApiManagers api = new ApiManagers();
        UserWpf user = new UserWpf();        
        public MainWindow()
        {
            InitializeComponent();
        } 
        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            //if (isConnected)
            //{
            //    Disconnected();
            //}
            //else
            //{
            //    Connected();
            //}
        }
        public void Connected()
        {                   
            //tbUserName.IsEnabled = false;
            //btnConnect.Content = "Disconnect";
            //if (!isConnected)
            //{
            //    isConnected = true;
            //}
        }
        public void Disconnected()
        {
            //btnConnect.Content = "Connect";
            //tbUserName.IsEnabled = true;
            //if (isConnected)
            //{
            //    isConnected = false;
            //}
        }
        public void Button_ClickConnect(object sender, RoutedEventArgs e)
        {           
            if(!string.IsNullOrEmpty(tbUserName.Text))
            {
                user.UserName = tbUserName.Text;
                if(!string.IsNullOrEmpty(pbPassword.Password.ToString()))
                {
                    user.Password = pbPassword.Password.ToString();
                    bool registration = (api.GetValue(user.UserName, user.Password));
                    if (registration)
                    {
                        ChatWindow();                        
                    }
                    else
                    {
                        MessageBox.Show("Што то пошло не так");
                    }
                }
                else
                {
                    MessageBox.Show("Введите пароль.");
                }
            }
            else
            {
                MessageBox.Show("Введите имя пользователя.");
            }           
        }

        //private void Button_ClickRegistration(object sender, RoutedEventArgs e)
        //{            
        //    if (!string.IsNullOrEmpty(tbUserName.Text))
        //    {
        //        user.UserName = tbUserName.Text;
        //        if (!string.IsNullOrEmpty(pbPassword.Password.ToString()))
        //        {
        //            user.Password = pbPassword.Password.ToString();
        //            bool registration = (api.PostValue(user));
        //            if (registration)
        //            {
        //                ChatWindow();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Што то пошло не так");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Введите пароль.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Введите имя пользователя.");
        //    }
        //}

        public void ChatWindow()
        {
            user.isActive = true;
            ChatWindow chatWindow = new ChatWindow();
            chatWindow.Show();
            chatWindow.lbUsers.Items.Add(user.UserName);
            chatWindow.lbChat.Items.Add($"{DateTime.Now.ToString("HH:mm:ss")} Пользователь {user.UserName} присоединился к чату");
            Close();
        }

        private void Button_ClickRegistration(object sender, RoutedEventArgs e)
        {

        }
    }
}
