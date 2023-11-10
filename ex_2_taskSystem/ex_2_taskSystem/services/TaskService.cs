using ex_2_taskSystem.Models;
using System.Diagnostics;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace ex_2_taskSystem.services
{
    public class TaskService : ITaskService { 

    static Taskk t1 = new Taskk { Title = "raed", Description ="readread", DestDate = DateTime.Today, MyPriority = MyPriority.high };
    static Taskk t2 = new Taskk { Title = "hw", Description = "hwhw", DestDate = DateTime.Today, MyPriority = MyPriority.low };
    static Taskk t3 = new Taskk{ Title = "play", Description = "playplay", DestDate = DateTime.MaxValue, MyPriority = MyPriority.medium };
    static List<Taskk> taskList = new List<Taskk>() { t1, t2, t3 };
    

    //    public TaskService(ILogger<TaskService> logger)
    //{
    //}
    //=============================================
        public string addTask()
        {
            return "ok";
        }
        //=============================================
        public void CreateTask(Taskk t)
        {
            taskList.Add(t);
            return;
        }
        //=============================================
        public void DeleteTask(string tsk)
        {
            Taskk t = taskList.Find(e => e.Title == tsk);
            taskList.Remove(t);
        }
        //=============================================
        public void UpdateTask(string title, Taskk t)
        {
            Taskk tsk = taskList.Find(e => e.Title == title);

            tsk.Description = t.Description;
            tsk.DestDate = t.DestDate;
            tsk.MyPriority = t.MyPriority;

        }
        //=============================================
        public List<Taskk> getAllTasks()
        {
           return taskList;

        }
    }
}
