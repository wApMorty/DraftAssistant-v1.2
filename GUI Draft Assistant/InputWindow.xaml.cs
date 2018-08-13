using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logique d'interaction pour InputWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {
        public InputWindow()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Settings s = new Settings();
                Champion[] champions = JsonConvert.DeserializeObject<Champion[]>(File.ReadAllText(s.DataPath));
                string input = e.Source as string;
                using (StreamWriter sw = File.AppendText(s.HistoryPath)) //On ajoute la ligne saisie au fichier texte
                {
                    sw.WriteLine(input);
                }
                string[] splitChampions = input.Split(',');

                //TO DO
                //Ajouter un algorithme de saisie des donnees a partir du fichier Historique.txt


                Team winComp = new Team();
                Team loseComp = new Team();

                //Remplissage des équipes
                for (int i = 0; i < 5; i++)
                {
                    winComp.Add(champions.SingleOrDefault(item => item.Name == splitChampions[i]));
                    loseComp.Add(champions.SingleOrDefault(item => item.Name == splitChampions[i + 5]));
                }

                //Modification des stats
                //Equipe gagnante
                foreach (Champion c in winComp)
                {
                    c.WinWith(winComp);
                    c.WinAgainst(loseComp);
                }

                //Equipe perdante
                foreach (Champion c in loseComp)
                {
                    c.LoseAgainst(winComp);
                    c.LoseWith(loseComp);
                }
            }
        }
    }
}
