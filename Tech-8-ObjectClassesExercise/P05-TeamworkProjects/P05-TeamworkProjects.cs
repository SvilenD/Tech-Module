using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_TeamworkProjects
{
    public class Team
    {
        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

    }

    class Program
    {
        static List<Team> teamsList = new List<Team>();

        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsCount; i++)
            {
                var teamsData = Console.ReadLine().Split('-');
                var creator = teamsData[0];
                var teamName = teamsData[1];

                if (teamsList.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teamsList.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team(creator, teamName);
                    teamsList.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            while (true)
            {
                var membersInfo = Console.ReadLine().Split("->");
                if (membersInfo[0] == "end of assignment")
                {
                    break;
                }
                var user = membersInfo[0];
                var team = membersInfo[1];

                if (!teamsList.Any(x => x.TeamName == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teamsList.Any(x => x.Members.Contains(user)) || teamsList.Any(y => y.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                }
                else
                {
                    var currentTeam = teamsList.FirstOrDefault(x => x.TeamName == team);
                    currentTeam.Members.Add(user);
                }
            }

            PrintResult();
        }

        static void PrintResult()
        {
            var teamsToDisband = teamsList
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName).ToList();

            teamsList = teamsList.Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(y => y.TeamName).ToList();

            foreach (var team in teamsList)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (var user in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }

            Console.WriteLine("Teams to disband:");
            for (int i = 0; i < teamsToDisband.Count; i++)
            {
                Console.WriteLine(teamsToDisband[i].TeamName);
            }
        }
    }
}