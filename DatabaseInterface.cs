using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Dapper;
using DapperDepartments.Models;
using Microsoft.Data.Sqlite;

namespace StudentExercises {
    public class DatabaseInterface {
        public static SqliteConnection Connection {
            get {
                string _connectString = $"Data Source=./StudentExercises.db";
                return new SqliteConnection (_connectString);
            }
        }

        public static void CheckStudentTable () {
            SqliteConnection db = DatabaseInterface.Connection;

            try {
                List<Student> students = db.Query<Student>
                    ("SELECT Id FROM Student").ToList ();
            } catch (System.Exeception ex) {
                if (ex.Message.Contains ("no such table")) {
                    db.Execute (@"
                    CREATE TABLE Student (
                    Id integer not null primary key autoincrement,
                    FirstName text not null,
                    LastName text not null,
                    CohortId integer not null,
                    foreign key(CohortId)  references Cohort(Id)"
                    );

                    db.Execute (@"
                    INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Helen', 'Hades', 3);
                    INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Jon', 'Tron', 3);
                    INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Lily', 'Paddington', 2);
                    INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Madi', 'Bobadi', 2);
                    INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Alex', 'Axel', 1);"
                    );
                }
            }
        }
        public static void CheckCohortTable () {
            SqliteConnection db = DatabaseInterface.Connection;

            try {
                List<Cohort> cohorts = db.Query<Cohort>
                    ("SELECT Id FROM Cohort").ToList ();
            } catch (System.Exeception ex) {
                if (ex.Message.Contains ("no such table")) {
                    db.Execute (@"
                    CREATE TABLE Cohort (
                    Id integer not null primary key autoincrement,
                    CohortName text not null);
                    ");

                    db.Execute (@"
                    INSERT INTO Cohort (CohortName) VALUES ('Cyclops');
                    INSERT INTO Cohort (CohortName) VALUES ('Unicorn');
                    INSERT INTO Cohort (CohortName) VALUES ('Velociraptor');
                    ");
                }
            }
        }
        public static void CheckInstructorTable () {
            SqliteConnection db = DatabaseInterface.Connection;

            try {
                List<Instructor> instructors = db.Query<Instructor>
                    ("SELECT Id FROM Instructor").ToList ();
            } catch (System.Exeception ex) {
                if (ex.Message.Contains ("no such table")) {
                    db.Execute (@"
                    CREATE TABLE Instructor (
                    Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    FirstName TEXT NOT NULL,
                    LastName TEXT NOT NULL,
                    CohortId INTEGER NOT NULL,
                    FOREIGN KEY(CohortId) REFERENCES Cohort(Id));
                    ");

                    db.Execute (@"
                    INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ('Steve', 'Madden', 1);
                    INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ('Meg', 'Armstrong', 2);
                    INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ('Kimmy', 'Falcon', 3);
                    ");
                }
            }
        }
        public static void CheckExerciseTable () {
            SqliteConnection db = DatabaseInterface.Connection;

            try {
                List<Exercise> exercises = db.Query<Exercise>
                    ("SELECT Id FROM Exercise").ToList ();
            } catch (System.Exeception ex) {
                if (ex.Message.Contains ("no such table")) {
                    db.Execute (@"
                    CREATE TABLE Exercise (
                    Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    ExerciseName TEXT NOT NULL,
                    ExerciseLanguage TEXT NOT NULL);
                    ");

                    db.Execute (@"
                    INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ('Chicken Monkey', 'JavaScript');
                    INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ('Battle of the Bands', 'JavaScript');
                    INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ('React Nutshell', 'JSX');
                    INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ('Library', 'C#');
                    ");
                }
            }
        }
        public static void CheckStudentExerciseTable () {
            SqliteConnection db = DatabaseInterface.Connection;

            try {
                List<StudentExercise> studentExercises = db.Query<StudentExercise>
                    ("SELECT Id FROM StudentExercise").ToList ();
            } catch (System.Exeception ex) {
                if (ex.Message.Contains ("no such table")) {
                    db.Execute (@"
                    CREATE TABLE StudentExercise(
                    Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    StudentId INTEGER NOT NULL,
                    ExerciseId INTEGER NOT NULL,
                        FOREIGN KEY(StudentId)  REFERENCES Student(Id),
                        FOREIGN KEY(ExerciseId)  REFERENCES Exercise(Id));
                    ");

                    db.Execute (@"
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (8, 1);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (8, 3);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (7, 1);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (7, 3);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (7, 4);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (5, 1);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (5, 2);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (4, 1);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (4, 2);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (4, 3);
                    INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (4, 4);
                    ");
                }
            }
        }
    }
}