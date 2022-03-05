using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!;
            //peab arvestama ka suurt tähte 'H';
            //char a = 'a';
            //luua kolm counterit, pikad if ja else;
            //counteri ette kirjuta täht, millist soovid siis on kergem aru saada;


            string helloW = "Hello World!".ToLower();

            //'h' TÄHT!
            int hCounter = 0;

            for (int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == 'h')
                {
                    hCounter++;
                }
            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses: Hello World! On 'h' tähti {hCounter} tükki.");
            }
            else
            {
                Console.WriteLine($"Lauses: Hello World! On 'h' tähti {hCounter} tükk.");
            }

            //'o' TÄHT!
            int oCounter = 0;

            for (int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == 'o')
                {
                    oCounter++;
                }
            }

            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses: Hello World! On 'o' tähti {oCounter} tükki.");
            }
            else
            {
                Console.WriteLine($"Lauses: Hello World! On 'o' tähti {oCounter} tükk.");
            }
            //'l' TÄHT!
            int lCounter = 0;

            for (int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == 'o')
                {
                    lCounter++;
                }
            }

            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses: Hello World! On 'l' tähti {lCounter} tükki.");
            }
            else
            {
                Console.WriteLine($"Lauses: Hello World! On 'h' tähti {lCounter} tükk.");
            }
        }
    }
}
