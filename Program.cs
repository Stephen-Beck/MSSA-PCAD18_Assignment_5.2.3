/*
Write a program in C# Sharp to print numbers from n to 1 using recursion.

    Test Data :
        How many numbers to print : 10
        Expected Output :
            10 9 8 7 6 5 4 3 2 1 
*/

namespace Assignment_5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;
            while (true)
            {
                Console.Write("How many numbers would you like to print? ");
                if (!int.TryParse(Console.ReadLine(), out nums) || nums < 1)
                    Console.Write("Invalid number. ");
                else break;
            }
            PrintNumber(nums);
        }

        static void PrintNumber(int n)
        {
            Console.Write(n + " ");

            if (n > 1)
                PrintNumber(n - 1);
        }
    }
}
