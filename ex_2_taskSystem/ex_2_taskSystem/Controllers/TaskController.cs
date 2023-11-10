using ex_2_taskSystem.Models;
using ex_2_taskSystem.services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ex_2_taskSystem.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class TaskController : ControllerBase
    {
        private ITaskService taskService = new TaskService();
   
        [HttpPost]
        public void Create([FromBody] Taskk task)
        {
            taskService.CreateTask(task);
            return;
            //return 4;
        }
     

        //==========================================================


        [HttpPut("updateTask")]
        public void Put (string title, [FromBody] Taskk tsk)
        {
            taskService.UpdateTask(title, tsk);
        }
        //==========================================================
        [HttpDelete("deleteTask")]
        public void Delete(string title)
        {
            taskService.DeleteTask(title);
        }
        //===============================================
        [HttpGet("getAllTasks")]
        public List<Taskk> Get()
        {
            List<Taskk> t = new List<Taskk>();
            t= taskService.getAllTasks();
            return t;
        }
    }
}
