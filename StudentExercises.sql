CREATE TABLE Cohort (
	Id integer not null primary key autoincrement,
	CohortName text not null
);

CREATE TABLE Instructor (
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	FirstName TEXT NOT NULL,
	LastName TEXT NOT NULL,
	CohortId INTEGER NOT NULL,
	FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
);

CREATE TABLE Student (
	Id integer not null primary key autoincrement,
	FirstName text not null,
	LastName text not null,
	CohortId integer not null,
	foreign key(CohortId)  references Cohort(Id)
);

CREATE TABLE Exercise (
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	ExerciseName TEXT NOT NULL,
	ExerciseLanguage TEXT NOT NULL
	);
	
CREATE TABLE StudentExercise(
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	StudentId INTEGER NOT NULL,
	ExerciseId INTEGER NOT NULL,
		FOREIGN KEY(StudentId)  REFERENCES Student(Id),
		FOREIGN KEY(ExerciseId)  REFERENCES Exercise(Id)
);

INSERT INTO Cohort (CohortName) VALUES ('Cyclops');
INSERT INTO Cohort (CohortName) VALUES ('Unicorn');
INSERT INTO Cohort (CohortName) VALUES ('Velociraptor');

INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ('Chicken Monkey', 'JavaScript');
INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ('Battle of the Bands', 'JavaScript');
INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ('React Nutshell', 'JSX');
INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ('Library', 'C#');

INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (9, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (9, 3);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (8, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (8, 3);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (8, 4);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (6, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (6, 2);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (5, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (5, 2);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (5, 3);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (5, 4);


INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Helen', 'Hades', 7);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Jon', 'Tron', 7);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Lily', 'Paddington', 6);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Madi', 'Bobadi', 6);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Alex', 'Axel', 5);

INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ('Steve', 'Madden', 5);
INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ('Meg', 'Armstrong', 6);
INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ('Kimmy', 'Falcon', 7);

SELECT * FROM Cohort co
JOIN Student stu ON stu.CohortId = co.Id
JOIN Instructor inst ON inst.CohortId = co.Id;

SELECT * FROM StudentExercise se
JOIN Student stu ON stu.Id = se.StudentId
JOIN Exercise ex ON ex.Id = se.ExerciseId
;