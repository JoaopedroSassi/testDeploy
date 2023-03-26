using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
		List<Todo> todos = new();

		public TodoController()
		{
			todos.Add(new Todo(1, "Fazer deploy", true));
		}
		
        [HttpGet]
		public IActionResult Get()
		{
			return Ok(todos);
		}
    }
}