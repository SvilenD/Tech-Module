using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._2_RoliTheCoder
{
    class Event
    {
        public Event(int id, string name, List<string> participants)
        {
            this.Id = id;
            this.Name = name;
            this.Participants = participants;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Participants { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var eventsList = new List<Event>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }
                //string pattern = @"^(\d+)[' ']#(\w+)[' ']@(\w+)[' ']@(\w+)$";
                //MatchCollection matches = Regex.Matches(input, pattern);
                string[] splitted = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(splitted[0]);

                string name = splitted[1];
                if (name[0] != '#')
                {
                    continue;
                }
                name = name.Remove(0, 1);
                var participants = new List<string>();
                for (int i = 2; i < splitted.Length; i++)
                {
                    if (splitted[i][0] != '@')
                    {
                        continue;
                    }
                    if (!participants.Contains(splitted[i]))
                    {
                        participants.Add(splitted[i]);
                    }
                }
                participants.Sort();
                var newEvent = new Event(id, name, participants);
                if (!eventsList.Any(x => x.Id == newEvent.Id))
                {
                    eventsList.Add(newEvent);
                }
                else
                {
                    int index = eventsList.FindIndex(x => x.Id == newEvent.Id);
                    if (eventsList[index].Name == newEvent.Name)
                    {
                        foreach (var user in participants)
                        {
                            if (!eventsList[index].Participants.Contains(user))
                            {
                                eventsList[index].Participants.Add(user);
                            }
                        }
                        eventsList[index].Participants.Sort();
                    }
                }
            }

            foreach (Event @event in eventsList.OrderByDescending(x => x.Participants.Count()).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{@event.Name} - {@event.Participants.Count}");
                for (int i = 0; i < @event.Participants.Count; i++)
                {
                    Console.WriteLine($"{@event.Participants[i]}");
                }
            }
        }
    }
}
