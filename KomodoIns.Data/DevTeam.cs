using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoIns.Data
{
    public class DevTeam
    {
        
    }
    public DevTeam (string teamName, int teamId, List<Developer> teamMembers)
    {
        TeamName = teamName;
        TeamId = teamId;
        TeamMembers = teamMembers;
    }

    public DevTeam (string teamName, int teamId)
    {
        TeamName = teamName;
        TeamId = teamId;
    
    }
            public string TeamName { get; set; }

            public int TeamId { get; set; }

            public List<Developer> TeamMembers { get; set; }
}