using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using MVCProject.Models.Task1;
using MVCProject.Models.Task2;

namespace MVCProject.Controllers
{
    public class OWNController : Controller
    {
        public IActionResult Index()
        {
            Accessing_Data accessing_Data = new Accessing_Data();

            var accessing_data_method = accessing_Data.ImageData();

            ViewBag.Imagedetials1 = accessing_data_method;


            ViewBag.Image = "https://img.freepik.com/free-photo/painting-mountain-lake-with-mountain-background_188544-9126.jpg?w=1380&t=st=1729509161~exp=1729509761~hmac=fc04a30e85a6150dc6f8a351eb3256ed667e6b0458586fb483217b92f78f0698";
            return View();

        }
        public IActionResult Indexlist(int id)
        {
            Accessing_listcs accessing_Listcs = new Accessing_listcs();
            ViewBag.idnumber = id;

            var list_details = accessing_Listcs.Accessinglistcs(id);

            ViewBag.list = list_details;

            return View();
        }
    }
}
