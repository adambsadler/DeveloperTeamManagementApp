using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepository
{
    public class DevTeamRepository
    {
        private List<DevTeam> _listOfTeams = new List<DevTeam>();
        private int _countId;

        // Create
        public void AddTeamToList(DevTeam devTeam)
        {
            devTeam.TeamId = ++_countId;
            _listOfTeams.Add(devTeam);
        }

        // Read
        public List<DevTeam> GetTeamList()
        {
            return _listOfTeams;
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

        // Helper Method
        private DevTeam FindTeamById(int id)
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
