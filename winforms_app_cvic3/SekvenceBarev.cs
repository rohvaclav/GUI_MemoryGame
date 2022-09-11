using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_app_cvic3
{
    
    class SekvenceBarev
    {
        int delka = Difficulty.level + 2;
        private int[] arraySekvence = new int[Difficulty.level+2];
        private readonly IGameForm_barvy form_o;
        public int[] zadanaSekvence = new int[Difficulty.level + 2];
        public SekvenceBarev(IGameForm_barvy form_o)
        {
            this.form_o = form_o;
        }

        static IDictionary<int, System.Drawing.Color> cisloBarva = new Dictionary<int, System.Drawing.Color>()
        {
            {0,System.Drawing.Color.Red},
            {1,System.Drawing.Color.Green},
            {2,System.Drawing.Color.LightBlue},
            {3,System.Drawing.Color.Black}
        };

        private void GenerujSekvenci()
        {            
            Random r = new Random();
            int rInt = r.Next(0, 3);
            for(int i=0;i<delka; i++)
            {
                arraySekvence[i] = rInt;
                rInt = r.Next(0, 3);
            }
        }
        private async Task PrehrajSekvenci()
        {
            for(int i = 0;i< delka; i++)
            {
                pictureBox1_ChangeColor(arraySekvence[i]);
                await Task.Delay(1000);
                form_o.sekvenceResult = "";
                pictureBox1_ChangeColor(3);
                if (i != delka-1)
                {
                    await Task.Delay(500);
                }               
            }
        }

        private void pictureBox1_ChangeColor(int color)
        {
            form_o.picturebox1Color = cisloBarva[color];
        }
        public void ZacniSekvenci()
        {
            
            GenerujSekvenci();
            _ = PrehrajSekvenci();

            
        }
        public void ZkontrolujSekvenci()
        {
            bool spravnyVstup = true;
            for(int i=0;i< delka; i++)
            {
                if (zadanaSekvence[i] != arraySekvence[i])
                {
                    spravnyVstup = false;
                    form_o.sekvenceResult = "r";
                    form_o.zivoty();
                    break;
                }
            }
            if (spravnyVstup)
            {
                form_o.sekvenceResult = "a";
                form_o.skore(10 * Difficulty.level);
            }
            Array.Clear(zadanaSekvence, 0, zadanaSekvence.Length);
        }
    }
}
