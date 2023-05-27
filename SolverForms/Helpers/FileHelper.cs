using ProblemOne;

namespace SolverForms.Helpers
{
    public class FileHelper
    {
        public static void WriteAsBytes(object obj, string path)
        {
            using FileStream fs = File.OpenWrite(path);
            ByteSerializer.WriteStructure(obj, fs);
            fs.Close();
            fs.Dispose();
        }
        public static T ReadFromBytes<T>(string path) where T : struct
        {
            using FileStream fs = File.OpenRead(path);
            try
            {
                T data = ByteSerializer.ReadStructure<T>(fs);
                fs.Close();
                fs.Dispose();

                return data;
            }
            catch 
            {
                throw new Exception();
            }
        }

        public static void WriteToFile(string jsonString, string path)
        {
            File.WriteAllText(path, jsonString);
        }
        public static string ReadFromFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
