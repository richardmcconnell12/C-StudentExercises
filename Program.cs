using System;
using System.Collections.Generic;

namespace StudentExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var ExerciseList = new List<Exercise>();
            var FizzBuzz = new Exercise("Fizz Buzz", "JavaScript");
            var Journal = new Exercise("Journal", "HTML");
            var DiamondCutter = new Exercise("Diamond Cutter", "Ruby");
            var GetYourGlasses = new Exercise("Get Your Glasses", "C#");

            var Day32 = new Cohort("Day Cohort 32");
            var Night10 = new Cohort("Night Cohort 10");
            var Day13 = new Cohort("Day Cohort 13");

            var Bryan = new Student("Bryan", "Nilsen", "@BryanNilsen", "Day Cohort 13");
            var Ricky = new Student("Ricky", "McConnell", "@Rickydogsickdog", "Day Cohort 32");
            var Julian = new Student("Julian", "Swayze", "@Juls", "Night Cohort 10");
            var Corey = new Student("Corey", "Trevor", "@CoreyTrevor", "Day Cohort 32");

            var Steve = new Instructor("Steve", "Brownlee", "@SteveCoach", "Dad Jokes", "Day Cohort 32");
            var Adam = new Instructor("Adam", "Schaeffer", "@AdamShaef", "Snacks", "Day Cohort 13");
            var Andy = new Instructor("Andy", "Collins", "@AndyBoBandy", "Dancing", "Night Cohort 10");

            Steve.AssignExercise(Ricky, FizzBuzz);
            Steve.AssignExercise(Bryan, DiamondCutter);

            Adam.AssignExercise(Corey, GetYourGlasses);
            Adam.AssignExercise(Julian, Journal);

            Andy.AssignExercise(Ricky, GetYourGlasses);
            Andy.AssignExercise(Corey, DiamondCutter);

            Ricky.ViewAssignedExercises();
            Bryan.ViewAssignedExercises();
            Julian.ViewAssignedExercises();
            Corey.ViewAssignedExercises();

            Day13.StudentList.Add(Bryan);
            Day32.StudentList.Add(Ricky);
            Day32.StudentList.Add(Corey);
            Night10.StudentList.Add(Julian);

            Console.WriteLine("------------------");
            foreach (Student student in Day32.StudentList)
            {
                Console.WriteLine($"Day Cohort 32: {student.FirstName}");
            }

            Console.WriteLine("------------------");
            foreach (Student student in Night10.StudentList)
            {
                Console.WriteLine($"Night Cohort 10: {student.FirstName}");
            }

            Console.WriteLine("------------------");
            foreach (Student student in Day13.StudentList)
            {
                Console.WriteLine($"Day Cohort 13: {student.FirstName}");
            }

            var AllStudents = new List<Student>();
            AllStudents.Add(Bryan);
            AllStudents.Add(Ricky);
            AllStudents.Add(Julian);
            AllStudents.Add(Corey);

            var AllExercises = new List<Exercise>();
            AllExercises.Add(FizzBuzz);
            AllExercises.Add(Journal);
            AllExercises.Add(DiamondCutter);
            AllExercises.Add(GetYourGlasses);
        }
    }
}
