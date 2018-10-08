using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise chickenMonkey = new Exercise() {
                ExerciseName = "Chicken Monkey",
                Language = "JavaScript"
            };

            Exercise battleOfBands = new Exercise();
            battleOfBands.ExerciseName = "Battle of the Bands";
            battleOfBands.Language = "JavaScript";

            Exercise Library = new Exercise() {
                ExerciseName = "Library",
                Language = "C#"
            };

            Exercise reactNutshell = new Exercise();
            reactNutshell.ExerciseName = "React Nutshell";
            reactNutshell.Language = "JSX";

            Cohort unicorn = new Cohort() {
                CohortName = "Unicorn"
            };

            Cohort velociraptor = new Cohort();
            velociraptor.CohortName = "Velociraptor";


            Cohort cyclops = new Cohort() {
                CohortName = "Cyclops"
            };

            Student alex = new Student() {
                FirstName = "Alex",
                LastName = "Axel",
                SlackHandle = "AxelBeast"
            };

            Student madi = new Student();
            madi.FirstName = "Madi";
            madi.LastName = "Bobadi";
            madi.SlackHandle = "BobadiBambi";

            Student jon = new Student() {
                FirstName = "Jon",
                LastName = "Tron",
                SlackHandle = "JonTron",
            };

            Student helen = new Student();
            helen.FirstName = "Helen";
            helen.LastName = "Hades";
            helen.SlackHandle = "HelenOfHades";

            Instructor steve = new Instructor() {
                FirstName = "Steve",
                LastName = "Madden",
                SlackHandle = "SteveTheMadManMadden"
            };

            Instructor meg = new Instructor ();
            meg.FirstName = "Meg";
            meg.LastName = "Armstrong";
            meg.SlackHandle = "ArmyStrong";

            Instructor kimmy = new Instructor() {
                FirstName = "Kimmy",
                LastName = "Falcon",
                SlackHandle = "Falcon4Life"
            }
        }
    }
}
