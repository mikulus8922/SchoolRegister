using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.Interfaces
{
    public interface ITestsRepository
    {
        DataTable GetClassTests(int classID);

        DataTable GetLessonTests(int lessonID);

        DataTable GetTeacherTests(int teacherID);

        bool AddTest(int lessonID, string description);

        bool RemoveTest(int testID);

        bool EditTest(int testID, string description);

    }
}
