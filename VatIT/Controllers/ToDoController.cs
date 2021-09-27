using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VatIT.Models;

namespace VatIT.Controllers
{
    public class ToDoController : Controller
    {
        private IList<ToDo> ToDos;
        public ToDoController()
        {
            this.ToDos = new List<ToDo>() { new ToDo("Todo1", 1, false), new ToDo("Todo2", 2, false), new ToDo("Todo3", 3, false), new ToDo("Todo4", 4, false) };
        }
    }
}
