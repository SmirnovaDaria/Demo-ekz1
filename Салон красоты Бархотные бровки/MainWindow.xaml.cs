using System;
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

namespace Салон_красоты_Бархотные_бровки
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Pages.AutorizationPage();
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Pages.AutorizationPage();
        }
    }
}
