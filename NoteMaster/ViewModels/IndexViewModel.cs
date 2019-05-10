using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoteMaster.ViewModels
{
    public class IndexViewModel
    {
        [Required]
        public string thenote { get; set; }
        [Required]
        public int rating { get; set; }
    }
}
