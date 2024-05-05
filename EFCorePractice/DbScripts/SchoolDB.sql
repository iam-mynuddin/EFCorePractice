-- Create database
CREATE DATABASE SchoolDB;
GO

-- Use the created database
USE SchoolDB;
GO

-- Create tables

-- Students table
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(10),
    DateOfBirth DATE
);

-- Teachers table
CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(10),
    DateOfBirth DATE
);

-- Courses table
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100),
    TeacherID INT,
    CONSTRAINT FK_Teacher_Course FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
);

-- Grades table
CREATE TABLE Grades (
    GradeID INT PRIMARY KEY,
    GradeName VARCHAR(10)
);

-- Enrollments table
CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    GradeID INT,
    CONSTRAINT FK_Student_Enrollment FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    CONSTRAINT FK_Course_Enrollment FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    CONSTRAINT FK_Grade_Enrollment FOREIGN KEY (GradeID) REFERENCES Grades(GradeID)
);

-- Subjects table
CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY,
    SubjectName VARCHAR(100)
);

-- Classes table
CREATE TABLE Classes (
    ClassID INT PRIMARY KEY,
    ClassName VARCHAR(50),
    TeacherID INT,
    CONSTRAINT FK_Teacher_Class FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
);

-- ClassSubjects table (Mapping table between Classes and Subjects)
CREATE TABLE ClassSubjects (
    ClassID INT,
    SubjectID INT,
    CONSTRAINT PK_ClassSubject PRIMARY KEY (ClassID, SubjectID),
    CONSTRAINT FK_Class_ClassSubject FOREIGN KEY (ClassID) REFERENCES Classes(ClassID),
    CONSTRAINT FK_Subject_ClassSubject FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);

-- Exams table
CREATE TABLE Exams (
    ExamID INT PRIMARY KEY,
    ExamName VARCHAR(100),
    Date DATE,
    CourseID INT,
    CONSTRAINT FK_Course_Exam FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

-- ExamResults table
CREATE TABLE ExamResults (
    ResultID INT PRIMARY KEY,
    StudentID INT,
    ExamID INT,
    GradeID INT,
    CONSTRAINT FK_Student_Result FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    CONSTRAINT FK_Exam_Result FOREIGN KEY (ExamID) REFERENCES Exams(ExamID),
    CONSTRAINT FK_Grade_Result FOREIGN KEY (GradeID) REFERENCES Grades(GradeID)
);

-- Insert sample data

-- Students
INSERT INTO Students (StudentID, FirstName, LastName, Gender, DateOfBirth)
VALUES (1, 'John', 'Doe', 'Male', '2000-01-01'),
       (2, 'Jane', 'Smith', 'Female', '2001-03-15');

-- Teachers
INSERT INTO Teachers (TeacherID, FirstName, LastName, Gender, DateOfBirth)
VALUES (1, 'Michael', 'Johnson', 'Male', '1985-05-20'),
       (2, 'Emily', 'Brown', 'Female', '1980-10-10');

-- Courses
INSERT INTO Courses (CourseID, CourseName, TeacherID)
VALUES (1, 'Mathematics', 1),
       (2, 'Science', 2);

-- Grades
INSERT INTO Grades (GradeID, GradeName)
VALUES (1, 'A'),
       (2, 'B'),
       (3, 'C');

-- Enrollments
INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID, GradeID)
VALUES (1, 1, 1, 1),
       (2, 2, 2, 2);

-- Subjects
INSERT INTO Subjects (SubjectID, SubjectName)
VALUES (1, 'Algebra'),
       (2, 'Biology');

-- Classes
INSERT INTO Classes (ClassID, ClassName, TeacherID)
VALUES (1, 'Class A', 1),
       (2, 'Class B', 2);

-- ClassSubjects
INSERT INTO ClassSubjects (ClassID, SubjectID)
VALUES (1, 1),
       (2, 2);

-- Exams
INSERT INTO Exams (ExamID, ExamName, Date, CourseID)
VALUES (1, 'Midterm Exam', '2024-04-01', 1),
       (2, 'Final Exam', '2024-06-01', 2);

-- ExamResults
INSERT INTO ExamResults (ResultID, StudentID, ExamID, GradeID)
VALUES (1, 1, 1, 1),
       (2, 2, 2, 2);
-- Insert additional sample data

-- Students
INSERT INTO Students (StudentID, FirstName, LastName, Gender, DateOfBirth)
VALUES 
    (5, 'Emma', 'Garcia', 'Female', '2005-02-12'),
    (6, 'William', 'Lopez', 'Male', '2006-08-20'),
    (7, 'Olivia', 'Martinez', 'Female', '2004-04-05'),
    (8, 'James', 'Hernandez', 'Male', '2003-12-10'),
    (9, 'Isabella', 'Gonzalez', 'Female', '2002-10-15'),
    (10, 'Ethan', 'Rodriguez', 'Male', '2005-06-30'),
    (11, 'Sophia', 'Perez', 'Female', '2004-09-22'),
    (12, 'Alexander', 'Sanchez', 'Male', '2003-03-18'),
    (13, 'Mia', 'Taylor', 'Female', '2006-01-25'),
    (14, 'Michael', 'Rivera', 'Male', '2002-07-08');

-- Teachers
INSERT INTO Teachers (TeacherID, FirstName, LastName, Gender, DateOfBirth)
VALUES 
    (5, 'Charlotte', 'King', 'Female', '1980-06-15'),
    (6, 'Daniel', 'Clark', 'Male', '1975-09-30'),
    (7, 'Emily', 'Scott', 'Female', '1982-02-25'),
    (8, 'Jacob', 'Green', 'Male', '1978-11-12'),
    (9, 'Abigail', 'Adams', 'Female', '1985-07-20'),
    (10, 'Matthew', 'Baker', 'Male', '1973-04-05'),
    (11, 'Ava', 'Campbell', 'Female', '1988-10-10'),
    (12, 'William', 'Bailey', 'Male', '1979-08-08'),
    (13, 'Samantha', 'Wright', 'Female', '1983-03-12'),
    (14, 'Joseph', 'Evans', 'Male', '1981-05-18');

-- Courses
INSERT INTO Courses (CourseID, CourseName, TeacherID)
VALUES 
    (5, 'Physics', 5),
    (6, 'Chemistry', 6),
    (7, 'Geography', 7),
    (8, 'Computer Science', 8),
    (9, 'Literature', 9),
    (10, 'Art', 10),
    (11, 'Physical Education', 11),
    (12, 'Music', 12),
    (13, 'Economics', 13),
    (14, 'Psychology', 14);

-- Grades
INSERT INTO Grades (GradeID, GradeName)
VALUES 
    (6, 'D-'),
    (7, 'D'),
    (8, 'D+'),
    (9, 'F-'),
    (10, 'F');

-- Enrollments
INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID, GradeID)
VALUES 
    (5, 5, 5, 6),
    (6, 6, 6, 7),
    (7, 7, 7, 8),
    (8, 8, 8, 9),
    (9, 9, 9, 10),
    (10, 10, 10, 6),
    (11, 11, 11, 7),
    (12, 12, 12, 8),
    (13, 13, 13, 9),
    (14, 14, 14, 10);

-- Subjects
INSERT INTO Subjects (SubjectID, SubjectName)
VALUES 
    (5, 'Physics'),
    (6, 'Chemistry'),
    (7, 'Geography'),
    (8, 'Computer Science'),
    (9, 'Literature'),
    (10, 'Art'),
    (11, 'Physical Education'),
    (12, 'Music'),
    (13, 'Economics'),
    (14, 'Psychology');

-- Classes
INSERT INTO Classes (ClassID, ClassName, TeacherID)
VALUES 
    (5, 'Class E', 5),
    (6, 'Class F', 6),
    (7, 'Class G', 7),
    (8, 'Class H', 8),
    (9, 'Class I', 9),
    (10, 'Class J', 10),
    (11, 'Class K', 11),
    (12, 'Class L', 12),
    (13, 'Class M', 13),
    (14, 'Class N', 14);

-- ClassSubjects
INSERT INTO ClassSubjects (ClassID, SubjectID)
VALUES 
    (5, 5),
    (6, 6),
    (7, 7),
    (8, 8),
    (9, 9),
    (10, 10),
    (11, 11),
    (12, 12),
    (13, 13),
    (14, 14);

-- Exams
INSERT INTO Exams (ExamID, ExamName, Date, CourseID)
VALUES 
    (5, 'Physics Midterm', '2024-04-10', 5),
    (6, 'Chemistry Final', '2024-06-20', 6),
    (7, 'Geography Midterm', '2024-04-20', 7),
    (8, 'Computer Science Final', '2024-06-25', 8),
    (9, 'Literature Midterm', '2024-04-15', 9),
    (10, 'Art Final', '2024-06-30', 10),
    (11, 'Physical Education Midterm', '2024-04-25', 11),
    (12, 'Music Final', '2024-07-05', 12),
    (13, 'Economics Midterm', '2024-04-30', 13),
    (14, 'Psychology Final', '2024-07-10', 14);

-- ExamResults
INSERT INTO ExamResults (ResultID, StudentID, ExamID, GradeID)
VALUES 
    (5, 5, 5, 6),
    (6, 6, 6, 7),
    (7, 7, 7, 8),
    (8, 8, 8, 9),
    (9, 9, 9, 10),
    (10, 10, 10, 6),
    (11, 11, 11, 7),
    (12, 12, 12, 8),
    (13, 13, 13, 9),
    (14, 14, 14, 10);
-- Create 5 additional tables

-- Departments table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

-- ClassesDepartments table (Mapping table between Classes and Departments)
CREATE TABLE ClassDepartments (
    ClassID INT,
    DepartmentID INT,
    CONSTRAINT PK_ClassDepartment PRIMARY KEY (ClassID, DepartmentID),
    CONSTRAINT FK_Class_ClassDepartment FOREIGN KEY (ClassID) REFERENCES Classes(ClassID),
    CONSTRAINT FK_Department_ClassDepartment FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- Assignments table
CREATE TABLE Assignments (
    AssignmentID INT PRIMARY KEY,
    AssignmentName VARCHAR(100),
    DueDate DATE,
    CourseID INT,
    CONSTRAINT FK_Course_Assignment FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

-- AssignmentResults table
CREATE TABLE AssignmentResults (
    ResultID INT PRIMARY KEY,
    StudentID INT,
    AssignmentID INT,
    GradeID INT,
    CONSTRAINT FK_Student_AssignmentResult FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    CONSTRAINT FK_Assignment_AssignmentResult FOREIGN KEY (AssignmentID) REFERENCES Assignments(AssignmentID),
    CONSTRAINT FK_Grade_AssignmentResult FOREIGN KEY (GradeID) REFERENCES Grades(GradeID)
);

-- Clubs table
CREATE TABLE Clubs (
    ClubID INT PRIMARY KEY,
    ClubName VARCHAR(100)
);

-- ClubMembers table (Mapping table between Students and Clubs)
CREATE TABLE ClubMembers (
    StudentID INT,
    ClubID INT,
    CONSTRAINT PK_ClubMember PRIMARY KEY (StudentID, ClubID),
    CONSTRAINT FK_Student_ClubMember FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    CONSTRAINT FK_Club_ClubMember FOREIGN KEY (ClubID) REFERENCES Clubs(ClubID)
);
-- Insert data into the newly created tables

-- Departments
INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES 
    (1, 'Mathematics'),
    (2, 'Science'),
    (3, 'History'),
    (4, 'English'),
    (5, 'Arts');

-- ClassDepartments
INSERT INTO ClassDepartments (ClassID, DepartmentID)
VALUES 
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (5, 5);

-- Assignments
INSERT INTO Assignments (AssignmentID, AssignmentName, DueDate, CourseID)
VALUES 
    (1, 'Math Assignment 1', '2024-05-15', 1),
    (2, 'Science Experiment', '2024-05-20', 2),
    (3, 'History Research Paper', '2024-05-25', 3),
    (4, 'English Essay', '2024-05-30', 4),
    (5, 'Art Project', '2024-06-05', 5);

-- AssignmentResults
INSERT INTO AssignmentResults (ResultID, StudentID, AssignmentID, GradeID)
VALUES 
    (1, 1, 1, 6),
    (2, 2, 2, 7),
    (3, 3, 3, 8),
    (4, 4, 4, 9),
    (5, 5, 5, 10);

-- Clubs
INSERT INTO Clubs (ClubID, ClubName)
VALUES 
    (1, 'Chess Club'),
    (2, 'Debate Club'),
    (3, 'Art Club'),
    (4, 'Music Club'),
    (5, 'Sports Club');

-- ClubMembers
INSERT INTO ClubMembers (StudentID, ClubID)
VALUES 
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (5, 5);
