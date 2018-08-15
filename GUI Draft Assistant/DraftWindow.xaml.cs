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
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Draft1Window w = new Draft1Window();
            w.Show();
            this.Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Draft2Window w = new Draft2Window();
            w.Show();
            this.Close();
        }
    }
}
