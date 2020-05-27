using System.Text.Json;
using System.Text.Json.Serialization;

namespace TextRPG.Resources.Templates {
    public class Connection {
        
        public Connection() {
            North = null;
            East = null;
            South = null;
            West = null;
            Outside = null;
            ne = null;
            nw = null;
            se = null;
            sw = null;
        }

        public string North { get; set; }
        public string East { get; set; }
        public string South { get; set; }
        public string West { get; set; }
        public string Outside { get; set; }

        [JsonPropertyName("north-east")] 
        public string ne { get; set; }
        [JsonPropertyName("north-west")]
        public string nw { get; set; }
        [JsonPropertyName("south-east")]
        public string se { get; set; }
        [JsonPropertyName("south-west")]
        public string sw { get; set; }
    }
}