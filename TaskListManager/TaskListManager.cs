public class TaskListManager {
    private Task[] tasks;
    private int numTasks;

    public TaskListManager() {
        this.tasks = new Task[100];
        this.numTasks = 0;
    }

    public bool HasTasks() {
        return tasks.Length > 0;
    }

    public Task[] GetTasks() {
        return tasks;
    }

    public string RegisterTask(string description) {
        tasks[numTasks] = new Task(numTasks, description);
        numTasks++;
        return tasks[numTasks-1].GetId();
    }

}