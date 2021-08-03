using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task3.Dto;

namespace Task3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<ToDoDto>> GetAll()
        {
            return Array.Empty<ToDoDto>();
        }
    }
}