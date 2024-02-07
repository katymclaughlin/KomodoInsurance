using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using KomodoIns.Data;

namespace KomodoIns.Repository
{
    public class DeveloperRepo
    {
        private List<Developer> _developerDirectory = new List<Developer>();
        
        //NOTE - Add developers (Create)
        public bool AddDeveloperToList(Developer developer)
        {
            int startingCount = _developerDirectory.Count;
            _developerDirectory.Add(developer);
            bool wasAdded = (_developerDirectory.Count >startingCount) ? true : false;
            return wasAdded;
        }

        //NOTE - Be able to see a list of existing developers (Read)
        public List<Developer> GetDeveloperList()
        {
            return _developerDirectory;
        }

        //NOTE - get by id (search by id)
        public Developer GetDeveloperById(Guid id)
        {
            foreach (Developer developer in _developerDirectory)
            {
                if (developer.Id == id)
                {
                    return developer;
                }
            }
            return null;
        }

        //NOTE - Update developers (Update)
        public bool UpdateExistingDeveloper(int id, string Name)
        {
            Developer oldDeveloper = _developerDirectory[id];

            if (oldDeveloper != null)
            {
                oldDeveloper.Name = Name;

            _developerDirectory[id] = oldDeveloper;

                return true;
            }
            else
            {
                return false;
            }
        } 

        public Developer UpdateExistingDeveloperReturnRecord(Guid id, Developer newDeveloper)
        {
            Developer oldDeveloper = GetDeveloperById(id);

            if (oldDeveloper != null)
            {
                oldDeveloper.Name = newDeveloper.Name;
                oldDeveloper.Id = newDeveloper.Id;
                oldDeveloper.HasPluralsight = newDeveloper.HasPluralsight;
                return oldDeveloper;
            }
                return null;
        }
        

        //NOTE - Delete developers (Delete)
        public bool RemoveDeveloperFromList(int id)
        {
            
            int initialCount = _developerDirectory.Count;
            _developerDirectory.RemoveAt(id);

            if (initialCount > _developerDirectory.Count)
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