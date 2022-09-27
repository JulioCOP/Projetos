using SimuladorRedesSociais.Entities;
using System;
using System.Globalization;

namespace SimuladorRedesSociais
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("WOOOOW, that's awesome");
            Post p1 = new Post(
                DateTime.Parse("27/09/2022 17:00:45"),
                "Traveling to Barcelona",
                "I'm going to visit ths wonderful city!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
        }

    }
}