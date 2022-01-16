using System;

namespace SecretDoorsLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeHundreds = int.Parse(Console.ReadLine());
            int rangeTenths = int.Parse(Console.ReadLine());
            int rangeSingles = int.Parse(Console.ReadLine());

            for (int hundreds = 1; hundreds <= rangeHundreds; hundreds++)
            {
                if (hundreds % 2 == 0)
                {
                    for (int tenths = 1; tenths <= rangeTenths; tenths++)
                    {
                        if (tenths != 1 && tenths != 4 && tenths != 6 && tenths <= 7)
                        {
                            for (int singles = 1; singles <= rangeSingles; singles++)
                            {
                                if (singles % 2 == 0)
                                {
                                    Console.WriteLine($"{hundreds} {tenths} {singles}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
