using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.Interfaces
{
    public interface IGradesRepository
    {
        DataTable GetGrades();

        DataTable GetStudentGrades(int studentID);

        DataTable GetClassGrades(int classID);

        bool AddGrade(int studentID, int lessonID, int grade, int weight, string type);

        bool AddGrade(int studentID, int lessonID, int grade, int weight, string type, string description);

        bool RemoveGrade(int gradeID);

        bool EditGrade(int gradeID, int grade, int weight, string type);

        bool EditGrade(int gradeID, int grade, int weight, string type, string description);
    }
}
