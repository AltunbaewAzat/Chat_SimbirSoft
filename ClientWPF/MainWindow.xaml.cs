using System.Windows;


namespace ClientWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
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
            tbUserName.IsEnabled = false;
            if (!isConnected)
            {
                isConnected = true;
            }
        }
        public void Disconnected()
        {
            tbUserName.IsEnabled = true;
            if (isConnected)
            {
                isConnected = false;
            }
        }
    }
}
