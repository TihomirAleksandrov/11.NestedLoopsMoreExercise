using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstRow = int.Parse(Console.ReadLine());
            int oddPlaces = int.Parse(Console.ReadLine());
            int evenPlaces = oddPlaces + 2;
            string alphabetMinor = "abcdefghijklmnopqrstuvwxyz";
            string alphabetMajor = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int lastSectorNum = lastSector - 64;
            int placeCounter = 0;

            for (int sector = 0; sector < lastSectorNum; sector++)
            {
                char sectorLetter = Convert.ToChar(alphabetMajor[sector]);
                
                for (int row = 1; row <= firstRow; row++)
                {

                    if (row % 2 == 0)
                    {
                        for (int evenPlace = 0; evenPlace < evenPlaces; evenPlace++)
                        {
                            char letter = Convert.ToChar(alphabetMinor[evenPlace]);
                            Console.WriteLine($"{sectorLetter}{row}{letter}");
                            placeCounter++;
                        }
                    }
                    else
                    {
                        for (int oddPlace = 0; oddPlace < oddPlaces; oddPlace++)
                        {
                            char letter = Convert.ToChar(alphabetMinor[oddPlace]);
                            Console.WriteLine($"{sectorLetter}{row}{letter}");
                            placeCounter++;
                        }
                    }
                }

                firstRow++;
            }

            Console.WriteLine(placeCounter);
        }
    }
}
