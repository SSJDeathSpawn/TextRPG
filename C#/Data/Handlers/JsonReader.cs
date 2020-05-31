using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.IO;

namespace TextRPG.Data.Handlers {
    public class JsonHandler {

        public static T convertJsonIntoClass<T>(string path) {
            JsonSerializerOptions options = new JsonSerializerOptions{ 
                WriteIndented = true
            };

            return (T)JsonSerializer.Deserialize(File.ReadAllText(path), typeof(T), options); 
        }
    }
}