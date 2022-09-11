using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Configuration;
using System.Collections.Specialized;

namespace winforms_app_cvic3
{
    
    static class Difficulty
    {
        public static int level;
        //1 = normal, zakladni obtiznost


    }

    interface IGameForm_symbol
    {
        string symbolText { get; set; }
        string symbolResult { get; set; }
        void skore(int skore_int);
        void zivoty();
    }
    interface IGameForm_pocitani
    {
        string pocitaniResult { get; set; }
        int labelNalevo { get; }
        int labelNapravo { get; }
        int labelNahore { get; }
        int labelDole { get; }
        void skore(int skore_int);
        void zivoty();
        // udelej krychly
        void krychlePridej(int x, int y);
        // smaz krychle
        void krychleSmaz();
        // reset pocitani timer
        void pocitaniTimerReset();

    }
    interface IGameForm_barvy
    {
        string sekvenceResult { get; set; }
        System.Drawing.Color picturebox1Color { get; set; }
        void skore(int skore_int);
        void zivoty();
    }

    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]

        public static void Reset(this Timer timer)
        {
            timer.Stop();
            timer.Start();
        }
        static void Main()
        {

            /*XmlSerializer xs;
            List<XmlNastaveni> ls;
            ls = new List<XmlNastaveni>();
            FileStream fs = new FileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "predchozi_nastaveni.Xml"), FileMode.Create, FileAccess.Write);
            XmlNastaveni xn = new XmlNastaveni();
            xs = new XmlSerializer(typeof(List<XmlNastaveni>));
            xn.Obtiznost = 1;
            xn.Hry = "000";
            ls.Add(xn);
            xs.Serialize(fs, ls);
            fs.Close();*/


            Difficulty.level = 1;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainMenuForm mainMenuForm = new MainMenuForm();
            GameOptionsForm gameOptionsForm = new GameOptionsForm();
            GameForm gameForm = new GameForm();
            Application.Run(mainMenuForm);
            if (mainMenuForm.otevrenoGameOptions)
            {                
                Application.Run(gameOptionsForm);
                if (gameOptionsForm.otevrenoGameForm)
                {
                    if (gameOptionsForm.sekvenceAktivovano)
                    {
                        gameForm.sekvenceAktivni=true;
                    }
                    if (gameOptionsForm.pocitaniAktivovano)
                    {
                        gameForm.pocitaniAktivni = true;
                    }
                    if (gameOptionsForm.symbolAktivovano)
                    {
                        gameForm.symbolAktivni = true;
                    }

                    Application.Run(gameForm);
                }
            }
            
            

        }

    }
}
