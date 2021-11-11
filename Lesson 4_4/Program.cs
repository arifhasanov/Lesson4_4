using System;

namespace Lesson_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for fibonachi calculation:");
            int number = int.Parse(Console.ReadLine());
            int fibonachiResult = Fibonachi(number);
            Console.WriteLine("Fibonachi of " + number + " is " + fibonachiResult.ToString());
        }

        public static int Fibonachi(int number)
        {
            if (number <= 2)
            {
                return 1;
            }
            else
            {
                return Fibonachi(number - 1) + Fibonachi(number - 2);
            }
        }
    }
}
