using NoteMaster.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoteMaster.ViewModels
{
    public class RemoveViewModel
    {
        [Required]
        public int NewElement1 { get; set; }
        public List<Note> TheList { get; set; }
    }
}
