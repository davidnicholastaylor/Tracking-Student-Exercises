using System.Collections.Generic;

namespace StudentExercises {
    class Cohort {

        public string CohortName { get; set; }

        public List<string> Instructors = new List<string>();

        public List<string> Student = new List<string>();
    }
}