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
using System.Windows.Forms;

namespace GUI_Draft_Assistant
{
    /// <summary>
    /// Logique d'interaction pour SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        Settings settings;
        public SettingsWindow()
        {
            InitializeComponent();
            settings = new Settings();
        }

        private void Home_Menu(object sender, RoutedEventArgs e)
        {
            
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void DataButton_Click(object sender, RoutedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    settings.DataPath = fbd.SelectedPath + @"\Database.JSON";
                }
            }
        }
        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    settings.HistoryPath = fbd.SelectedPath + @"\History.txt";
                }
            }
        }
    }
}
