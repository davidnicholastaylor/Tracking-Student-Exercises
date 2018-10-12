CREATE TABLE Cohort (
	Id integer not null primary key autoincrement,
	CohortName text not null
);

CREATE TABLE Student (
	Id integer not null primary key autoincrement,
	FirstName text not null,
	LastName text not null,
	CohortId integer not null,
	foreign key(CohortId)  references Cohort(Id)
);

INSERT INTO Cohort (CohortName) VALUES ('Day Cohort 25');
INSERT INTO Cohort (CohortName) VALUES ('Day Cohort 26');
INSERT INTO Cohort (CohortName) VALUES ('Day Cohort 27');
INSERT INTO Cohort (CohortName) VALUES ('Day Cohort 28');

INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Helen', 'Chalmers', 3);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Raf', 'Cevallos', 1);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Jennifer', 'Lawson', 2);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ('Brendan', 'McCray', 4);




SELECT * FROM Cohort co
JOIN Student stu ON stu.CohortId = co.Id;