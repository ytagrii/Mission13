using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

//bowler repository
namespace Mission13.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingDbContext context { get; set; }
        public EFBowlerRepository(BowlingDbContext temp)
        {
            context = temp;
        }
        public IQueryable<Bowler> Bowlers => context.Bowlers;

        public void UpdateBowler(Bowler b)
        {
            context.Update(b);
            context.SaveChanges();
        }

        public void DeleteBowler(Bowler b)
        {
            context.Remove(b);
            context.SaveChanges();
        }

        public void AddBowler(Bowler b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public List<Bowler> GetAll(int id)
        {
            var b = context.Bowlers.Where(x => x.TeamID == id).ToList();
            return b;
        }
    }
}
