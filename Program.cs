﻿using System;

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

            // Assign

            steve.AssignExercise(alex, chickenMonkey);
            kimmy.AssignExercise(helen, chickenMonkey);
            kimmy.AssignExercise(jon, chickenMonkey);
            meg.AssignExercise(madi, chickenMonkey);
            steve.AssignExercise(alex, reactNutshell);
            kimmy.AssignExercise(helen, battleOfBands);
            kimmy.AssignExercise(jon, battleOfBands);
            kimmy.AssignExercise(helen, reactNutshell);
            meg.AssignExercise(madi, reactNutshell);
        }
    }
}
