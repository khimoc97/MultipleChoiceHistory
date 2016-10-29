using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidLearning.db
{
    class DBCreate
    {
        public static void CreateDB()
        {
            SQLiteConnection.CreateFile("dbHistory.dat");
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=dbHistory.dat;Version=3;");
            m_dbConnection.Open();


            string sql = "create table Subjects (ID integer identity primary key, Name nvarchar(50))";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table Chapters (ID integer identity primary key, Name nvarchar(50), SubjectID integer, foreign key(SubjectID) references Subjects(ID))";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table Lessons (ID integer identity primary key, Name nvarchar(50), ChaptersID integer, Description nvarchar(1000), foreign key(ChaptersID) references Chapters(ID))";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table Questions(ID integer identity primary key, LessonID integer, Question nvarchar(200), type integer, Ans1 nvarchar(50), Ans2 nvarchar(50),Ans3 nvarchar(50),Ans4 nvarchar(50), CorrectAns int, foreign key(LessonID) references Lessons(ID))";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into Subjects (name) values ('Lịch Sử 6')";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();



        }
    }
}
