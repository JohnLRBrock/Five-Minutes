using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FiveMinutes.Models
{
    public class FiveMinutesContext : DbContext
    {
        public FiveMinutesContext (DbContextOptions<FiveMinutesContext> options)
            : base(options)
        {
        }

        public DbSet<FiveMinutes.Models.UserRelationship> UserRelationship { get; set; }
    }
}
