using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_One.Models;


namespace Project_One.Controllers
{
    public class TodoItemsController : Controller
    {

        private static List<TodoItemModel> Data = new List<TodoItemModel>
        {
            new TodoItemModel{Id = 1, Description="asd", Name="Jonas"},
            new TodoItemModel{Id = 2, Description="asdf", Name="Jonas2"}
        };
        // GET: 

        public ActionResult Index()
        {
            return View(Data);
        }

        // GET: TodoItems/Details/5
        public ActionResult Details(int id)
        {
            return View(Data);
        }

        // GET: TodoItems/Create
        public ActionResult Create()
        {
            return View(Data);
        }

        // GET: TodoItems/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Data);
        }

        // GET: TodoItems/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Data);
        }

    }
}