using System;
using System.Collections.Generic;

namespace StudentExercise
{
    class Instructor
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public string Specialty { get; set; }

        public string _cohort;

        public Instructor(string firstname, string lastname, string slackhandle, string specialty, string cohort)
        {
            _cohort = cohort;
            FirstName = firstname;
            LastName = lastname;
            SlackHandle = slackhandle;
            Specialty = specialty;
        }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.ExerciseList.Add(exercise);
        }
    }
}



