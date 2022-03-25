using System;
using System.Linq;

//team repository
namespace Mission13.Models
{
    public class EFTeamRepo : ITeamRepo
    {
        private BowlingDbContext context { get; set; }
        public EFTeamRepo(BowlingDbContext temp)
        {
            context = temp;
        }
        public IQueryable<Team> Teams => context.Teams;
    }
}
