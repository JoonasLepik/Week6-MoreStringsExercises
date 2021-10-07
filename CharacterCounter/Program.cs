using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime ikkust kokku
            //Length omadust kasutamata.
            Console.WriteLine("Enter firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter lastname:");
            string lastname = Console.ReadLine();
            string fullname = $"{firstname} {lastname}";
            int charCounter = 0;
            foreach (char c in fullname)
            {
                charCounter++;
            }
            Console.WriteLine($"In the name {fullname} is {charCounter} letters long.");
        }
    }
}
