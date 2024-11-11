using Microsoft.AspNetCore.Mvc;
using System.Web;
//using Newtonsoft.Json;
using MVCProject.Models.Task3;
using System.Text.Json;
using System.Xml.Linq;
namespace MVCProject.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Table_View() 
        {
            // task to show the value in table
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data/Data_Storage.json");

            // Read the JSON file
            string jsonString = System.IO.File.ReadAllText(jsonFilePath);

            // Deserialize the JSON string to a list to store data

            List<Table_datamodel> data = JsonSerializer.Deserialize<List<Table_datamodel>>(jsonString);
            return View(data);
        }
    }
}
