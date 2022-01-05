using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.Interfaces
{
    public interface IAbsencesRepository
    {
        DataTable GetAbsences();

        DataTable GetStudentAbsences(int studentID);

        DataTable GetTeacherAbsences(int teacherID);

        bool AddAbsence(int studentID, int lessonID, bool isExcused);

        bool AddAbsence(int studentID, int lessonID, bool isExcused, string description);

        bool RemoveAbsence(int absenceID);

        bool EditAbsence(int absenceID, bool isExcused, string description);
    }
}
