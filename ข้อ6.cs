using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Char Letters = Char.Parse(Console.ReadLine());
            int Width = int.Parse(Console.ReadLine());
            int Hight = int.Parse(Console.ReadLine());
            int Number = int.Parse(Console.ReadLine());
            int round = 1;

            while (round <= Number)
            {
                for (int j = 1; j <= Hight; j++)
                {
                    for (int i = 1; i <= round * Width; i++)
                    {
                        Console.Write(Letters);
                    }
                    Console.WriteLine("");
                }
                round++;
            }
            Console.ReadLine();
        }
    }
}
