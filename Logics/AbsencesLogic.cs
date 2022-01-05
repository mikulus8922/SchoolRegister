using School.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logics
{
    public class AbsencesLogic
    {
        AbsencesRepository absencesRepository = new AbsencesRepository();

        public DataTable ValidateGetAbsences()
        {
            return absencesRepository.GetAbsences();
        }

        public DataTable ValidateGetStudentAbsences(int studentID)
        {
            return absencesRepository.GetStudentAbsences(studentID);
        }

        public DataTable ValidateGetTeacherAbsences(int teacherID)
        {
            return absencesRepository.GetTeacherAbsences(teacherID);
        }

        public bool ValidateAddAbsence(int studentID, int lessonID, bool isExcused)
        {
            return absencesRepository.AddAbsence(studentID, lessonID, isExcused);
        }

        public bool ValidateAddAbsence(int studentID, int lessonID, bool isExcused, string description)
        {
            if (description.Length > 255)
                return false;

            return absencesRepository.AddAbsence(studentID, lessonID, isExcused, description);
        }

        public bool ValidateRemoveAbsence(int absenceID)
        {
            return absencesRepository.RemoveAbsence(absenceID);
        }

        public bool ValidateEditAbsence(int absenceID, bool isExcused, string description)
        {
            if (description.Length > 255)
                return false;

            return absencesRepository.EditAbsence(absenceID, isExcused, description);
        }
    }
}
