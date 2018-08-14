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

namespace GUI_Draft_Assistant
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow w = new SettingsWindow();
            w.Show();
            this.Close();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Initializer.Initialize();
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            InputWindow w = new InputWindow();
            w.Show();
            this.Close();
        }
    }
}
