public class Program {
    public static void Main(string[] args) {
        TaskListManager manager = new TaskListManager(); 
        while (true) {
            string line = Console.ReadLine();
            // Exemplo: "RT Primeira tarefa" -> ["RT","Primeira","tarefa"]
            string[] tokens = line.Split(" ");
            string operation = tokens[0];
            if(operation == "Q") {
                break;
            }
            else if(operation == "RT"){
                // tokens = ["RT","Primeira","tarefa"]
                string description = string.Join(" ", tokens.Skip(1));
                string taskId = manager.RegisterTask(description);
                Console.WriteLine($"Tarefa registada com identificador {taskId}");
            }
            else if(operation == "LT"){
                if(!manager.HasTasks()) {
                    Console.WriteLine("Sem tarefas registadas.");
                }
                else {
                    Task[] tasks = manager.GetTasks();
                    for(int i = 0; i < manager.NumTasks(); i++) {
                        Task task = tasks[i];
                        string status = task.GetStatus() ? "Completa" : "Por Completar";
                        // string status;
                        // if(task.GetStatus()) {
                        //     status = "Completa";
                        // }
                        // else {
                        //     status = "Por Completar";
                        // }
                        Console.WriteLine($"[{status}] {task.GetId()}: {task.GetDescription()}");
                    }
                }
            }
            else if(operation == "MT"){
                // line = "MT 2"         <- string
                // tokens = ["MT", "2"]  <- string[]
                string id = tokens[1];
                if(!manager.HasTask(id)) {
                    Console.WriteLine("Tarefa inexistente.");
                }
                else {
                    manager.MarkTask(id);
                    Console.WriteLine("Tarefa concluída com sucesso.");
                }
            }
        }
    }
}