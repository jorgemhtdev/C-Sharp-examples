using System;

namespace ForeachLoop
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (var x = 0; x < 5; x++)
            {
                for (var y = 0; y < 5; y++)
                {
                    Console.WriteLine(x + " - " +y);
                }
            }

            Console.ReadLine();
        }
    }
}
