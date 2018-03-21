using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Cruelco_v2.Models
{
    public class JokeViewModel
    {
        public int? JokeId { get; set; }

        [DisplayName("Opener")]
        public string Opener { get; set; }

        [DisplayName("Punchline")]
        public string Punchline { get; set; }

        [DisplayName("Complete Joke")]
        public string CompleteJoke => Opener + "<>" + Punchline;
        //Environment.NewLine(needs to be defined)
    }
}