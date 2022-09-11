using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace winforms_app_cvic3
{
    public partial class GameOptionsForm : Form
    {
        public bool otevrenoGameForm { get; private set; }
        public bool symbolAktivovano { get; private set; }
        public bool pocitaniAktivovano { get; private set; }
        public bool sekvenceAktivovano { get; private set; }

        public GameOptionsForm()
        {

            InitializeComponent();
            // nacti data z configu
            if (ConfigurationManager.AppSettings.Get("Symbol") == "1")
            {
                symbolCheckbox.CheckState = CheckState.Checked;
                
            }
            if (ConfigurationManager.AppSettings.Get("Pocitani") == "1")
            {
                pocitaniCheckbox.CheckState = CheckState.Checked;
                

            }
            if (ConfigurationManager.AppSettings.Get("Sekvence") == "1")
            {
                sekvenceCheckbox.CheckState = CheckState.Checked;
                
            }
            
            VyberObtiznosti.Value = Int32.Parse(ConfigurationManager.AppSettings.Get("Obtiznost"));

        }

        // zacni program s vybranou obtiznosti a pouze s vybranymi hramy
        private void GameOptionsStartButton_Click(object sender, EventArgs e)
        {
            Difficulty.level = VyberObtiznosti.Value;
            ConfigurationManager.RefreshSection("appSettings");
            
            string hry = "";
            if (symbolCheckbox.CheckState == CheckState.Checked)
            {
                symbolAktivovano = true;
                ConfigurationManager.AppSettings.Set("Symbol", "1");
                
                hry += "1";
                
            }
            else
            {
                hry += "0";
                ConfigurationManager.AppSettings.Set("Symbol", "0");
            }
            if (pocitaniCheckbox.CheckState == CheckState.Checked)
            {
                pocitaniAktivovano = true;
                ConfigurationManager.AppSettings.Set("Pocitani", "1");
                hry += "1";
            }
            else
            {
                hry += "0";
                ConfigurationManager.AppSettings.Set("Pocitani", "0");
            }
            if (sekvenceCheckbox.CheckState == CheckState.Checked)
            {
                ConfigurationManager.AppSettings.Set("Sekvence", "1");
                sekvenceAktivovano = true;
                hry += "1";
            }
            else
            {
                hry += "0";
                ConfigurationManager.AppSettings.Set("Sekvence", "0");
            }
            
            // ukladani noveho nastaveni do config souboru
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Obtiznost"].Value = VyberObtiznosti.Value.ToString();
            config.AppSettings.Settings["Symbol"].Value = hry[0].ToString();
            config.AppSettings.Settings["Pocitani"].Value = hry[1].ToString();
            config.AppSettings.Settings["Sekvence"].Value = hry[2].ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            otevrenoGameForm = true;
            Close();
        }
    }
}
