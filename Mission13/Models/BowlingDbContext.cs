using System;
using Microsoft.EntityFrameworkCore;

//context file. Brings in both Bowlers and teams
namespace Mission13.Models
{
    public class BowlingDbContext : DbContext
    {
        public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base(options)
        {
        }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
