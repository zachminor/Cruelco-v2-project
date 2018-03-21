using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cruelco_v2.Models
{
    public class JokeListViewModel
    {
        public JokeListViewModel()
        {
            Joke = new List<JokeViewModel>();
        }
        public List<JokeViewModel> Joke { get; set; }
        public int TotalJokes { get; set; }
    }
}