using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepository
{
    public class DeveloperRepository
    {
        private List<Developer> _listOfDevelopers = new List<Developer>();
        private int _countId;

        // Create
        public void AddDeveloperToList(Developer developer)
        {
            developer.IdNumber = ++_countId;
            _listOfDevelopers.Add(developer);
        }

        // Read
        public List<Developer> GetDeveloperList()
        {
            return _listOfDevelopers;
        }

        // Update
        public bool UpdateDeveloperInfo(int id, Developer newDeveloper)
        {
            Developer oldDeveloper = FindDeveloperById(id);

            if(oldDeveloper != null)
            {
                oldDeveloper.FirstName = newDeveloper.FirstName;
                oldDeveloper.LastName = newDeveloper.LastName;
                oldDeveloper.HasPluralsightAccess = newDeveloper.HasPluralsightAccess;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete
        public bool RemoveDeveloperFromList(int id)
        {
            Developer developer = FindDeveloperById(id);

            if(developer == null)
            {
                return false;
            }

            int initialCount = _listOfDevelopers.Count;
            _listOfDevelopers.Remove(developer);

            if(initialCount > _listOfDevelopers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper Method
        private Developer FindDeveloperById(int id)
        {
            foreach(Developer developer in _listOfDevelopers)
            {
                if(developer.IdNumber == id)
                {
                    return developer;
                }
            }
            return null;
        }
    }
}
