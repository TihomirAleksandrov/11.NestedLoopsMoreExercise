using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int start1 = int.Parse(Console.ReadLine());
            int start2 = int.Parse(Console.ReadLine());
            int difference1 = int.Parse(Console.ReadLine());
            int difference2 = int.Parse(Console.ReadLine());

            int end1 = start1 + difference1;
            int end2 = start2 + difference2;

            for (int num1 = start1; num1 <= end1; num1++)
            {
                if (num1 % 2 != 0 && num1 % 3 != 0 && num1 % 5 != 0 && num1 % 7 != 0)
                {
                    for (int num2 = start2; num2 <= end2; num2++)
                    {
                        if (num2 % 2 != 0 && num2 % 3 != 0 && num2 % 5 != 0 && num2 % 7 != 0)
                        {
                            Console.WriteLine($"{num1}{num2}");
                        }
                    }
                }
            }

        }
    }
}
