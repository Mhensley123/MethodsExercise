using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();


            Console.WriteLine("Where are you from?");
            string hometown = Console.ReadLine();

            Console.WriteLine("What is something unique about your culture?");
            string uniqueCulture = Console.ReadLine();

            Console.WriteLine("Where is a cool place to visit where you are from?");
            string coolPlace = Console.ReadLine();

            Console.WriteLine($"Her name is {userName} and she is from {hometown}.");
            Console.WriteLine($"{uniqueCulture} is unique about her culture.");
            Console.WriteLine($"{coolPlace} is a cool place to visit where she is from.");
            Console.WriteLine($"Every year her hometown has a voodoo festival.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");
        }
    }

    public static int Sum(params int{ } list)
    {
            for(int i = 0; i < list.length; i++)
        {

        }
    }
            //int sum = num1 + num2;
            //return sum;

            return num1 + num2;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
