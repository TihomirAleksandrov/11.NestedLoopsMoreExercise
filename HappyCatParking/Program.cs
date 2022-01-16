using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            int numOfHours = int.Parse(Console.ReadLine());
            double tax = 0;
            double totalDaySum = 0;
            double totalSum = 0;

            for (int days = 1; days <= numOfDays; days++)
            {
                for (int hours = 1; hours <= numOfHours; hours++)
                {
                    if (days % 2 ==0 && hours % 2 != 0)
                    {
                        tax = 2.50;
                    }
                    else if (days % 2 != 0 && hours % 2 == 0)
                    {
                        tax = 1.25;
                    }
                    else
                    {
                        tax = 1;
                    }

                    totalDaySum += tax;
                    totalSum += tax;
                }

                Console.WriteLine($"Day: {days} - {totalDaySum:f2} leva");
                totalDaySum = 0;
            }

            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
