using System.Windows;
using TeleCompany.Pages;

namespace TeleCompany
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.Content = new Auth();
        }
    }
}
