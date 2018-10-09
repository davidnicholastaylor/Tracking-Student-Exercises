using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();

    }
}