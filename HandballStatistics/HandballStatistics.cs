using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics
{
    class HandballStatistics
    {
        static void Main(string[] args)
        {

            List<string> TeamList = new List<string>();
            List<int> ScoreList = new List<int>();
            var input = "";
            var x = 0;

            while (input == "stop")
            {
                input=Console.ReadLine();
                //int[] PairLine = new int[2,2];
                while (input.Length > 0)
                {
                    int SepIndex = 0;
                    int PointIndex = 0;    
                    if (x < 2)
                    {
                        SepIndex = input.IndexOf("|");
                        TeamList.Add(input.Substring(0, SepIndex-1));
                        input = input.Substring(SepIndex + 2, input.Length - SepIndex - 3);
                        x += 1;
                    }
                    else if(x == 3)
                    {
                        SepIndex = input.IndexOf("|");
                        PointIndex = input.IndexOf(":");
                        ScoreList.Add(int.Parse(input.Substring(0, PointIndex - 1)));
                        ScoreList.Add(int.Parse(input.Substring(PointIndex, SepIndex-2)));

                        input = input.Substring(SepIndex + 2, input.Length - SepIndex - 3);
                        x += 1;
                    }
                    else if (x == 4)
                    {

                        PointIndex = input.IndexOf(":");
                        ScoreList[ScoreList.Count]+=(int.Parse(input.Substring(PointIndex, SepIndex - 2)));
                        ScoreList[ScoreList.Count-1]+=(int.Parse(input.Substring(0, PointIndex - 1)));
                        if (ScoreList[ScoreList.Count] == ScoreList[ScoreList.Count - 1])
                        { }
                        else
                        { }

                        ScoreList.Add(int.Parse(input.Substring(0, input.Length)));
                        input = "";
                        x += 1;
                    }
                }

            }

        }
    }
}
