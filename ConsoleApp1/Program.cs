using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 < 10; num1++)
            {
                for (int num2 = 1; num2 < 10; num2++)
                {
                    for (int num3 = 1; num3 < 10; num3++)
                    {
                        for (int num4 = 1; num4 < 10; num4++)
                        {
                            int combination1 = num1 + num2;
                            int combination2 = num3 + num4;

                            if (combination1 == combination2 && number % combination1 == 0)
                            {
                                Console.Write($"{num1}{num2}{num3}{num4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
