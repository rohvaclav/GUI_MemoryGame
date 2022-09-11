# GUI_MemoryGame
 Paměťová a multitaskingová hra pro předmět KI/GUI.

# Jak hrát
 Po spuštění se otevře **Main menu**, ve kterém je tlačítko na vypnutí, zobrazení skóre (řešeno jednoduše pomocí textového souboru, formát csv)
 a spuštění hry. Kliknutí na toto tlačítko se otevře druhé okno, Nastavení, kde lze vybrat obtížnost a kombinaci her, které budou spuštěny. 
 To vše se ukládá pomocí xml config souboru.
 
 Potom se uživatel dostává do hlavního okna se třemi hrami. Začíná se se třemi srdíčky a úkolem je nasbírat co nejvíce bodů. Hra končí potom, co hráč přijde o všechny srdíčka.
 
 Hry jsou následující:

# Symboly
 V poli se objevují různé symboly. Hráč si musí pamatovat, jaký symbol se nacházel o <Obtížnost> políček zpátky. Pokud byl tento symbol stejný jako je momentální, hráč musí na políčko se symbolem kliknout. Pokud se mýlí, ztrácí život. Důležité je zmínit, že pokud se symboly nerovnají a hráč neklikne, pořád dostane menší množství bodů.

# Počítání
 V poli se objeví náhodný počet krychlí od 4 do 9 a hráč je musí v časovém úseku spočítat. Pokud to nestihne nebo se mýlí, přijde o život. Obtížnost ovlivňuje čas na vyřešení podle rovnice čas = 10 - obtížnost .
 
# Sekvence
 V políčku za sebou problikávají různé barvy - červená, modrá, zelená. Hráč si musí pamatovat v jakém pořadí jdou za sebou a nakonci sekvenci zopakovat. Délka sekvence je rovna 2 + obtížnost. Hráč zde může ztratit život pokud zopakuje sekvenci špatně a nebo pokud mu vyprchá časový limit.
 
 
 Na konci je skóre uloženo do .txt souboru i s informacemi o nastavení. 
 



