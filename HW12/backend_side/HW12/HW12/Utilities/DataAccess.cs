using HW12.Models;
using Newtonsoft.Json;

namespace HW12.Utilities
{
    public class DataAccess
    {
        private readonly string _path;
        public DataAccess(string path)
        {
            this._path = path;
        }
        public void SaveData (string json)
        {
            File.WriteAllText (_path, json);
        }

        public List<SignupModel> ReadFile ()
        {
            var fileData = File.ReadAllText (_path);
            return JsonConvert.DeserializeObject<List<SignupModel>>(fileData);
        }
    }
}
