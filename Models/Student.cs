using System;
using System.Collections.Generic;

namespace StudentExercise
{
    class Student : NSSPerson
    {
        public List<Exercise> ExerciseList { get; set; } = new List<Exercise>();


        public Student(string firstname, string lastname, string slackhandle, string cohort)
        {
            FirstName = firstname;
            LastName = lastname;
            SlackHandle = slackhandle;
            _cohort = cohort;
        }

        public void ViewAssignedExercises()
        {
            Console.WriteLine($"{FirstName} {LastName} list of exercises include: ");
            Console.WriteLine("----------------------------");
            foreach (Exercise exercise in ExerciseList)
            {
                Console.WriteLine($"{exercise.Name}: written in {exercise.Language}");
                Console.WriteLine("");
            };
        }
    }
}