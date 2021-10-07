using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach(char c in hello)
            //programm kuvab sõne "Hello World!" pikkust Lenght omaduse kasutama
            string helloW = "Hello World!";
            int charCounter = 0;
            foreach(char c in helloW)
            {
                charCounter++;
            }
            Console.WriteLine($"The text {helloW} is {charCounter} leters long.");
        }
    }
}
