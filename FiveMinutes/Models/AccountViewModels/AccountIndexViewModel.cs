using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiveMinutes.Models.AccountViewModels
{
    public class AccountIndexViewModel
    {
        [Required]
        public List<ApplicationUser> Users{ get; set; }
        
        [Required]
        public string UserID { get; set; }
    }
}
