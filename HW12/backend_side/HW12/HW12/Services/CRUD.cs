using HW12.DataBase;
using HW12.Models;
using HW12.Utilities;

namespace HW12.Services
{
    public class CRUD
    {
        public List<SignupModel> ReadAllUsers ()
        {
            return TempDataBase.users;
        }
    }
}
