

using Newtonsoft.Json;

namespace MVCProject.Models.service

{
    public static class ConfigurationManager 
    {
        public static string _filePath = "C:\\Users\\badri\\source\\repos\\MVCProject\\MVCProject\\appsettings.json";
        public static string getconstr()
        {
            if (File.Exists(_filePath))
            {
                Console.WriteLine($"Config file found at {_filePath}"); // Debug statement
                var json = File.ReadAllText(_filePath);
                var settings = JsonConvert.DeserializeObject<dynamic>(json);
                return settings.ConnectionStrings.DefaultConnection;
            }
            else
            {
                Console.WriteLine($"Config file not found at {_filePath}"); // Debug statement
                return null; // Handle the absence of the configuration file appropriately
            }
        }
    }
}
