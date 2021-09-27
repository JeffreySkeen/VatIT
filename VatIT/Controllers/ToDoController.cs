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
        // popultate Dictionary with data to work with
        private static Dictionary<int, ToDo> ToDos = new Dictionary<int, ToDo>() { { 1, new ToDo("Do Some Work", 1, false) } };

        [HttpGet("todos")]
        public ActionResult<IList<ToDo>> GetTodos()
        {
            try
            {
                var result = new GetTodosResult(ToDos.Values.Select(f => new Models.ToDo() { Completed = f.Completed, ID = f.ID, Name = f.Name }).ToList());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorResult("Something went wrong"));
            }
        }
        [HttpPost("todos")]
        public ActionResult CreateToDo([FromBody] Models.ToDo toDo)
        {
            try
            {
                if (ToDos.ContainsKey(toDo.ID))
                    return BadRequest(new ErrorResult("ToDo with ID " + toDo.ID + " already exists"));

                if (toDo.Name =="I'm lazy")
                    throw new Exception("Name cannot be 'I'm lazy'.");

                ToDos.Add(toDo.ID, ToDo.Create(toDo.Name, toDo.ID, toDo.Completed));
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorResult("Something went wrong: " + ex.Message));
            }
        }

        [HttpPut("todos/{id}")]
        public ActionResult<Models.ToDo> UpdateToDo([FromBody] Models.ToDo toDo, int id)
        {
            try
            {
                ToDo existingTodo;

                if (!ToDos.TryGetValue(id, out existingTodo))
                    return NotFound(new ErrorResult("Cannot find ToDo with ID:" + id));

                if(toDo.Name == "I'm lazy")
                    throw new Exception("Name cannot be 'I'm lazy'.");

                existingTodo.Name = toDo.Name;
                existingTodo.Completed = toDo.Completed;

                return Ok(new Models.ToDo()
                {
                    ID = existingTodo.ID,
                    Name = existingTodo.Name,
                    Completed = existingTodo.Completed
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorResult("Something went wrong"));
            }
        }

        [HttpDelete("todos/{id}")]
        public ActionResult DeleteTodo(int id)
        {
            try
            {
                if (ToDos.Remove(id))
                    return Ok();
                else
                    return NotFound(new ErrorResult("Cannot find ToDo with ID:" + id));

            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorResult("Something went wrong"));
            }
        }
    }
}
