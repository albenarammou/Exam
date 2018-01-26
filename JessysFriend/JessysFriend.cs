using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessysFriend
{
    class JessysFriend
    {
        static void Main(string[] args)
        {
            var startInterval = int.Parse(Console.ReadLine());
            var endInterval = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            int currentCombination = 0;
            int magicCombination = 0;

            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = i; j <= endInterval; j++)
                {
                    currentCombination += 1;
                    if (i + j == magicNumber)
                    {
                        magicCombination = currentCombination;
                        Console.WriteLine("Combination N:" + magicCombination + " (" + i + " + " + j + " = " + magicNumber + ")");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        return;
                    }

                }
            }

            if (magicCombination == 0)
            {
                var lenInterval = (endInterval - startInterval + 1);
                Console.WriteLine("{0:D} combinations - neither equals {1:D}", (lenInterval * lenInterval - lenInterval / 2), magicNumber);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        }
    }
}



