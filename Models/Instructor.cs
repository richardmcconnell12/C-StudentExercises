using System;
using System.Collections.Generic;

namespace StudentExercise
{
    class Instructor : NSSPerson
    {
        public string Specialty { get; set; }

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



