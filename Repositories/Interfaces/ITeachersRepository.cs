using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.Interfaces
{
    public interface ITeachersRepository
    {
        DataTable GetTeachers();

        DataTable GetTeacherID(int userID);

        bool AddTeacher(int userID, string occupation);

        bool EditTeacher(int teacherID, string occupation);

        bool RemoveTeacher(int teacherID);
    }
}
