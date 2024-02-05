using System;
using System.Collections.Generic;
using System.Linq;
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
        public Developer GetDeveloperById(int id)
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
        public bool UpdateExistingDeveloper(int id, Developer newDeveloper)
        {
            Developer oldDeveloper = GetDeveloperById(id);

            if (oldDeveloper != null)
            {
                oldDeveloper.Name = newDeveloper.Name;
                oldDeveloper.Id = newDeveloper.Id;
                oldDeveloper.HasPluralsight = newDeveloper.HasPluralsight;
                return true;
            }
            else
            {
                return false;
            }
        } 

        public Developer UpdateExistingDeveloperReturnRecord(int id, Developer newDeveloper)
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
            Developer developer = GetDeveloperById(id);

            if (developer == null)
            {
            return false;
            }
            int initialCount = _developerDirectory.Count;
            _developerDirectory.Remove(developer);

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