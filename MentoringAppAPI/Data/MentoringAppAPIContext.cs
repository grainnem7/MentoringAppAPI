#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MentoringAppAPI.Entities;

namespace MentoringAppAPI.Data
{
    public class MentoringAppAPIContext : DbContext
    {
        public MentoringAppAPIContext (DbContextOptions<MentoringAppAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MentoringAppAPI.Entities.Mentor> Mentor { get; set; }

        public DbSet<MentoringAppAPI.Entities.Mentee> Mentee { get; set; }
    }
}
