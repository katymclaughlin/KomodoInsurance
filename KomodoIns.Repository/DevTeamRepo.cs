using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoIns.Data;

namespace KomodoIns.Repository
{
    public class DevTeamRepo
    {

        public string TeamName { get; set; }

        public int TeamId { get; set; }

        public List<Developer> TeamMembers { get; set; }

            //NOTE - Managers need to be able to add a member to a team by their unique identifier (Create)
            //NOTE - Managers need to be able to remove a member from a team by their unique identifier (Delete)
            //NOTE - Managers will be able to create a team (Create)
            //NOTE - Add developers individually from the Developer Directory to that team (Create)
            //NOTE - Update a team (Update)
            //NOTE - Delete a team (Delete)
            //NOTE - Get a list of teams (Read)
    }
}