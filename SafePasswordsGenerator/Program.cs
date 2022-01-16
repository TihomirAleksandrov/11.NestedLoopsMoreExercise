using System;

namespace SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeA = int.Parse(Console.ReadLine());
            int rangeB = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());
            int passCounter = 0;
            bool flag = false;

            for (char symbol1 = '#'; symbol1 <= '7'; symbol1++)
            {
                for (char symbol2 = '@'; symbol2 <= '`'; symbol2++)
                {
                    for (int symbol3 = 1; symbol3 <= rangeA; symbol3++)
                    {
                        for (int symbol4 = 1; symbol4 <= rangeB; symbol4++)
                        {
                            Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol2}{symbol1}|");
                            passCounter++;

                            symbol1++;
                            symbol2++;

                            if (passCounter == maxPasswords || (symbol3 == rangeA && symbol4 == rangeB))
                            {
                                flag = true;
                                break;
                            }

                            if (symbol2 > 96)
                            {
                                symbol2 = '@';
                            }

                            if (symbol1 > 55)
                            {
                                symbol1 = '#';
                            }
                        }

                        if (flag)
                        {
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

        }
    }
}
