using System;

namespace MoreStringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //program kuvab sõna "racecar" tagurpidi
            //*kasutame for-tsülit
            String RaceC = "racecar";
            for(int i = RaceC.Length -1; i >= 0; i--)
            {
                Console.Write(RaceC[i]);
            }

        }
    }
}
