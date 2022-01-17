using School.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logics
{
    public class ClassesLogic
    {
        ClassesRepository classesRepository = new ClassesRepository();

        public DataTable ValidateGetClasses()
        {
            return classesRepository.GetClasses();
        }

        public bool ValidateAddClass(string name, string description, int yearOfCreation, int teacherID)
        {
            if (name.Length > 2)
                return false;
            if (yearOfCreation > 2050 || yearOfCreation < 2000)
                return false;
            if (description.Length > 50)
                return false;

            return classesRepository.AddClass(name, description, yearOfCreation, teacherID);
        }

        public bool ValidateRemoveClass(int classID)
        {
            return classesRepository.RemoveClass(classID);
        }

        public bool ValidateEditClass(int classID, string name, string description, int yearOfCreation, int teacherID)
        {
            if (name.Length > 2)
                return false;
            if (yearOfCreation > 2050 || yearOfCreation < 2000)
                return false;
            if (description.Length > 50)
                return false;

            return classesRepository.EditClass(classID, name, description, yearOfCreation, teacherID);
        }
    }
}
