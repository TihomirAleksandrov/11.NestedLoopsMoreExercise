using System;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int males = int.Parse(Console.ReadLine());
            int females = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isFull = false;

            for (int currentMales = 1; currentMales <= males; currentMales++)
            {
                for (int currentFemales = 1; currentFemales <= females; currentFemales++)
                {
                    counter++;

                    Console.Write($"({currentMales} <-> {currentFemales}) ");

                    if (counter == tables)
                    {
                        isFull = true;
                        break;
                    }
                }

                if (isFull)
                {
                    break;
                }
            }
        }
    }
}
