using System;

namespace LettersCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = letter1; i <= letter2; i++)
            {
                if (i != letter3)
                {
                    for (char j = letter1; j <= letter2; j++)
                    {
                        if (j != letter3)
                        {
                            for (char k = letter1; k <= letter2; k++)
                            {
                                if (k != letter3)
                                {
                                    counter++;
                                    Console.Write($"{i}{j}{k} ");
                                }
                            }
                        }
                    }
                }
                
            }
            Console.Write(counter);
        }
    }
}
