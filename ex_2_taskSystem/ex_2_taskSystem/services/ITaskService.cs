namespace ex_2_taskSystem.Models
{
    public interface ITaskService
    {
        public void CreateTask(Taskk t);
        void UpdateTask(string title, Taskk t);
        void DeleteTask(string tsk);
        public List<Taskk> getAllTasks();

    }
}
