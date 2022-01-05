using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public static class UserData
    {
        public static int userID = 0;

        public static bool isStudent = false;
        public static int studentID = 0;

        public static bool isParent = false;
        public static int parentID = 0;

        public static bool isTeacher = false;
        public static int teacherID = 0;

        public static bool isAdmin = false;

        public static void reset()
        {
            userID = 0;

            isStudent = false;
            studentID = 0;

            isParent = false;
            parentID = 0;

            isTeacher = false;
            teacherID = 0;

            isAdmin = false;
        }

    }
}
