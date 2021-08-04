using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Bonus
{
    class CollegeProfessor
    {
        public int ProfessorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsTenured { get; set; }
        public List<CollegeCourse> Courses { get; set; }
    }
}
