public class Task {
    private string id;
    private string description;

    public Task(int id, string description) {
        this.id = $"{id}";
        this.description = description;
    }

    public string GetId() {
        return id;
    }

    public string GetDescription() {
        return description;
    }
}