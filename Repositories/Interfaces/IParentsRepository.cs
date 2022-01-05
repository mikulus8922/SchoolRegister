using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.Interfaces
{
    public interface IParentsRepository
    {
        DataTable GetParents();

        DataTable GetParentID(int userID);

        bool AddParent(int userID, int studentID);

        bool RemoveParent(int parentID);
    }
}
