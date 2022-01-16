using System;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;
            int counter = 0;
            int neededNum = 0;
            bool flag = false;

            for (int num1 = 1; num1 < 10; num1++)
            {
                for (int num2 = 1; num2 < 10; num2++)
                {
                    if (num1 < num2)
                    {
                        for (int num3 = 1; num3 < 10; num3++)
                        {
                            for (int num4 = 1; num4 < 10; num4++)
                            {
                                if (num3 > num4)
                                {
                                    firstSum = num1 * num2;
                                    secondSum = num3 * num4;

                                    if (firstSum + secondSum == controlNumber)
                                    {
                                        Console.Write($"{num1}{num2}{num3}{num4} ");
                                        counter++;

                                        if (counter == 4)
                                        {
                                            neededNum = int.Parse(num1.ToString() + num2.ToString() + num3.ToString() + num4.ToString());
                                            flag = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            
            if (flag)
            {
                Console.WriteLine($"Password: {neededNum}");
            }
            else
            {
                Console.WriteLine($"No!");
            }

        }
    }
}
