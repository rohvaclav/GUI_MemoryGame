using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_app_cvic3
{
    public partial class GameForm : Form, IGameForm_symbol, IGameForm_pocitani, IGameForm_barvy//, IGameForm_universal
    {
        public bool sekvenceAktivni = false;
        public bool symbolAktivni = false;
        public bool pocitaniAktivni = false;
        private SekvenceBarev sekvenceBarev;
        private OpakujiciSymbol opakujiciSymbol;
        private Pocitani pocitani;
        private int secondsToWait = 10;
        private DateTime startTime;
        public DateTime startTime2;
        private int barvyKliknuti = 0;


        Random rand = new Random();
        public List<PictureBox> items = new List<PictureBox>();

        //symbol
        public string symbolText
        {
            get { return symbolTextBox.Text; }
            set { symbolTextBox.Text = value; }
        }
        public string symbolResult
        {
            get { return symbolTextBox_result.Text; }
            set { symbolTextBox_result.Text = value; }
        }
        //pocitani
        public string pocitaniResult
        {
            get { return pocitaniTextBox_result.Text; }
            set { pocitaniTextBox_result.Text = value; }
        }
        public int labelNalevo
        {
            get { return labelCara_nalevo.Left; }
        }
        public int labelNapravo
        {
            get { return labelCara_napravo.Right; }
        }
        public int labelNahore
        {
            get { return labelCara_horni.Bottom; }
        }
        public int labelDole
        {
            get { return labelCara_spodni.Top; }
        }
        public void krychlePridej(int x, int y)
        {
            PictureBox krychle = new PictureBox();
            krychle.Height = 10;
            krychle.Width = 10;
            krychle.BackColor = Color.Black;

            Console.WriteLine("Nyni kreslim krychly na lokaci: " + x + ", " + y);
            krychle.Location = new Point(x, y);
            krychle.Visible = true;
            items.Add(krychle);            
            splitContainer1.Panel1.Controls.Add(krychle);
            Form.ActiveForm.Update();
        }
        public void krychleSmaz()
        {
            for (int i = 0; i < items.Count; i++)
            {
                splitContainer1.Panel1.Controls.Remove(items[i]);
            }
            items.Clear();
        }
        public void pocitaniTimerReset()
        {
            pocitaniTimer.Stop();
            startTime2 = DateTime.Now;
            pocitani.zobrazKruhy();
            pocitaniTimer.Start();
            // predchozi 2 radky prohodit? ale zatim to fungovalo ZDE MOZNA PROBLEM
        }
        //barvy
        public string sekvenceResult
        {
            get { return sekvenceTextBox_result.Text; }
            set { sekvenceTextBox_result.Text = value; }
        }
        public System.Drawing.Color picturebox1Color
        {
            get { return pictureBox1.BackColor; }
            set { pictureBox1.BackColor = value; } // zde bude problem?
        }
        //universal
        public void zivoty()
        {
            if(zivotyTextBox.Text != "")
            {
                zivotyTextBox.Text = zivotyTextBox.Text.Remove(zivotyTextBox.Text.Length - 1);
            }
            if (zivotyTextBox.Text == "")
            {
                pocitaniTimer.Stop();
                timer1.Stop();
                symbolTextBox.Enabled = false;
                MessageBox.Show("Konec hry! Konecne skore = " + skoreTextBox.Text);

                // zapis vysledku do csv souboru
                string path = "skore.csv";
                using (var w = File.AppendText(path))
                {
                    var first = DateTime.Now;
                    var second = Difficulty.level;
                    var third = skoreTextBox.Text;
                    string hry = "";
                    if (symbolAktivni)
                    {
                        hry += "1";
                    }
                    else
                    {
                        hry += "0";
                    }
                    if (pocitaniAktivni)
                    {
                        hry += "1";
                    }
                    else
                    {
                        hry += "0";
                    }
                    if (sekvenceAktivni)
                    {
                        hry += "1";
                    }
                    else
                    {
                        hry += "0";
                    }
                    var fourth = hry;
                    var line = string.Format("{0},{1},{2},{3}", first, second, third, fourth);
                    w.WriteLine(line);
                    w.Flush();
                   
                }
                Application.Exit();
            }
        }
        public void skore(int skore_int)
        {
            skoreTextBox.Text = (Int32.Parse(skoreTextBox.Text) + skore_int).ToString();
        }


        public GameForm()
        {
            InitializeComponent();    
            sekvenceBarev = new SekvenceBarev(this);
            opakujiciSymbol = new OpakujiciSymbol(this);
            pocitani = new Pocitani(this);
            skoreTextBox.Text = "0";
            zivotyTextBox.Text = "YYY";
            zivotyTextBox.BackColor = zivotyTextBox.BackColor;
            zivotyTextBox.ForeColor = Color.Red;

            // enabled = false zamezuje uzivateli interaktovat s objekty, ke kterym nema mit pristup.
            // readme je kvuli tomu redundanti, ale nicemu nevadi.
            timerTextBox.ReadOnly = true;
            timerTextBox.Enabled = false;
            timerTextBox2.ReadOnly = true;
            timerTextBox2.Enabled = false;
            symbolTextBox.ReadOnly = true;
            symbolTextBox_result.Enabled = false;
            pocitaniTextBox_result.Enabled = false;
            sekvenceTextBox_result.Enabled = false;
            skoreTextBox.ReadOnly = true;
            zivotyTextBox.ReadOnly = true;

            symbolTextBox.Enabled = false;
           
            numpadButton4.Enabled = false;
            numpadButton5.Enabled = false;
            numpadButton6.Enabled = false;
            numpadButton7.Enabled = false;
            numpadButton8.Enabled = false;
            numpadButton9.Enabled = false;

            blueColorButton.Enabled = false;
            greenColorButton.Enabled = false;
            redColorButton.Enabled = false;
         

        }

        //
        // kod sekvence barev
        //

        private void colorButton_Click(object sender, EventArgs e)
        {
            sekvenceBarev.zadanaSekvence[barvyKliknuti] = Convert.ToInt32((sender as Button).Tag);
            barvyKliknuti += 1;
            if (barvyKliknuti == Difficulty.level + 2)
            {
                barvyKliknuti = 0;
                sekvenceBarev.ZkontrolujSekvenci();
                timer1.Stop();
                startTime = DateTime.Now;
                timer1.Start();
                sekvenceBarev.ZacniSekvenci();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
            int remainingSeconds = secondsToWait - elapsedSeconds;

            if (remainingSeconds <= 0)
            {
                this.zivoty();
                timer1.Stop();
                startTime = DateTime.Now;
                timer1.Start();

            }

            timerTextBox.Text = String.Format("Zbyva {0} sekund ", remainingSeconds);
        }
        // konec kodu sekvence barev
        //
        // kod opakujicich symbolu

        private void symbolTextBox_click(object sender, EventArgs e)
        {
            opakujiciSymbol.stisknutoTlacitko();
        }

        // konec kodu opakujicich symbolu
        //
        // kod rychleho pocitani

        private void numpadButton_Click(object sender, EventArgs e)
        {
            pocitani.zkontrolujOdpoved(Convert.ToInt32((sender as Button).Tag));
        }


        private void pocitaniTimer_Tick(object sender, EventArgs e)
        {
            int elapsedSeconds = (int)(DateTime.Now - startTime2).TotalSeconds;
            int remainingSeconds = secondsToWait - elapsedSeconds;

            if (remainingSeconds <= 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    this.Controls.Remove(items[i]);
                }
                items.Clear();

                this.zivoty();
                pocitaniTimer.Stop();
                startTime2 = DateTime.Now;
                pocitani.zobrazKruhy();
                pocitaniTimer.Start();

            }
            timerTextBox2.Text = String.Format("Zbyva {0} sekund ", remainingSeconds);
        }

        //
        // konec kodu rychleho pocitani
        //

        // spust hry
        private void startButton_click(object sender, EventArgs e)
        {
            if (sekvenceAktivni) //sekvence barev
            {
                blueColorButton.Enabled = true;
                greenColorButton.Enabled = true;
                redColorButton.Enabled = true;
                sekvenceBarev.ZacniSekvenci();
                startTime = DateTime.Now;
                timer1.Start();
            }
            if (symbolAktivni) // symboly
            {
                symbolTextBox.Enabled = true;
                opakujiciSymbol.ZacniSymboly();
            }
            if (pocitaniAktivni) //pocitani
            {

                numpadButton4.Enabled = true;
                numpadButton5.Enabled = true;
                numpadButton6.Enabled = true;
                numpadButton7.Enabled = true;
                numpadButton8.Enabled = true;
                numpadButton9.Enabled = true;

                startTime2 = DateTime.Now;
                pocitaniTimer.Start();
                pocitani.zobrazKruhy();
            }
        }
    }


}
