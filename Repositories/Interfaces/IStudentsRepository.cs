using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.Interfaces
{
    public interface IStudentsRepository
    {
        DataTable GetStudents();

        DataTable GetStudents(int classID);

        DataTable GetStudent(int studentID);

        DataTable GetStudentID(int userID);

        bool AddStudent(int systemUserID, int classID);

        bool RemoveStudent(int studentID);

        bool EditStudent(int studentID, int classID);
    }
}
