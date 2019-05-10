using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteMaster.Models
{
    public class Note
    {

        public int ID { get; set; }
        public string Thenote { get; set; }
        public int Rating { get; set; }


        public Note(string thenote, int rating)
        {
            Thenote = thenote;
            Rating = rating;
        }
    }
}
