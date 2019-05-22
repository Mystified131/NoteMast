using NoteMaster.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoteMaster.ViewModels
{
    public class ResultViewModel
    {

        [Required]
        public string Thenote { get; set; }
        [Required]
        public string Thedate { get; set; }
        [Required]
        public int Rating { get; set; }

        public List<Note> Noteslist { get; set; }
        public String Error { get; set; }
    }
}
