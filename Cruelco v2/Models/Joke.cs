using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cruelco_v2.Models
{
    public class Joke
    {
        public int JokeId { get; set; }
        public string Opener { get; set; }
        public string Punchline { get; set; }
    }
}