using School.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logics
{
    public class TeachersLogic
    {
        TeachersRepository teachersRepository = new TeachersRepository();

        public DataTable ValidateGetTeachers()
        {
            return teachersRepository.GetTeachers();
        }

        public DataTable ValidateGetTeacherID(int userID)
        {
            return teachersRepository.GetTeacherID(userID);
        }

        public bool ValidateAddTeacher(int userID, string occupation)
        {
            if (occupation.Length > 50)
                return false;

            return teachersRepository.AddTeacher(userID, occupation);
        }

        public bool ValidateEditTeacher(int teacherID, string occupation)
        {
            if (occupation.Length > 50)
                return false;

            return teachersRepository.EditTeacher(teacherID, occupation);
        }

        public bool ValidateRemoveTeacher(int teacherID)
        {
            return teachersRepository.RemoveTeacher(teacherID);
        }
    }
}
