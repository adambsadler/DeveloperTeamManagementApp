using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepository
{
    public class DevTeam
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public List<Developer> TeamMembers { get; set; } = new List<Developer>();

        public DevTeam() { }
        public DevTeam(string teamName)
        {
            TeamName = teamName;
        }
    }
}
