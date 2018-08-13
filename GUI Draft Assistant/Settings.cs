using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GUI_Draft_Assistant
{
    public class Settings : ApplicationSettingsBase
    {
        [UserScopedSetting]
        public string DataPath
        {
            get => this.DataPath;
            set
            {
                this["DataPath"] = value;
            }
        }

        [UserScopedSetting]
        public string HistoryPath
        {
            get => this.HistoryPath;
            set
            {
                this["HistoryPath"] = value;
            }
        }


    }
}
