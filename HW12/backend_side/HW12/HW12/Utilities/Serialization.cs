using HW12.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace HW12.Utilities
{
    public class Serialization
    {
        public string SerializeToJson (List<SignupModel> users)
        {
            return JsonConvert.SerializeObject (users);
        }

        public SignupModel DeserializeJson (string json)
        {
            return JsonConvert.DeserializeObject<SignupModel> (json);
        }
    }
}
