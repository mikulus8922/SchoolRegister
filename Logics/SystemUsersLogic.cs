using School.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logics
{
    public class SystemUsersLogic
    {
        SystemUsersRepository systemUsersRepository = new SystemUsersRepository();

        public DataTable ValidateGetUsers()
        {
            return systemUsersRepository.GetUsers();
        }


        public DataTable ValidateGetUser(int userID)
        {
            return systemUsersRepository.GetUser(userID);
        }

        public DataTable ValidateGetUser(string login, string passwordHash)
        {
            return systemUsersRepository.GetUser(login, passwordHash);
        }

        public bool ValidateAddUser(string firstName, string lastName, string gender, string birthDate, string PESEL, string login, string passwordHash, bool isAdmin)
        {
            if (firstName.Length > 50)
                return false;
            if (lastName.Length > 50)
                return false;
            if (!String.Equals(gender, "Male") && !String.Equals(gender, "Female"))
                return false;
            if (birthDate.Length > 4)
                return false;
            if (PESEL.Length != 11)
                return false;
            if (login.Length > 50)
                return false;
            if (passwordHash.Length != 64)
                return false;


            return systemUsersRepository.AddUser(firstName, lastName, gender, birthDate, PESEL, login, passwordHash, isAdmin);
        }

        public bool ValidateEditUser(int userID, string firstName, string lastName, string gender, string birthDate, string PESEL, string login, string passwordHash, bool isAdmin)
        {
            if (firstName.Length > 50)
                return false;
            if (lastName.Length > 50)
                return false;
            if (!String.Equals(gender, "Male") && !String.Equals(gender, "Female"))
                return false;
            if (birthDate.Length > 4)
                return false;
            if (PESEL.Length != 11)
                return false;
            if (login.Length > 50)
                return false;
            if (passwordHash.Length != 64)
                return false;

            return systemUsersRepository.EditUser(userID, firstName, lastName, gender, birthDate, PESEL, login, passwordHash, isAdmin);
        }

        public bool ValidateRemoveUser(int userID)
        {
            return systemUsersRepository.RemoveUser(userID);
        }
    }
}
