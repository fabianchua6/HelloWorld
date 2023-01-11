// See https://aka.ms/new-console-template for more information
using System;

namespace
MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var projectTeam = "Co-Pilot";
            const string teamLeader = "Felipe (Student ID: 234567)";
            string teamMember1 = "Desmond (Student ID: 123456)";
            string teamMember2 = "Emillia (Student ID: 345678)";
            string teamMember3 = "Alan (Student ID: 345678)";

            // using a list
            var teamMembers = new List<string>();
            teamMembers.Add("Desmond (Student ID: 123456)");
            teamMembers.Add("Emillia (Student ID: 345678)");

            // teamMembers.Add("Alan (Student ID: 345678)");
            Console.WriteLine("Hello everyone!\n");
            Console.WriteLine($"We are project team: {projectTeam}\n");
            Console.WriteLine($"Our team leader is {teamLeader},");
            Console.WriteLine($"and the rest of our team members include:");

            // Console.WriteLine($"{teamMember1}");
            // Console.WriteLine($"{teamMember2}");
            // Console.WriteLine($"{teamMember3}");
            for (int i = 0; i < teamMembers.Count; i++)
            {
                Console.WriteLine($"{teamMembers[i]}");
            }
        }
    }
}
