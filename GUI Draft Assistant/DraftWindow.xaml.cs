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
using System.Windows.Shapes;

namespace GUI_Draft_Assistant
{
    /// <summary>
    /// Logique d'interaction pour DraftWindow.xaml
    /// </summary>
    public partial class DraftWindow : Window
    {
        public DraftWindow()
        {
            InitializeComponent();
            DraftMenu.Visibility = Visibility.Visible;
            FirstPick.Visibility = Visibility.Collapsed;
            SecondPick.Visibility = Visibility.Collapsed;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            DraftMenu.Visibility = Visibility.Collapsed;
            FirstPick.Visibility = Visibility.Visible;
            SecondPick.Visibility = Visibility.Collapsed;
            Output1.Text = "Quels sont les bans ?";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            DraftMenu.Visibility = Visibility.Collapsed;
            FirstPick.Visibility = Visibility.Collapsed;
            SecondPick.Visibility = Visibility.Visible;
            Output2.Text = "Quels sont les bans ?";
        }

        private void Input1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string input = Input1.Text;
                Input1.Text = "";
                string[] inputList = input.Split(',');

            }
        }

        private void Input2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string input = Input2.Text;
                Input2.Text = "";
                string[] inputList = input.Split(',');

            }
        }
    }
}
