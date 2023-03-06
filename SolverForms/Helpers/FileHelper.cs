namespace SolverForms.Helpers
{
    public class FileHelper
    {
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
