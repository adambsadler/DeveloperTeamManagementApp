using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepository
{
    public class DevTeamRepo
    {
        private List<DevTeam> _listOfTeams = new List<DevTeam>();
        private int _countId;

        // Create
        public void AddTeamToList(DevTeam devTeam)
        {
            devTeam.TeamId = ++_countId;
            _listOfTeams.Add(devTeam);
        }

        public void AddDeveloperToTeam(List<Developer> developers, DevTeam devTeam)
        {
            foreach (Developer developer in developers)
            {
                devTeam.TeamMembers.Add(developer);
            }
        }

        // Read
        public List<DevTeam> GetTeamList()
        {
            return _listOfTeams;
        }

        public List<Developer> GetTeamMembers(DevTeam devTeam)
        {
            return devTeam.TeamMembers;
        }

        // Update
        public bool UpdateTeamInfo(int id, DevTeam newDevTeam)
        {
            DevTeam oldDevTeam = FindTeamById(id);

            if (oldDevTeam != null)
            {
                oldDevTeam.TeamName = newDevTeam.TeamName;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete
        public bool RemoveTeamFromList(int id)
        {
            DevTeam devTeam = FindTeamById(id);

            if (devTeam == null)
            {
                return false;
            }

            int initialCount = _listOfTeams.Count;
            _listOfTeams.Remove(devTeam);

            if (initialCount > _listOfTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveDeveloperFromTeam(List<Developer> developers, DevTeam devTeam)
        {
            foreach (Developer developer in developers)
            {
                devTeam.TeamMembers.Remove(developer);
            }
        }

        // Helper Method
        public DevTeam FindTeamById(int id)
        {
            foreach(DevTeam devTeam in _listOfTeams)
            {
                if(devTeam.TeamId == id)
                {
                    return devTeam;
                }
            }
            return null;
        }
    }
}
