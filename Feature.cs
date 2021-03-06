using Newtonsoft.Json;

namespace BulletTrain
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Feature
    {
        [JsonProperty]
        private string name = null;

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
