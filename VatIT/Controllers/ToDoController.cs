using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VatIT.Models;
using VatIT.Results;

namespace VatIT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private IList<ToDo> ToDos;
        public ToDoController()
        {
            this.ToDos = new List<ToDo>() { new ToDo("Todo1", 1, false), new ToDo("Todo2", 2, false), new ToDo("Todo3", 3, false), new ToDo("Todo4", 4, false) };
        }

        [HttpGet]
        public ActionResult<IList<ToDo>> GetTodos()
        {
            try
            {
                var result = new GetTodosResult(ToDos.Select(f => new Models.ToDo() { Completed = f.Completed, ID = f.ID, Name = f.Name }).ToList());
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(new ErrorResult("Something went wrong"));
            }
        }
    }
}
