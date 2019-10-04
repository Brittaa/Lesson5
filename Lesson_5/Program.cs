using System;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int cpuNumber;
           
            int tries = 0;
            bool gameOver = false;

            Random rnd = new Random();
            cpuNumber = rnd.Next(1, 6);

            Console.WriteLine("Please, enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");

            //!gameOver = NOT gameover = true
            while (!gameOver)
            {
                int userNumber;
                Console.WriteLine("Try to guess the number: ");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber > cpuNumber)
                {
                    Console.WriteLine("CPU number is smaller.");
                }
                else if (userNumber < cpuNumber)
                {
                    Console.WriteLine("CPU number is bigger.");
                }
                else
                {
                    Console.WriteLine("Got me!");
                    gameOver = true;
                }


            }

            Console.ReadLine();

        }
    }
}
