using System;
using System.Collections.Generic;

namespace StudentExercises {
    class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
    }
}