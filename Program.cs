using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercises
            Exercise chickenMonkey = new Exercise()
            {
                ExerciseName = "Chicken Monkey",
                Language = "JavaScript"
            };

            Exercise battleOfBands = new Exercise();
            battleOfBands.ExerciseName = "Battle of the Bands";
            battleOfBands.Language = "JavaScript";

            Exercise Library = new Exercise()
            {
                ExerciseName = "Library",
                Language = "C#"
            };

            Exercise reactNutshell = new Exercise();
            reactNutshell.ExerciseName = "React Nutshell";
            reactNutshell.Language = "JSX";

            // Cohorts
            Cohort unicorn = new Cohort()
            {
                CohortName = "Unicorn"
            };

            Cohort velociraptor = new Cohort();
            velociraptor.CohortName = "Velociraptor";


            Cohort cyclops = new Cohort()
            {
                CohortName = "Cyclops"
            };

            // Students
            Student alex = new Student()
            {
                FirstName = "Alex",
                LastName = "Axel",
                Cohort = cyclops,
                SlackHandle = "AxelBeast"
            };

            Student madi = new Student();
            madi.FirstName = "Madi";
            madi.LastName = "Bobadi";
            madi.Cohort = unicorn;
            madi.SlackHandle = "BobadiBambi";

            Student jon = new Student()
            {
                FirstName = "Jon",
                LastName = "Tron",
                Cohort = velociraptor,
                SlackHandle = "JonTron",
            };

            Student helen = new Student();
            helen.FirstName = "Helen";
            helen.LastName = "Hades";
            helen.Cohort = velociraptor;
            helen.SlackHandle = "HelenOfHades";

            // Instructors
            Instructor steve = new Instructor()
            {
                FirstName = "Steve",
                LastName = "Madden",
                Cohort = cyclops,
                SlackHandle = "SteveTheMadManMadden"
            };

            Instructor meg = new Instructor();
            meg.FirstName = "Meg";
            meg.LastName = "Armstrong";
            meg.Cohort = unicorn;
            meg.SlackHandle = "ArmyStrong";

            Instructor kimmy = new Instructor()
            {
                FirstName = "Kimmy",
                LastName = "Falcon",
                Cohort = velociraptor,
                SlackHandle = "Falcon4Life"
            };

            // Assign exercise

            steve.AssignExercise(alex, chickenMonkey);
            kimmy.AssignExercise(helen, chickenMonkey);
            kimmy.AssignExercise(jon, chickenMonkey);
            meg.AssignExercise(madi, chickenMonkey);
            steve.AssignExercise(alex, reactNutshell);
            kimmy.AssignExercise(helen, battleOfBands);
            kimmy.AssignExercise(jon, battleOfBands);
            kimmy.AssignExercise(helen, reactNutshell);
            meg.AssignExercise(madi, reactNutshell);
            meg.AssignExercise(madi, Library);

            // Create a list of students
            List<Student> students = new List<Student>(){
                alex,
                madi,
                jon,
                helen
            };

            // Create a list of exercises
            List<Exercise> exercises = new List<Exercise>(){
                chickenMonkey,
                battleOfBands,
                reactNutshell,
                Library
            };

            // Create a list of cohorts
            List<Cohort> cohorts = new List<Cohort>(){
                unicorn,
                cyclops, 
                velociraptor
            };

            // Create a list of instructors
            List<Instructor> instructors = new List<Instructor>(){
                steve,
                kimmy,
                meg
            };

            // Loop through exercise list
            // Create a list for assigned students
            // Loop through student list
            // If a students exercise contains the looped exercise list
            // Aadd an assignedStudent to the exercise by their FullName
            // Console log the list exercises with all the students working on each exercise
            foreach (Exercise exercise in exercises)
            {   
                List<string> assignedStudents = new List<string>();
                foreach (Student student in students) {
                if (student.Exercises.Contains(exercise))
                {
                    assignedStudents.Add(student.FullName);
                }
            }
                    // Console.WriteLine($"{exercise.ExerciseName} is being worked on by {string.Join(", ", assignedStudents)}");
            }

            // List exercises for Javascript with where linq method

            IEnumerable<Exercise> JS = from JavaScript in exercises
            where JavaScript.Language == "JavaScript"
            select JavaScript;

            JS.ToList().ForEach(e => Console.WriteLine(e.ExerciseName));

            // List students in a cohort with linq method
            IEnumerable<Student> stu = from student in students
            where student.Cohort == velociraptor
            select student;

            stu.ToList().ForEach(s => Console.WriteLine($"{s.FullName} is in Cohort {s.Cohort.CohortName}"));

            // List instructors in a cohort with linq method
            IEnumerable<Instructor> inst = from instructor in instructors
            where instructor.Cohort == velociraptor
            select instructor;

            inst.ToList().ForEach(i => Console.WriteLine($"{i.FirstName} {i.LastName} teaches {i.Cohort.CohortName}"));

            // List students by their lastname

            var stud = students.Select(s => s.LastName);

            stud.ToList().ForEach(s => Console.WriteLine(s));
        }
    }
}
