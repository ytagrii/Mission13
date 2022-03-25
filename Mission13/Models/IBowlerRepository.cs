using System;
using System.Collections.Generic;
using System.Linq;

namespace Mission13.Models
{
    public interface IBowlerRepository
    {
        IQueryable<Bowler> Bowlers {get;}

        public void UpdateBowler(Bowler b)
        {
        }
        public void DeleteBowler(Bowler b)
        {
        }
        public void AddBowler(Bowler b)
        {
        }
        public List<Bowler> GetAll(int id)
        {
            var x = new List<Bowler>();
            return x;
        }
    }
}
