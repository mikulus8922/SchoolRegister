using School.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories
{
    public class AbsencesRepository : Repository, IAbsencesRepository
    {
        public bool AddAbsence(int studentID, int lessonID, bool isExcused)
        {
            string query = $@"INSERT INTO Absences ([StudentID], [LessonID], [Excused]) 
                            Values ('{studentID}', '{lessonID}', '{isExcused}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool AddAbsence(int studentID, int lessonID, bool isExcused, string description)
        {
            string query = $@"INSERT INTO Absences ([StudentID], [LessonID], [Excused], [Description]) 
                            Values ('{studentID}', '{lessonID}', '{isExcused}', '{description}'); ";

            Connection.Open();

            SqlCommand commandAddToBlacklist = new SqlCommand(query, Connection);
            commandAddToBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public bool EditAbsence(int absenceID, bool isExcused, string description)
        {
            string query = $@"UPDATE Absences SET Excused='{isExcused}, Description='{description}''
                            WHERE ID='{absenceID}'; ";


            Connection.Open();

            SqlCommand commandEditBlacklist = new SqlCommand(query, Connection);
            commandEditBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public DataTable GetAbsences()
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Classes.Name, Lessons.Name, Lessons.Date, Absences.Excused, Absences.Description, Absences.StudentID AS StudentID, Absences.LessonID AS LessonID, Absences.ID AS AbsenceID FROM Absences
							INNER JOIN Students ON Students.ID = Absences.StudentID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            INNER JOIN Classes ON Classes.ID = Students.ClassID
							INNER JOIN Lessons ON Lessons.ID = Absences.LessonID; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetStudentAbsences(int studentID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Classes.Name, Lessons.Name, Lessons.Date, Absences.Excused, Absences.Description, Absences.StudentID AS StudentID, Absences.LessonID AS LessonID, Absences.ID AS AbsenceID FROM Absences
							INNER JOIN Students ON Students.ID = Absences.StudentID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            INNER JOIN Classes ON Classes.ID = Students.ClassID
							INNER JOIN Lessons ON Lessons.ID = Absences.LessonID
							WHERE Absences.StudentID = ''{studentID}; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetTeacherAbsences(int teacherID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Classes.Name, Lessons.Name, Lessons.Date, Absences.Excused, Absences.Description, Absences.StudentID AS StudentID, Absences.LessonID AS LessonID, Absences.ID AS AbsenceID FROM Absences
							INNER JOIN Students ON Students.ID = Absences.StudentID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            INNER JOIN Classes ON Classes.ID = Students.ClassID
							INNER JOIN Lessons ON Lessons.ID = Absences.LessonID
							WHERE Lessons.TeacherID = {teacherID}; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public DataTable GetTeacherClassAbsences(int teacherID, int classID)
        {
            string query = $@"SELECT SystemUsers.FirstName, SystemUsers.LastName, Classes.Name, Lessons.Name, Lessons.Date, Absences.Excused, Absences.Description, Absences.StudentID AS StudentID, Absences.LessonID AS LessonID, Absences.ID AS AbsenceID FROM Absences
							INNER JOIN Students ON Students.ID = Absences.StudentID
                            INNER JOIN SystemUsers ON SystemUsers.ID = Students.SystemUserID
                            INNER JOIN Classes ON Classes.ID = Students.ClassID
							INNER JOIN Lessons ON Lessons.ID = Absences.LessonID
							WHERE Lessons.TeacherID = {teacherID}
                            AND Classes.ID = {classID}; ";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }

        public bool RemoveAbsence(int absenceID)
        {
            string query = $@"DELETE FROM Absences WHERE ID ='{absenceID}'; ";

            Connection.Open();

            SqlCommand commandRemoveFromBlacklist = new SqlCommand(query, Connection);
            commandRemoveFromBlacklist.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}
