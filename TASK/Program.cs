using System;

namespace TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            Console.WriteLine("Please enter number: ");
            int userNumber = int.Parse(Console.ReadLine());

            if(userNumber > 0)
            {
                Console.WriteLine("User number is positive.");
            }
            else if (userNumber < 0)
            {
                Console.WriteLine("User number is negative.");
            }
            else
            {
                Console.WriteLine("User number is zero.");
            }
            Console.WriteLine("\n");
            //TASK2
            Console.WriteLine("Please enter number: ");
            int userNumber2 = int.Parse(Console.ReadLine());

            if (userNumber2 % 5 == 0 && userNumber2 % 11 == 0)
            {
                Console.WriteLine("Usernumber is divisible by 5 or 11.");
            }
            else if (userNumber2 % 11 == 0)
            {
                Console.WriteLine("Usernumber is divisible by 11.");
            }
            else if (userNumber2 % 5 == 0)
            {
                Console.WriteLine("Usernumber is divisible by 5 or 11.");
            }
            else
            {
                Console.WriteLine("Usernumber is not divisible by 5.");
            }
            Console.WriteLine("\n");
            //TASK3
            Console.WriteLine("Please enter number: ");
            int userNumber3 = int.Parse(Console.ReadLine());

            if (userNumber3 % 2 == 0)
            {
                Console.WriteLine("Usernumer is even.");
            }
            else
            {
                Console.WriteLine("Usernumber is odd.");
            }

            Console.WriteLine("\n");
            //TASK4
            Console.WriteLine("Please enter letter:");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "a":
                Console.WriteLine("User input is a vowel.");
                    break;
                case "e":
                Console.WriteLine("User input is a vowel.");
                    break;
                case "i":
                Console.WriteLine("User input is a vowel.");
                    break;
                case "o":
                Console.WriteLine("User input is a vowel.");
                    break;
                case "u":
                Console.WriteLine("User input is a vowel.");
                    break;
                default:
                    Console.WriteLine("User input is something else.");
                    break;
            }

            Console.WriteLine("\n");
            //TASK5

            Console.WriteLine("Please enter number 1-7: ");
            int userNumber4 = int.Parse(Console.ReadLine());

            switch (userNumber4)
            {
                case 1:
                    Console.WriteLine("Monday.");
                    break;
                case 2:
                    Console.WriteLine("Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("Wendsday.");
                    break;
                case 4:
                    Console.WriteLine("Thursday.");
                    break;
                case 5:
                    Console.WriteLine("Friday.");
                    break;
                case 6:
                    Console.WriteLine("Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Sunday.");
                    break;
                default:
                    Console.WriteLine("User input is something else.");
                    break;

            }



            Console.ReadLine();
        }
    }
}
