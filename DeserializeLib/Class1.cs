using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DeserializeLib
{
    public class Serialization
    {
        public static void Serialize<T>(T models)
        {
            string json = JsonConvert.SerializeObject(models);
            // Простите, София Алексеевна, получается только через полный путь, не получается через относительный
            File.WriteAllText("C:\\Users\\paulscriptum\\source\\repos\\Library\\Library\\json\\File.json", json);
        }

        public static T Deserialize<T>()
        {
            string json = File.ReadAllText("C:\\Users\\paulscriptum\\source\\repos\\Library\\Library\\json\\File.json");
            T models = JsonConvert.DeserializeObject<T>(json);
            return models;
        }
    }
}