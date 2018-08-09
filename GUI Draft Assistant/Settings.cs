using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Draft_Assistant
{
    static class Settings
    {
        public static string DataPath;
        public static DialogResult HistoryPath;

        public static void SetDataPath(string p)
        {
            DataPath = p;
        }

        public static void SetHistoryPath(DialogResult p)
        {
            HistoryPath = p;
        }

    }
}
