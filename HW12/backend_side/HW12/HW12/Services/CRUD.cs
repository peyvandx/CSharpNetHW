using HW12.DataBase;
using HW12.Models;
using HW12.Utilities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HW12.Services
{
    public class CRUD
    {
        Serialization serialization = new Serialization();
        DataAccess dataAccess = new DataAccess("DataBase.json");
        public List<SignupModel> ReadAllUsers ()
        {
            return TempDataBase.users;
        }

        public bool UpdateUser(SignupModel model)
        {
            var updatingUser = TempDataBase.users.FirstOrDefault(u => u.ID == model.ID);

            if (updatingUser != null)
            {
                updatingUser.FirstName = model.FirstName;
                updatingUser.LastName = model.LastName;
                updatingUser.Email = model.Email;
                updatingUser.Password = model.Password;
                updatingUser.PhoneNumber = model.PhoneNumber;
                updatingUser.Address = model.Address;
                updatingUser.Gender = model.Gender;
                var jsonUsers = serialization.SerializeToJson(TempDataBase.users);
                dataAccess.SaveData(jsonUsers);
                return true;
            }

            return false;
        }

        public bool DeleteUser(string id)
        {
            var selectedUser = TempDataBase.users.FirstOrDefault(u => u.ID.ToString() == id);
            if (selectedUser != null)
            {
                TempDataBase.users.Remove(selectedUser);
                var jsonUsers = serialization.SerializeToJson(TempDataBase.users);
                dataAccess.SaveData(jsonUsers);
                return true;
            }
            return false;
        }
    }
}
