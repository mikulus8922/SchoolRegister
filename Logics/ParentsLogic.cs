using School.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logics
{
    public class ParentsLogic
    {
        ParentsRepository parentsRepository = new ParentsRepository();

        public DataTable ValidateGetParents()
        {
            return parentsRepository.GetParents();
        }

        public DataTable ValidateGetParentID(int userID)
        {
            return parentsRepository.GetParentID(userID);
        }

        public bool ValidateAddParent(int userID, int studentID)
        {
            return parentsRepository.AddParent(userID, studentID);
        }

        public bool ValidateRemoveParent(int parentID)
        {
            return parentsRepository.RemoveParent(parentID);
        }

    }
}
