using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Bonus
{
    class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AdvisorId { get; set; }
        public List<CollegeCourse> Courses { get; set; }
        public CollegeProfessor Professor { get; set; }
    }
}
