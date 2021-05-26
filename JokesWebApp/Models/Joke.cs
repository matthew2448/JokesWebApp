using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public String Question { get; set; }
        public String Answer { get; set; }

        public Joke()
        {

        }
    }
}
