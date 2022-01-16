using System;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int num1 = firstNum; num1 <= secondNum; num1++)
            {
                for (int num2 = firstNum; num2 <= secondNum; num2++)
                {
                    for (int num3 = firstNum; num3 <= secondNum; num3++)
                    {
                        for (int num4 = firstNum; num4 <= secondNum; num4++)
                        {
                            int middleNumSum = num2 + num3;

                            if (num1 > num4 && middleNumSum % 2 == 0)
                            {
                                if (num1 % 2 == 0 && num4 % 2 != 0)
                                {
                                    Console.Write($"{num1}{num2}{num3}{num4} ");
                                }
                                else if (num1 % 2 != 0 && num4 % 2 == 0)
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
}
