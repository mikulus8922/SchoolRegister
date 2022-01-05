using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.Interfaces
{
    interface ILessonsRepository
    {
        DataTable GetLessons();

        DataTable GetClassLessons(int classID);

        DataTable GetTeacherLessons(int teacherID);

        bool AddLesson(DateTime date, string name, int classID, int teacherID);

        bool AddLesson(DateTime date, string name, string description, int classID, int teacherID);

        bool RemoveLesson(int lessonID);

        bool EditLesson(int lessonID, DateTime date, string name, string description, int classID, int teacherID);
    }
}
