﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Draft_Assistant
{
    public class Champion : INotifyPropertyChanged
    {

        public string Name { get; set; }
        public double Winrate { get; set; }
        public int Number
        {
            get
            {
                switch (this.Name)
                {
                    case "Aatrox": return 1;
                    case "Ahri": return 2;
                    case "Akali": return 3;
                    case "Alistar": return 4;
                    case "Amumu": return 5;
                    case "Anivia": return 6;
                    case "Annie": return 7;
                    case "Ashe": return 8;
                    case "AurelionSol": return 9;
                    case "Azir": return 10;
                    case "Bard": return 11;
                    case "Blitzcrank": return 12;
                    case "Brand": return 13;
                    case "Braum": return 14;
                    case "Caitlyn": return 15;
                    case "Camille": return 16;
                    case "Cassiopeia": return 17;
                    case "ChoGath": return 18;
                    case "Corki": return 19;
                    case "Darius": return 20;
                    case "Diana": return 21;
                    case "DrMundo": return 22;
                    case "Draven": return 23;
                    case "Ekko": return 24;
                    case "Elise": return 25;
                    case "Evelynn": return 26;
                    case "Ezreal": return 27;
                    case "Fiddlesticks": return 28;
                    case "Fiora": return 29;
                    case "Fizz": return 30;
                    case "Galio": return 31;
                    case "Gangplank": return 32;
                    case "Garen": return 33;
                    case "Gnar": return 34;
                    case "Gragas": return 35;
                    case "Graves": return 36;
                    case "Hecarim": return 37;
                    case "Heimerdinger": return 38;
                    case "Illaoi": return 39;
                    case "Irelia": return 40;
                    case "Ivern": return 41;
                    case "Janna": return 42;
                    case "JarvanIV": return 43;
                    case "Jax": return 44;
                    case "Jayce": return 45;
                    case "Jhin": return 46;
                    case "Jinx": return 47;
                    case "KaiSa": return 48;
                    case "Kalista": return 49;
                    case "Karma": return 50;
                    case "Karthus": return 51;
                    case "Kassadin": return 52;
                    case "Katarina": return 53;
                    case "Kayle": return 54;
                    case "Kayn": return 55;
                    case "Kennen": return 56;
                    case "KhaZix": return 57;
                    case "Kindred": return 58;
                    case "Kled": return 59;
                    case "KogMaw": return 60;
                    case "Leblanc": return 61;
                    case "LeeSin": return 62;
                    case "Leona": return 63;
                    case "Lissandra": return 64;
                    case "Lucian": return 65;
                    case "Lulu": return 66;
                    case "Lux": return 67;
                    case "Malphite": return 68;
                    case "Malzahar": return 69;
                    case "Maokai": return 70;
                    case "MaitreYi": return 71;
                    case "MissFortune": return 72;
                    case "Mordekaiser": return 73;
                    case "Morganna": return 74;
                    case "Nami": return 75;
                    case "Nasus": return 76;
                    case "Nautilus": return 77;
                    case "Nidalee": return 78;
                    case "Nocturne": return 79;
                    case "Nunu": return 80;
                    case "Olaf": return 81;
                    case "Orianna": return 82;
                    case "Ornn": return 83;
                    case "Pantheon": return 84;
                    case "Poppy": return 85;
                    case "Pyke": return 86;
                    case "Quinn": return 87;
                    case "Rakan": return 88;
                    case "Rammus": return 89;
                    case "RekSai": return 90;
                    case "Renekton": return 91;
                    case "Rengar": return 92;
                    case "Riven": return 93;
                    case "Rumble": return 94;
                    case "Ryze": return 95;
                    case "Sejuani": return 96;
                    case "Shaco": return 97;
                    case "Shen": return 98;
                    case "Shyvana": return 99;
                    case "Singed": return 100;
                    case "Sion": return 101;
                    case "Sivir": return 102;
                    case "Skarner": return 103;
                    case "Sona": return 104;
                    case "Soraka": return 105;
                    case "Swain": return 106;
                    case "Syndra": return 107;
                    case "TahmKench": return 108;
                    case "Taliyah": return 109;
                    case "Talon": return 110;
                    case "Taric": return 111;
                    case "Teemo": return 112;
                    case "Thresh": return 113;
                    case "Tristana": return 114;
                    case "Trundle": return 115;
                    case "Tryndamere": return 116;
                    case "TwistedFate": return 117;
                    case "Twitch": return 118;
                    case "Udyr": return 119;
                    case "Urgot": return 120;
                    case "Varus": return 121;
                    case "Vayne": return 122;
                    case "Veigar": return 123;
                    case "VelKoz": return 124;
                    case "Vi": return 125;
                    case "Viktor": return 126;
                    case "Vladimir": return 127;
                    case "Volibear": return 128;
                    case "Warwick": return 129;
                    case "Wukong": return 130;
                    case "Xayah": return 131;
                    case "Xerath": return 132;
                    case "XinZhao": return 133;
                    case "Yasuo": return 134;
                    case "Yorick": return 135;
                    case "Zac": return 136;
                    case "Zed": return 137;
                    case "Ziggs": return 138;
                    case "Zilean": return 139;
                    case "Zoe": return 140;
                    case "Zyra": return 141;
                    default: return 999;
                }
            }
        }
        public double[,] AllyWinrate; //Format [Win avec, Lose avec] pour chaque champion
        public double[,] EnemyWinrate; //Format [Win contre, Lose contre] pour chaque champion

        //TO DO : Gerer ca
        public event PropertyChangedEventHandler PropertyChanged;

        public Champion(string n)
        {
            this.Name = n;
            AllyWinrate = new double[141, 2];
            EnemyWinrate = new double[141, 2];
            for (int i = 0; i < 141; i++)
            {
                AllyWinrate[i, 0] = 0;
                EnemyWinrate[i, 0] = 0;
                AllyWinrate[i, 1] = 0;
                EnemyWinrate[i, 1] = 0;
            }
        }

        public override string ToString() => this.Name;

        #region Methodes de calcul des winrates
        public double GetWinrate()
        {
            double winrate = 0;
            if ((AllyWinrate[this.Number - 1, 0] + AllyWinrate[this.Number - 1, 1] > 10))
            {
                winrate = AllyWinrate[this.Number - 1, 0] / (AllyWinrate[this.Number - 1, 0] + AllyWinrate[this.Number - 1, 1]);
            }
            this.Winrate = winrate;
            return winrate;
        }

        public double GetWinrateWith(Team compo)
        {
            double totalWins = 0;
            double totalLoss = 0;
            double winrate = 0;
            foreach (Champion champ in compo)
            {
                totalWins += AllyWinrate[champ.Number - 1, 0];
                totalLoss += AllyWinrate[champ.Number - 1, 1];
            }
            if (totalWins + totalLoss < 10)
            {
                winrate = totalWins / (totalLoss + totalWins);
            }
            this.Winrate = winrate;
            return winrate;
        }
        public double GetWinrateAgainst(Team compo)
        {
            double totalWins = 0;
            double totalLoss = 0;
            foreach (Champion champ in compo)
            {
                totalWins += EnemyWinrate[champ.Number - 1, 0];
                totalLoss += EnemyWinrate[champ.Number - 1, 1];
            }
            if (totalWins + totalLoss < 10)
            {
                return 0;
            }
            this.Winrate = totalWins / (totalLoss + totalWins);
            return totalWins / (totalLoss + totalWins);
        }
        public double GetWinrate(Team alliedComp, Team enemyComp)
        {
            return (GetWinrateWith(alliedComp) + GetWinrateAgainst(enemyComp) + GetWinrate()) / 3;
        }
        #endregion

        #region Methodes de gestion des winrates
        public void WinWith(Team compo)
        {
            foreach (Champion champ in compo)
            {
                this.AllyWinrate[champ.Number - 1, 0] += 1;
            }
        }
        public void WinAgainst(Team compo)
        {
            foreach (Champion champ in compo)
            {
                this.EnemyWinrate[champ.Number - 1, 0] += 1;
            }
        }
        public void LoseWith(Team compo)
        {
            foreach (Champion champ in compo)
            {
                this.AllyWinrate[champ.Number - 1, 1] += 1;
            }
        }
        public void LoseAgainst(Team compo)
        {
            foreach (Champion champ in compo)
            {
                this.EnemyWinrate[champ.Number - 1, 1] += 1;
            }
        }
        #endregion

    }
}
