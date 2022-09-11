using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_app_cvic3
{
    

    //Objevuji se nahodne symboly ktere se zaroven ukladaji do cyklickeho pole. Pokud je v poli o Difficulty.level policek zpatky stejny symbol
    // jako je momentalne zobrazeny pak hrac musi na symbol kliknout jinak prijde o jedno srdicko.
    class OpakujiciSymbol
    {
        private readonly IGameForm_symbol form_o;
        //private readonly IGameForm_universal form_u;
        public OpakujiciSymbol(IGameForm_symbol form_o)
        {
            this.form_o = form_o;
        }
        private int[] arraySymbol;
        // prevod generovanych intu na obrazky pomoci Webdings fontu
        static IDictionary<int, string> cisloSymbol = new Dictionary<int, string>()
        {
            {0,"b"},
            {1,"f"},
            {2,"h"},
            {3,"i"},
            {4,"j"},
            {5,"k"}
        };
        // 0 = nestisknute tlacitko, 1 = stisknute tlacitko
        private int lever = 0;
        
        private async Task ProchazejArray()
        {
            // ze zacatku musim cekat nez se muze zjevit prvni opakovany symbol
            // cekani je urceno obtiznosti, stejne jako pocet symbolu ktere si hrac musi pamatovat
            arraySymbol = new int[Difficulty.level + 1];
            int zacatecni_odpocet = Difficulty.level;
            Random r = new Random();
            int counter = 0;           
            while(true)
            { 
                int rInt = r.Next(0, 6);
                arraySymbol[counter] = rInt;
                form_o.symbolText = cisloSymbol[rInt];
                // zobraz nahodny symbol a potom na chvili nic aby slo rozpoznat dva stejne symboly za sebou jdouci
                await Task.Delay(1500);
                form_o.symbolText = "";
                await Task.Delay(500);
                if (zacatecni_odpocet > 0)
                {
                    zacatecni_odpocet-=1;
                }
                else
                {
                    // moje implementace cyklickeho pole potrebuje pomocnou metodu na zjisteni pozice srovnavaneho symbolu
                    int pozice_predchozi_hodnoty = counter - Difficulty.level;
                    if (pozice_predchozi_hodnoty < 0)
                    {
                        pozice_predchozi_hodnoty = arraySymbol.Length - Math.Abs(pozice_predchozi_hodnoty);
                    }
                    // kontrola spravnosti podle toho jestli hrac kliknul nebo ne
                    if (arraySymbol[counter] == arraySymbol[pozice_predchozi_hodnoty])
                    {
                        if (lever == 1)
                        {
                            form_o.symbolResult = "a";
                            form_o.skore(10*Difficulty.level);
                        }
                        else
                        {
                            form_o.symbolResult = "r";
                            form_o.zivoty();
                        }
                    }
                    else
                    {
                        if (lever == 0)
                        {
                            form_o.symbolResult = "a";
                            form_o.skore(5 * Difficulty.level);
                        }
                        else
                        {
                            form_o.symbolResult = "r";
                            form_o.zivoty();
                        }
                    }
                    
                }  
                lever = 0;
                counter+=1;
                if (counter == (Difficulty.level + 1))
                {
                    counter = 0;
                }
            }
        }

        public void stisknutoTlacitko()
        {
            lever = 1;
        }

        public void ZacniSymboly()
        {
            _ = ProchazejArray();
        }
    }
}
