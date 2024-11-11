using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Web;
using System.Linq;
using System.Collections.Generic;
using System;


using MVCProject.Models.service;

namespace MVCProject.Controllers
{
	public class DB_task_Controller : Controller
	{

        //private readonly string _connectionString;
        //private readonly Accessing_DB _accessing_DB;

        //// Constructor accepts IConfiguration to get the connection string
        //public DB_task_Controller(IConfiguration configuration, Accessing_DB accessingDB)
        //{
        //    _connectionString = configuration.GetConnectionString("DefaultConnection");
        //    _accessing_DB = accessingDB;
        //}

        public Accessing_DB _accessing_DB;

        public DB_task_Controller(Accessing_DB accessingDB)
        {
            _accessing_DB = accessingDB;
        }

        //Accessing_DB _accessing_DB = new Accessing_DB();

        // GET: DB_task_Controller
        public ActionResult Index()
		{
			var DB_list1 = _accessing_DB.GetData();

			if (DB_list1.Count == 0)
			{
				TempData["InfoMessage"] = "No Student Detials Avilable.";
			}

			return View(DB_list1);
		}

		// GET: DB_task_Controller/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: DB_task_Controller/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: DB_task_Controller/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: DB_task_Controller/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: DB_task_Controller/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: DB_task_Controller/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: DB_task_Controller/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
