using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {


            //programm palb kasutajal sisestada ees- ja perekonnanime;
            //programm kontroll andmete pikkust (eraldi);
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi;
            //if'iga hiljem kas sama pikk või kumb on pikem;
            //küsida alguses eesnimi ja seejärel perekonnanimi;


            Console.WriteLine("Palun, sisesta oma eesnimi:");
            string firstName = Console.ReadLine();


            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");


            Console.WriteLine("Palun, sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();


            Console.WriteLine($"Sinu perekonnanimes on {lastName.Length} sümbolit.");

            if (firstName.Length < lastName.Length)

            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi, kuna sisaldab rohkem sümboleid.");
            }
            else if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi, kuna sisaldab rohkem sümboleid.");
            }
            else

            {

                Console.WriteLine("Mõlemad nimed on sama pikad.");
            }
        }
    }
}
