using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Repositories;

namespace School.Logics
{
    public class GradesLogic
    {

        GradesRepository gradesRepository = new GradesRepository();

        public DataTable ValidateGetGrades()
        {
            return gradesRepository.GetGrades();
        }

        public DataTable ValidateGetStudentGrades(int studentID)
        {
            return gradesRepository.GetStudentGrades(studentID);
        }

        public DataTable ValidateGetClassGrades(int classID)
        {
            return gradesRepository.GetClassGrades(classID);
        }

        public bool ValidateAddGrade(int studentID, int lessonID, int grade, int weight, string type)
        {
            if (grade < 1 || grade > 6)
                return false;
            if (weight < 1 || weight > 3)
                return false;
            if (type.Length > 50)
                return false;

            return gradesRepository.AddGrade(studentID, lessonID, grade, weight, type);
        }

        public bool ValidateAddGrade(int studentID, int lessonID, int grade, int weight, string type, string description)
        {
            if (grade < 1 || grade > 6)
                return false;
            if (weight < 1 || weight > 3)
                return false;
            if (type.Length > 50)
                return false;
            if (description.Length > 255)
                return false;

            return gradesRepository.AddGrade(studentID, lessonID, grade, weight, type, description);
        }

        public bool ValidateRemoveGrade(int gradeID)
        {
            return gradesRepository.RemoveGrade(gradeID);
        }

        public bool ValidateEditGrade(int gradeID, int grade, int weight, string type)
        {
            if (grade < 1 || grade > 6)
                return false;
            if (weight < 1 || weight > 3)
                return false;
            if (type.Length > 50)
                return false;

            return gradesRepository.EditGrade(gradeID, grade, weight, type);
        }

        public bool ValidateEditGrade(int gradeID, int grade, int weight, string type, string description)
        {
            if (grade < 1 || grade > 6)
                return false;
            if (weight < 1 || weight > 3)
                return false;
            if (type.Length > 50)
                return false;
            if (description.Length > 255)
                return false;

            return gradesRepository.EditGrade(gradeID, grade, weight, type, description);
        }
    }
}
