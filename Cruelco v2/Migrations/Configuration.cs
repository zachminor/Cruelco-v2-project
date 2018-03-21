namespace Cruelco_v2.Migrations
{
    using Cruelco_v2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cruelco_v2.JokeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cruelco_v2.JokeContext context)
        {
            context.Joke.AddOrUpdate(
                p => p.JokeId,
                new Joke { JokeId = 9, Opener = "Palmer", Punchline = "Meredith" },
                new Joke { JokeId = 10, Opener = "Flenderson", Punchline = "Toby" },
                new Joke { JokeId = 11, Opener = "Hudson", Punchline = "Stanley" },
                new Joke { JokeId = 12, Opener = "Bratton", Punchline = "Creed" },
                new Joke { JokeId = 13, Opener = "Vance", Punchline = "Phyllis" },
                new Joke { JokeId = 14, Opener = "Howard", Punchline = "Ryan" },
                new Joke { JokeId = 15, Opener = "Philbin", Punchline = "Darryl" }
            );
        }
    }
}
