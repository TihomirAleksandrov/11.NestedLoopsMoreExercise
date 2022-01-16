using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            int endLetter = int.Parse(Console.ReadLine());

            char letter = (char)(endLetter + 96);

            for (int num1 = 1; num1 <= endNum; num1++)
            {
                for (int num2 = 1; num2 <= endNum; num2++)
                {
                    for (char letter1 = 'a'; letter1 <= letter; letter1++)
                    {
                        for (char letter2 = 'a'; letter2 <= letter; letter2++)
                        {
                            for (int num3 = 1; num3 <= endNum; num3++)
                            {
                                if (num3 > num1 && num3 > num2)
                                {
                                    Console.Write($"{num1}{num2}{letter1}{letter2}{num3} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
