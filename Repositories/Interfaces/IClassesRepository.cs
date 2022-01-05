using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.Interfaces
{
    public interface IClassesRepository
    {
        DataTable GetClasses();

        bool AddClass(string name, string description, int yearOfCreation, int teacherID);

        bool RemoveClass(int classID);

        bool EditClass(int classID, string name, string description, int yearOfCreation, int teacherID);
    }
}
