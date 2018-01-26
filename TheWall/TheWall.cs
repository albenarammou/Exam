using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall
{
    class TheWall
    {
        static void Main(string[] args)
        {

            List<int> daysList = new List<int>();
            int crews = 0;
            int x = 0;
            int coins = 0;
            int cycles = 0;

            var input = Console.ReadLine();
            while (input.Length > 0)
            {
                int EmpIndex = 0;
                if (input.IndexOf(" ") > 0)
                {
                    EmpIndex = input.IndexOf(" ");
                    daysList.Add(int.Parse(input.Substring(0, EmpIndex)));
                    input = input.Substring(EmpIndex + 1, input.Length - EmpIndex - 1);
                    x += 1;
                }
                else
                {
                    daysList.Add(int.Parse(input.Substring(0, input.Length)));
                    input = "";

                }
            }

            daysList.Sort();
            cycles = (30 - daysList[0]);
            for (int i = 1; i <= cycles; i++)
            {
                crews = 0;
                for (int j = 0; j <= daysList.Count - 1; j++)
                {
                    if (daysList[j] < 30)
                    {
                        daysList[j] += 1;
                        crews += 1;
                    }
                }
                coins += crews * 195 * 1900;
                Console.Write(crews * 195 + " ");
            }
            Console.WriteLine();
            Console.WriteLine(coins + " coins");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
