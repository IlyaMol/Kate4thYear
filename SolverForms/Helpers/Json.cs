using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace SolverForms.Helpers
{
    public  class Json
    {
        public static string Serialize(object obj, bool prettyfy = false)
        {
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions 
            { 
                WriteIndented = prettyfy,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            });
        }
        public static T? Deserialize<T>(string jsonString) where T : notnull
        {
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
