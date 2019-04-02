using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    public class Team
    {
        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.Name = teamName;
            this.Members = new List<string>();
        }

        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            string creator = string.Empty;
            string teamName = string.Empty;

            List<Team> teamsList = new List<Team>();
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] inputTeams = Console.ReadLine().Split('-');

                creator = inputTeams[0];
                teamName = inputTeams[1];

                if (teamsList.Select(x => x.Name).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teamsList.Select(x => x.Creator).Contains(creator))
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
                string[] inputMembers = Console.ReadLine().Split("->");

                if (inputMembers[0] == "end of assignment")
                {
                    break;
                }

                string user = inputMembers[0];
                teamName = inputMembers[1];

                if (!teamsList.Select(x => x.Name).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                else if (teamsList.Any(x => x.Members.Contains(user)) || teamsList.Any(x => x.Creator.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    int teamIndex = teamsList.FindIndex(x => x.Name == teamName);
                    teamsList[teamIndex].Members.Add(user);
                }
            }
            teamsList = teamsList.OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name).ToList();

            foreach (var Team in teamsList.Where(x => x.Members.Count() > 0))
            {

                Console.WriteLine(Team.Name);
                Console.WriteLine($"- {Team.Creator}");
                foreach (var members in Team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {members}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var Team in teamsList.Where(x => x.Members.Count() == 0))
            {
                Console.WriteLine($"{Team.Name}");
            }
        }
    }
}