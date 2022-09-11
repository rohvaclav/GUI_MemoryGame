using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_app_cvic3
{
    
    class Pocitani
    {
        private readonly IGameForm_pocitani form_o;
        public Pocitani(GameForm form_o)
        {
            this.form_o = form_o;
        }
        private int pocetCtvercu;

        public void zobrazKruhy()
        {
            //nejdrive smaze predchozi
            form_o.krychleSmaz();
            Random rand = new Random();
            int rInt = rand.Next(4, 10);
            pocetCtvercu = rInt;
            int[,] boxLocationList = new int[rInt, 2];
            int edgeOffset = 20;
            int squareOffset = 20;
            int x = rand.Next(form_o.labelNalevo + edgeOffset, form_o.labelNapravo - edgeOffset);
            int y = rand.Next(form_o.labelNahore + edgeOffset, form_o.labelDole - edgeOffset);
            Console.WriteLine("Vygenerovne prvni koordinaty: " + x + " " + y);
            bool generuji = true;
            int counter = 0;
            while (generuji)
            {
                Console.WriteLine("Hledam jestli seznam uz ma podobne koordinaty...");
                int i = 0;
                while (i < rInt)
                {                   
                    //if ((boxLocationList[i, 0] >= x - squareOffset) && (boxLocationList[i, 0] <= x + squareOffset) && (boxLocationList[i, 1] <= y + squareOffset) && (boxLocationList[i, 1] >= y - squareOffset))
                    Console.WriteLine("Na pozici " + i + " jsou koordinaty " + boxLocationList[i, 0] + "," + boxLocationList[i, 1]);
                    if (Math.Abs(boxLocationList[i, 0] - x) <= squareOffset && Math.Abs(boxLocationList[i, 1] - y) <= squareOffset)
                    {
                        Console.WriteLine("Podobne koordinaty uz jsou v seznamu na pozici " + i);
                        x = rand.Next(form_o.labelNalevo + edgeOffset, form_o.labelNapravo - edgeOffset);
                        y = rand.Next(form_o.labelNahore + edgeOffset, form_o.labelDole - edgeOffset);
                        i = 0;
                        Console.WriteLine("Vygenerovany nove koordinaty:" + x + " " + y);
                    }
                    else
                    {
                        i++;
                    }
                    
                }
                Console.WriteLine("Pridavam koordinaty ctverce do seznamu na pozici " + counter);
                boxLocationList[counter, 0] = x;
                boxLocationList[counter, 1] = y;
                counter++;
                if (counter == rInt)
                {
                    generuji = false;
                    Console.WriteLine("Konec generace koordinatu ctvercu, celkem vygenerovano: " + counter + " ,nyni je jdu vykreslovat...");
                }
                else 
                {
                    x = rand.Next(form_o.labelNalevo + edgeOffset, form_o.labelNapravo - edgeOffset);
                    y = rand.Next(form_o.labelNahore + edgeOffset, form_o.labelDole - edgeOffset);
                    Console.WriteLine("Vygenerovany nove koordinaty:" + x + " " + y);
                }

            }
            Console.WriteLine("Zacatek vykreslovani...");
            for (int i = 0; i < rInt; i++)
            {
                form_o.krychlePridej(boxLocationList[i, 0], boxLocationList[i, 1]);
                Console.WriteLine("Vykresluji krychli cislo " + (i+1) + " s pozici X: " + boxLocationList[i, 0] + ", Y: " + boxLocationList[i, 1]);
            }
            Console.WriteLine("Konec vykreslovani...");

        }

        public void zkontrolujOdpoved(int odpoved)
        {
            form_o.krychleSmaz();
            if (odpoved == pocetCtvercu)
            {
                form_o.pocitaniResult = "a";
                form_o.skore(10 * Difficulty.level);
                form_o.pocitaniTimerReset();
            }
            else
            {
                form_o.pocitaniResult = "r";
                form_o.zivoty();
                form_o.pocitaniTimerReset();
            }
        }
    }
}
