using System;


class Jessys_Friend
{
    static void Main()
    {
        var startInterval = int.Parse(Console.ReadLine());
        var endInterval = int.Parse(Console.ReadLine());
        var magicNumber = int.Parse(Console.ReadLine());
        int currentCombination = 0;
        int magicCombination = 0;
        int counti = 0;
        int countj = 0;


        for (int i = startInterval; i <= endInterval; i++)
        {
            counti += 1;
            for (int j = startInterval; j <= endInterval; j++)
            {
                countj += 1;
                currentCombination = (counti - 1) * startInterval + countj;
                if (i + j == magicNumber)
                {
                    magicCombination = currentCombination;
                    Console.WriteLine("Combination N:" + currentCombination + " (" + i + " + " + j + " = " + magicNumber + ")");
                    return;
                }
            }
        }

        if (magicCombination == 0)
        { Console.WriteLine("{0:D} combinations - neither equals {1:D}", (endInterval - startInterval + 1) * (endInterval - startInterval + 1), magicNumber); }


    }
}