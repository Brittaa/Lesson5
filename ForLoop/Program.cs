using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int number = 0;

            //int i = 0 - start og the loop, i < 10 - stop, i++ - step
            for(int i = 1; i < 11; i++)//i+=2 
            {
                Console.WriteLine($"i equals {i}");
            }


            Console.WriteLine("\n");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"i equals {i}");
            }*/

            

            Console.WriteLine("\n");
            for(int i = 99; i >= 1; i--)
            {
                Console.WriteLine($"{i} bottels of beer on the wall, {i} bottels of beer.");

                if (i > 1)
                {
                    Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of beer on the wall.");
                }
                else
                {
                    Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");
                }

                Console.WriteLine("\n");

            }


            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
            Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
            Console.ReadLine();


        }
    }
}
