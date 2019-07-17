using System;
using System.Collections.Generic;

namespace StudentExercise
{
    class Cohort
    {
        public string CohortName { get; set; }

        public List<Student> StudentList { get; set; }

        public List<Instructor> InstructorList { get; set; }

        public Cohort(string Cohortname)
        {
            CohortName = Cohortname;
            StudentList = new List<Student>();
            InstructorList = new List<Instructor>();
        }
    }
}