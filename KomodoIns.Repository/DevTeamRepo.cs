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

            public bool CreateTeam(DevTeam developerTeam)
        {
            int startingCount = _developerTeamDirectory.Count;
            _developerTeamDirectory.Add(developerTeam);
            bool wasAdded = (_developerTeamDirectory.Count > startingCount) ? true: false;
            return wasAdded;
        }

            //NOTE - Managers need to be able to add a member to a team by their unique identifier (Create)

            public class AddMemberById 
            {
        
            }

            //NOTE - Get a list of teams (Read)

            public List<DevTeam> GetListofTeams()
            {
            return _developerTeamDirectory;
            }

//NOTE - Managers need to be able to remove a member from a team by their unique identifier (Delete)
//NOTE - Add developers individually from the Developer Directory to that team (Create)
            
            //NOTE - Update a team (Update)

            /*public bool UpdateExistingTeam(int TeamId, string TeamName)
            {
            DevTeam oldTeam = _developerTeamDirectory[TeamId];

            if (oldTeam != null)
            {
                oldTeam.TeamName = TeamName;

            _developerTeamDirectory[TeamId] = oldTeam;

                return true;
            }
            else
            {
                return false;
            }
            } */

            public bool UpdateExistingTeam(int TeamId, int fieldId, string updatedValue)
            {
            DevTeam oldContent = _developerTeamDirectory[TeamId];
            if (fieldId == 1)
            {
                oldContent.TeamName = updatedValue;
            }
            else if (fieldId == 2)
            {
                oldContent.TeamId = Convert.ToInt32(updatedValue);
            }
            _developerTeamDirectory[TeamId] = oldContent;

            return true;
            }
            
            //NOTE - Delete a team (Delete)

            public bool RemoveTeamFromList(int id)
            {
            
            int initialCount = _developerTeamDirectory.Count;
            _developerTeamDirectory.RemoveAt(id);

            if (initialCount > _developerTeamDirectory.Count)
            {
            return true;
            }
            else
            {
            return false;
            }
            }

    }
}