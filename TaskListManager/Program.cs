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
                    foreach(Task task in tasks) {
                        Console.WriteLine($"{task.GetId()}: {task.GetDescription()}");
                        
                    }
                }
            }
            else if(operation == "MT"){

            }
        }
    }
}