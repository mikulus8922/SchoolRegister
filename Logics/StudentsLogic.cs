using School.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logics
{
    public class StudentsLogic
    {
        StudentsRepository studentsRepository = new StudentsRepository();

        public DataTable ValidateGetStudents()
        {
            return studentsRepository.GetStudents();
        }

        public DataTable ValidateGetStudents(int classID)
        {
            return studentsRepository.GetStudents(classID);
        }

        public DataTable ValidateGetStudent(int studentID)
        {
            return studentsRepository.GetStudent(studentID);
        }

        public DataTable ValidateGetStudentID(int userID)
        {
            return studentsRepository.GetStudentID(userID);
        }

        public bool ValidateAddStudent(int systemUserID, int classID)
        {
            return studentsRepository.AddStudent(systemUserID, classID);
        }

        public bool ValidateRemoveStudent(int studentID)
        {
            return studentsRepository.RemoveStudent(studentID);
        }

        public bool ValidateEditStudent(int studentID, int classID)
        {
            return studentsRepository.EditStudent(studentID, classID);
        }
    }
}
