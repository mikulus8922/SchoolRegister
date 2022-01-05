using School.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logics
{
    public class LessonsLogic
    {
        LessonsRepository lessonsRepository = new LessonsRepository();

        public DataTable ValidateGetLessons()
        {
            return lessonsRepository.GetLessons();
        }

        public DataTable ValidateGetClassLessons(int classID)
        {
            return lessonsRepository.GetClassLessons(classID);
        }

        public DataTable ValidateGetTeacherLessons(int teacherID)
        {
            return lessonsRepository.GetTeacherLessons(teacherID);
        }

        public bool ValidateAddLesson(DateTime date, string name, int classID, int teacherID)
        {
            if (name.Length > 50)
                return false;

            return lessonsRepository.AddLesson(date, name, classID, teacherID);
        }

        public bool ValidateAddLesson(DateTime date, string name, string description, int classID, int teacherID)
        {
            if (name.Length > 50)
                return false;
            if (description.Length > 255)
                return false;

            return lessonsRepository.AddLesson(date, name, description, classID, teacherID);
        }

        public bool ValidateRemoveLesson(int lessonID)
        {
            return lessonsRepository.RemoveLesson(lessonID);
        }

        public bool ValidateEditLesson(int lessonID, DateTime date, string name, string description, int classID, int teacherID)
        {
            if (name.Length > 50)
                return false;
            if (description.Length > 255)
                return false;

            return lessonsRepository.EditLesson(lessonID, date, name, description, classID, teacherID);
        }
    }
}
