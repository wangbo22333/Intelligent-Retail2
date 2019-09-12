using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Intelligent_Retail2.Models;

namespace Intelligent_Retail2.Models
{
    public class Intelligent_Retail2Context : DbContext
    {
        public Intelligent_Retail2Context (DbContextOptions<Intelligent_Retail2Context> options)
            : base(options)
        {
        }

        public DbSet<Intelligent_Retail2.Models.User> User { get; set; }

        public DbSet<Intelligent_Retail2.Models.AdminUser> AdminUser { get; set; }
    }
}
