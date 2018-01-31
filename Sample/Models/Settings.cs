using Newtonsoft.Json;

namespace Sample.Models
{
    public class Settings
    {
        [JsonProperty("connectionString")]
        public string ConnStr { get; set; }
        [JsonProperty("filePath")]
        public string Path { get; set; }
    }
}
