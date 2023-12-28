using HW12.Models;
using Newtonsoft.Json;

namespace HW12.DataBase
{
    public static class TempDataBase
    {
        public static List<SignupModel>? users = new List<SignupModel>();

        public static List<SignupModel> LoadUsers(string path)
        {
            string jsonUsers = File.ReadAllText(path);
            var users = JsonConvert.DeserializeObject<List<SignupModel>>(jsonUsers);
            return users;
        }
    }
}
