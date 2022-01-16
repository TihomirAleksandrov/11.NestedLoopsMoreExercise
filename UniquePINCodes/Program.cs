using System;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input1; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= input2; j++)
                    {
                        if (j >= 2 && j <= 7)
                        {
                            if (j != 4 && j != 6)
                            {
                                for (int k = 1; k <= input3; k++)
                                {
                                    if (k % 2 == 0)
                                    {
                                        Console.WriteLine($"{i} {j} {k}");
                                    }
                                }
                            } 
                            
                        }
                    }
                }
            }
        }
    }
}
