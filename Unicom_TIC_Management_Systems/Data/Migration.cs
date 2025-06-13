using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_Systems.Data
{
    internal class Migration
    {

        public static void CreatetablenotExists()
        {
            using (SQLiteConnection conn = DBConfigs.GetConnection())
            {

                string createTableQuery = @"
    CREATE TABLE IF NOT EXISTS Courses (
        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
        CourseName TEXT NOT NULL
    );

    CREATE TABLE IF NOT EXISTS Subjects (
        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
        SubjectName TEXT NOT NULL,
        CourseID INTEGER,
        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
    );

    CREATE TABLE IF NOT EXISTS Students (
        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
        StudentName TEXT NOT NULL,
        CourseID INTEGER,
        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
    );

    CREATE TABLE IF NOT EXISTS Exams (
        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
        SubjectID INTEGER,
        ExamName TEXT NOT NULL,
        FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
    );

    CREATE TABLE IF NOT EXISTS ExamMarks (
        StudentID INTEGER,
        ExamID INTEGER,
        ExamMark INTEGER NOT NULL,
        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
        FOREIGN KEY (ExamID) REFERENCES Exams(ExamID),
        PRIMARY KEY (ExamID, StudentID)
     );
       CREATE TABLE  IF NOT EXISTS Rooms (
        RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
       RoomName TEXT NOT NULL,
       RoomType TEXT NOT NULL
      );

    CREATE TABLE IF NOT EXISTS Timetable (
    Timetable_id INTEGER PRIMARY KEY AUTOINCREMENT,
    SubjectID INTEGER,
    Time_slot TEXT NOT NULL,
    RoomID INTEGER,
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
);

  CREATE TABLE IF NOT EXISTS User (
    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
    UserName TEXT NOT NULL,
    UserPassword TEXT NOT NULL,
    UserRole TEXT NOT NULL
);

    CREATE TABLE IF NOT EXISTS Teacher (
    TeacherID INTEGER PRIMARY KEY AUTOINCREMENT,
    TeacherName TEXT NOT NULL,
    
    Email TEXT NOT NULL UNIQUE,
    Phone TEXT NOT NULL
    
    
);

    CREATE TABLE IF NOT EXISTS TeacherCourse (
    TeacherID INTEGER NOT NULL,
    CourseID INTEGER NOT NULL,
    PRIMARY KEY (TeacherID, CourseID),
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)


    

);




   
";

                SQLiteCommand command = new SQLiteCommand(createTableQuery, conn);
                command.ExecuteNonQuery();
                



            }




        }
    }
}
