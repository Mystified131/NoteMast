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
        public string Thedate { get; set; }
        public int Rating { get; set; }


        public Note(string thenote, string thedate, int rating)
        {
            Thenote = thenote;
            Thedate = thedate;
            Rating = rating;
        }
    }
}
