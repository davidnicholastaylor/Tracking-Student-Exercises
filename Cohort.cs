using System.Collections.Generic;

namespace StudentExercises {
    class Cohort {

        public string CohortName { get; set; }

        public List<Student> Students = new List<Student>();

        public List<Instructor> Instructors = new List<Instructor>();
    }
}