using School.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logics
{
    public class TestsLogic
    {
        TestsRepository testsRepository = new TestsRepository();

        public DataTable ValidateGetClassTests(int classID)
        {
            return testsRepository.GetClassTests(classID);
        }

        public bool ValidateAddTest(int lessonID, string description)
        {
            if (description.Length > 255)
                return false;

            return testsRepository.AddTest(lessonID, description);
        }

        public bool ValidateRemoveTest(int testID)
        {
            return testsRepository.RemoveTest(testID);
        }

        public bool ValidateEditTest(int testID, string description)
        {
            if (description.Length > 255)
                return false;

            return testsRepository.EditTest(testID, description);
        }
    }
}
