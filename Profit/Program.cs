using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLevaAmount = int.Parse(Console.ReadLine());
            int twoLevaAmount = int.Parse(Console.ReadLine());
            int fiveLevaAmount = int.Parse(Console.ReadLine());
            int sumNeeded = int.Parse(Console.ReadLine());
            int oneLvSum = 0;
            int twoLvSum = 0;
            int fiveLvSum = 0;

            for (int numOne = 0; numOne <= oneLevaAmount; numOne++)
            {
                for (int numTwo = 0; numTwo <= twoLevaAmount; numTwo++)
                {
                    for (int numFive = 0; numFive <= fiveLevaAmount; numFive++)
                    {
                        oneLvSum = numOne * 1;
                        twoLvSum = numTwo * 2;
                        fiveLvSum = numFive * 5;

                        if (oneLvSum + twoLvSum + fiveLvSum == sumNeeded)
                        {
                            Console.WriteLine($"{numOne} * 1 lv. + {numTwo} * 2 lv. + {numFive} * 5 lv. = {sumNeeded} lv.");
                        }
                    }
                }
            }
        }
    }
}
