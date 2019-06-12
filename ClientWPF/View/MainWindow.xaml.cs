using ClientWPF.Models;
using System.Windows;


namespace ClientWPF
{  
    public partial class MainWindow : Window
    {
        bool isConnected = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if(isConnected)
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
            UserInfo user = new UserInfo{
                UserName = tbUserName.Text
            };
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
    }
}
