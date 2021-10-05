using System;

namespace StringAndForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikem - eesnimi või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string perekonnanimi = Console.ReadLine();

            if (eesnimi.Length < perekonnanimi.Length)
            {
                Console.WriteLine($"Sinu perekonnanimel on {perekonnanimi.Length - eesnimi.Length} sümbolit rohkem kui eesnimel");
            }
            else if (perekonnanimi.Length < eesnimi.Length)
            {
                Console.WriteLine($"Sinu eesnimel on {eesnimi.Length - perekonnanimi.Length} sümbolit rohkem kui perekonnanimel");

            }
            else
            {
                Console.WriteLine("Sama pikad");
            }

        }
    }
}
