using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.Interfaces
{
    public interface ISystemUsersRepository
    {
        DataTable GetUsers();

        DataTable GetUser(int userID);

        DataTable GetUser(string login, string passwordHash);

        bool AddUser(string firstName, string lastName, string gender, string birthDate, string PESEL, string login, string passwordHash, bool isAdmin);

        bool EditUser(int userID, string firstName, string lastName, string gender, string birthDate, string PESEL, string login, string passwordHash, bool isAdmin);

        bool RemoveUser(int userID);
/*
        bool AddTeacher(int userID, string occupation);

        bool EditTeacher(int teacherID, string occupation);

        bool AddParent(int userID, int studentID);

        bool EditParent(int parentID, int studentID);

        bool AddStudent(int userID, int classID);

        bool EditStudent(int studentID, int classID);

        bool AddLesson(DateTime date, string name, string description, int classID, int teacherID);

        bool EditLesson(int lessonID, DateTime date, string name, string description, int classID, int teacherID);
*/
    }
}
