using System;
using System.Linq;

namespace Mission13.Models
{
    public interface ITeamRepo
    {
        IQueryable<Team> Teams { get; }
    }
    
}
