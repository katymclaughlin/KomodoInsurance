using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoIns.Data;

namespace KomodoIns.Repository
{
    public class DevTeamRepo
    {
        private List<DevTeam> _developerTeamDirectory = new List<DevTeam>();

            //NOTE - Managers will be able to create a team (Create)

            public void CreateTeam(DevTeam developerTeam)
        {
            _developerTeamDirectory.Add(developerTeam);
        }
    }

            //NOTE - Managers need to be able to add a member to a team by their unique identifier (Create)

    public class AddMemberById 
    {
        
    }
            //NOTE - Managers need to be able to remove a member from a team by their unique identifier (Delete)
            //NOTE - Add developers individually from the Developer Directory to that team (Create)
            //NOTE - Update a team (Update)
            //NOTE - Delete a team (Delete)
            //NOTE - Get a list of teams (Read)

}