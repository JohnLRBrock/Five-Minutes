using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiveMinutes.Models
{
    public class UserRelationship
    {
        [Required]
        public string ID { get; set; }

        [Required]
        [HiddenInput]
        public string UserID { get; set; }

        [Required]
        [HiddenInput]
        public string FriendID { get; set; }

        [Required]
        [HiddenInput]
        [DefaultValue(false)]
        public bool Accepted { get; set; } = false;
    }
}
