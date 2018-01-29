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

            string[,] InputLines = new string[50,8];
            var input = "";
            var x = 0;
            var y = 0;

            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
            for (int i=0; i<50; i++)
            {
                x = 0;
                input = Console.ReadLine();
                if (input == "stop") { break; }
                while (input.Length > 0)
                {
                    int SepIndex = 0;
                    int PointIndex = 0;    
                    if (x < 2)
                    {
                        SepIndex = input.IndexOf("|");
                        InputLines[y, x] = input.Substring(0, SepIndex - 1);
                        input = input.Substring(SepIndex + 2, input.Length - SepIndex - 2);
                        x += 1;
                        continue;
                    }
                    else if(x == 2)
                    {
                        SepIndex = input.IndexOf("|");
                        PointIndex = input.IndexOf(":");
                        InputLines[y, x] = input.Substring(0, PointIndex);
                        InputLines[y, x+1] = input.Substring(PointIndex+1, SepIndex - 2);
                        input = input.Substring(SepIndex + 2, input.Length - SepIndex - 2);
                        x += 1;
                        continue;
                    }
                    else if (x == 3)
                    {
                        PointIndex = input.IndexOf(":");
                        InputLines[y, x+1] = input.Substring(0,PointIndex);
                        InputLines[y, x+2] = input.Substring(PointIndex+1, input.Length- PointIndex-1);

                        if ((int.Parse(InputLines[y, 2]) + int.Parse(InputLines[y, 5])) > (int.Parse(InputLines[y, 3]) + int.Parse(InputLines[y, 4])))
                        {
                            InputLines[y, 6] = "W";
                            InputLines[y, 7] = "L";
                        }
                        else if ((int.Parse(InputLines[y, 2]) + int.Parse(InputLines[y, 5])) < (int.Parse(InputLines[y, 3]) + int.Parse(InputLines[y, 4])))
                        {
                            InputLines[y, 6] = "L";
                            InputLines[y, 7] = "W";
                        }
                        else
                        {
                            if (int.Parse(InputLines[y, 5]) > int.Parse(InputLines[y, 3]))
                            {
                                InputLines[y, 6] = "W";
                                InputLines[y, 7] = "L";
                            }
                            else if (int.Parse(InputLines[y, 5]) < int.Parse(InputLines[y, 3]))
                            {
                                InputLines[y, 6] = "L";
                                InputLines[y, 7] = "W";
                            }
                            else { }
                        }
                        input = "";
                        y += 1;

                    }
                }

            }



            for (int j = 0; j < InputLines.Length; j++)
            {
                var count = 0;
                var Oponents = "";
                for (int i = j; i < InputLines.Length; i++)
                {

                    if ((InputLines[j, 0] != "") && (InputLines[j, 0] == InputLines[i, 0]))
                    {
                        if ((InputLines[i, 6]) == "W")
                        {
                            count += 1;
                            if (count > 1) { Oponents = Oponents + ", " + InputLines[i, 1]; }
                            else { Oponents = Oponents + InputLines[i, 1]; }
                            InputLines[i, 0] = "";
                        }

                    }
                    if ((InputLines[j, 0] != "") && (InputLines[j, 0] == InputLines[i, 1]))
                    {
                        if ((InputLines[i, 7]) == "W")
                        {
                            count += 1;
                            if (count > 1) { Oponents = Oponents + ", " + InputLines[i, 0]; }
                            else { Oponents = Oponents + InputLines[i, 0]; }
                            InputLines[i, 1] = "";
                        }

                    }
                    Console.WriteLine(InputLines[j,0]);
                    Console.WriteLine("Wins:" + count.ToString());
                    Console.WriteLine("opponents:" + Oponents);


                }
            }
        

                
            }
        }
    }

