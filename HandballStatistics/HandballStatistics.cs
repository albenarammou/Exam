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

            string[] InputLines = new string[8];
            List<Team> TeamList = new List<Team>();
            //Team TeamMember  = new Team();
            var input = "";
            var x = 0;
            var y = 0;

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
                        InputLines[x] = input.Substring(0, SepIndex - 1);
                        Team TeamMember = new Team();
                        TeamMember.TeamIndex = y + x;
                        TeamMember.TeamName = (input.Substring(0, SepIndex - 1));
                        TeamMember.TeamWins = 0;
                        TeamMember.TeamOpponents = "";
                        TeamList.Add(TeamMember);
                        input = input.Substring(SepIndex + 2, input.Length - SepIndex - 2);
                        x += 1;
                        continue;
                    }
                    else if(x == 2)
                    {
                        SepIndex = input.IndexOf("|");
                        PointIndex = input.IndexOf(":");
                        InputLines[x] = input.Substring(0, PointIndex);
                        InputLines[x+1] = input.Substring(PointIndex+1, SepIndex - 2);
                        input = input.Substring(SepIndex + 2, input.Length - SepIndex - 2);
                        x += 1;
                        continue;
                    }
                    else if (x == 3)
                    {
                        PointIndex = input.IndexOf(":");
                        InputLines[x+1] = input.Substring(0,PointIndex);
                        InputLines[x+2] = input.Substring(PointIndex+1, input.Length- PointIndex-1);

                        if ((int.Parse(InputLines[2]) + int.Parse(InputLines[5])) > (int.Parse(InputLines[3]) + int.Parse(InputLines[4])))
                        {
                            InputLines[6] = "W";
                            InputLines[7] = "L";
                            TeamList.ElementAt(2 * y).TeamWins += 1;
                            //TeamList.ElementAt(2*y).TeamOpponents = TeamList.ElementAt(2*y+1).TeamName;
                        }
                        else if ((int.Parse(InputLines[2]) + int.Parse(InputLines[5])) < (int.Parse(InputLines[3]) + int.Parse(InputLines[4])))
                        {
                            InputLines[6] = "L";
                            InputLines[7] = "W";
                            TeamList.ElementAt(2 * y + 1).TeamWins += 1;
                            //TeamList.ElementAt(2*y+1).TeamOpponents= TeamList.ElementAt(2*y).TeamName;
                        }
                        else
                        {
                            if (int.Parse(InputLines[5]) > int.Parse(InputLines[3]))
                            {
                                InputLines[6] = "W";
                                InputLines[7] = "L";
                                TeamList.ElementAt(2 * y).TeamWins += 1;
                            }
                            else if (int.Parse(InputLines[5]) < int.Parse(InputLines[3]))
                            {
                                InputLines[6] = "L";
                                InputLines[7] = "W";
                                TeamList.ElementAt(2 * y + 1).TeamWins += 1;
                            }
                            else { }
                        }

                        TeamList.ElementAt(2*y).TeamOpponents = TeamList.ElementAt(2*y+1).TeamName;
                        TeamList.ElementAt(2*y+1).TeamOpponents = TeamList.ElementAt(2*y).TeamName;

                        input = "";
                        y += 1;

                    }
                }

            }


            //TeamList.Sort(TeamMember.TeamName);

            //for (int i = 0; i < TeamList.Count; i++)
            //{
            //    TeamList.Select(n => n.TeamOpponents).Where(n => (n.TeamName == TeamList.ElementAt(i).TeamName));
            //}


            for (int i =0; i < TeamList.Count; i++)
            {
                Console.WriteLine(TeamList.ElementAt(i).TeamName);
                Console.WriteLine("-Wins:" + TeamList.ElementAt(i).TeamWins.ToString());
                Console.WriteLine("-Opponents:" + TeamList.ElementAt(i).TeamOpponents);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }


        public class Team
        {
            public int TeamIndex { get; set; }
            public string TeamName { get; set; }
            public int TeamWins { get; set; }
            public string TeamOpponents { get; set; }
        }

    }
    }

