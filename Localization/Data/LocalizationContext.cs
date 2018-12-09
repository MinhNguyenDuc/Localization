using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Localization.Models
{
    public class LocalizationContext : DbContext
    {
        public LocalizationContext (DbContextOptions<LocalizationContext> options)
            : base(options)
        {
        }

        public DbSet<Localization.Models.User> User { get; set; }
    }
}
