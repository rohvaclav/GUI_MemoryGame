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
    public partial class MainMenuForm : Form
    {
        public bool otevrenoGameOptions { get; private set; }
        private string path = "skore.csv";
        public MainMenuForm()
        {
            InitializeComponent();
            
            using (var w = File.AppendText(path))
                {

                    if (new FileInfo(path).Length == 0)
                    {
                        w.WriteLine("Datum,Obtiznost,Skore,AktivniHry");
                    }
                }
            }

            private void MainMenuStartButton_Click(object sender, EventArgs e)
        {
            //start
            otevrenoGameOptions = true;
            Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //skore   
            System.Diagnostics.Process.Start(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

    }
}
