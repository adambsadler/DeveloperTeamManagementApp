using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepository
{
    public class Developer
    {
        public int IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasPluralsightAccess { get; set; }

        public Developer() { }

        public Developer(string firstName, string lastName, bool hasPluralsightAccess)
        {
            FirstName = firstName;
            LastName = lastName;
            HasPluralsightAccess = hasPluralsightAccess;
        }
    }
}
