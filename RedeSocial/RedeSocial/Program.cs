using RedeSocial.Entities;
using System;

namespace RedeSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment1= new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");
            Post post1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelling to New Zealand",
                "I'm going to visit this wonderful country",
                12
                );
            post1.AddComment(comment1);
            post1.AddComment(comment2);
        }
    }
}
