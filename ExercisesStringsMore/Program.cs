using System;

namespace ExercisesStringsMore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kuvab, mittu sõna on lauses "Hello, World!"        
             string HelloW = "Hello, World!";
            //while
            /*int Counter = 1;
            int i = 0;
            while (i < HelloW.Length)
            {
                 if (HelloW[i] == ' ')
                 {
                    Counter++;
                 }
                i++;
            }
            Console.WriteLine($"The text {HelloW} has {Counter} words.");*/
            // For
            int Counter = 1;
            for(int i = 0; i < HelloW.Length; i++)
            {
                if (HelloW[i] == ' ')
                {
                    Counter++;
                }
                i++;
            }
            Console.WriteLine($"The text {HelloW} has {Counter} words.");
        }
    }
}
