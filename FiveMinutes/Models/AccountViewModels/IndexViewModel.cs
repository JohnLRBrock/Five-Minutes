using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiveMinutes.Data.AccountIndexViewModels
{
    public class IndexViewModel
    {
        public string ID { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
    }
}
