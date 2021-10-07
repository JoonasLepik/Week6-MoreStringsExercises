using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm asendab kõik 'a' tähed kasutaja nimes tärniga (*)
            //programm kuvab tulemust konsoolis
            Console.WriteLine("Enter Firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname:");
            string lastname = Console.ReadLine();
            string fullname = $"{firstname} {lastname}";
            fullname = fullname.Replace('a', '*');
            Console.WriteLine(fullname);
        }
    }
}
