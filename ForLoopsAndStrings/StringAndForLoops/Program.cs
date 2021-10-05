using System;

namespace StringAndForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi");
            string firstname = Console.ReadLine();

            for(int i = 0; i < firstname.Length; i++)
            {
                Console.WriteLine(firstname[i]);
            }
        }
    }
}
